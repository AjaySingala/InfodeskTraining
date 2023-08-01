using SampleAPI.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SampleAPI.Repositories
{
    public class TestCustomerRepository : ICustomerRepository
    {
        static List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 101, Firstname = "John", Lastname = "Test" },
            new Customer { Id = 102, Firstname = "Mary", Lastname = "Test" },
            new Customer { Id = 103, Firstname = "Jeo", Lastname = "Test" },
            new Customer { Id = 104, Firstname = "Peter", Lastname = "Test" },
            new Customer { Id = 105, Firstname = "Ethan", Lastname = "Test" }
        };

        public List<Customer> Get()
        {
            return _customers.ToList<Customer>();
        }

        public Customer Get(int id)
        {
            return _customers.Where(c => c.Id == id).SingleOrDefault<Customer>();
        }
    }
}
