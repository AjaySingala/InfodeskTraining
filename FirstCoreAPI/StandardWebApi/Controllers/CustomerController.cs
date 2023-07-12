using Antlr.Runtime;
using StandardWebApi.Models;
using StandardWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StandardWebApi.Controllers
{
    //[EnableCors(origins:"http://www.myclient.com",methods:"GET POST",headers:"*")]
    public class CustomerController : ApiController
    {
        IDataRepository<Customer> _repo;

        public CustomerController(IDataRepository<Customer> repo)
        {
            _repo = repo;    
        }

        public Customer Get(int id)
        {
            var customer = _repo.Get(id);

            return customer;
        }

        public List<Customer> Get()
        {
            var customers = _repo.Get();

            return customers;

        }
    }
}
