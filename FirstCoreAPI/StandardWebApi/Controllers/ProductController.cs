using StandardWebApi.Models;
using StandardWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StandardWebApi.Controllers
{
    public class ProductController : ApiController
    {
        IDataRepository<Product> _repo;

        public ProductController(IDataRepository<Product> repo)
        {
            _repo = repo;
        }

        public Product Get(int id)
        {
            var product = _repo.Get(id);

            return product;
        }

        public List<Product> Get()
        {
            var products = _repo.Get();

            return products;

        }
    }
}
