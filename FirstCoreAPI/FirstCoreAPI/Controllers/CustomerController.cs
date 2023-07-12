using FirstCoreAPI.Models;
using FirstCoreAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ClientOneOrigin")]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _repo;
        ILogger<CustomerController> _logger;

        public CustomerController(ICustomerRepository repo, ILogger<CustomerController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        //[DisableCors]
        public async Task<List<Customer>> Get()
        {
            _logger.LogDebug("DEBUG! Inside CustomerController.Get()....");
            _logger.LogInformation("INFO! Inside CustomerController.Get()....");
            _logger.LogWarning("WARN! Inside CustomerController.Get()....");
            _logger.LogTrace("TRACE! Inside CustomerController.Get()....");
            _logger.LogError("ERROR! Inside CustomerController.Get()....");
            _logger.LogCritical("CRITICAL! Inside CustomerController.Get()....");

            var customers = _repo.Get();
            return customers;
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<Customer> Get(int id)
        {
            _logger.LogDebug("Inside CustomerController.Get(int id)....");
            var customer = _repo.Get(id);

            return customer;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Validation failed");
            }

            var id = _repo.Create(customer);

            //return HttpStatusCode.Created;
            //return customer.Id;
            return CreatedAtRoute("GetById", new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Customer customer)
        {
            _logger.LogDebug("Inside CustomerController.Update()....");
            try
            {
                _repo.Update(id, customer);
                //return HttpStatusCode.NoContent;
                return NoContent();
            } catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            try
            {
                _repo.Delete(id);
                return NoContent();
            }catch(Exception ex)
            {
                return StatusCode(404, $"Customer with Id {id} not found.");
            }
        }
    }
}
