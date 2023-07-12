using StandardWebApi.Models;
using StandardWebApi.Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace StandardWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDataRepository<Customer>, CustomerRepository>();
            container.RegisterType<IDataRepository<Product>, ProductRepository>();
            container.RegisterType<CustomerDbContext, CustomerDbContext>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}