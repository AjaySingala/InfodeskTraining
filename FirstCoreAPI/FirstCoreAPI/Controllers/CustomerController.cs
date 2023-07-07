using FirstCoreAPI.Models;
using FirstCoreAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace FirstCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _repo;

        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _repo.Get();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _repo.Get(id);
        }
    }
}
