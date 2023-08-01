using SampleAPI.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SampleAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        static List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Firstname = "John", Lastname = "Smith" },
            new Customer { Id = 2, Firstname = "Mary", Lastname = "Jane" },
            new Customer { Id = 3, Firstname = "Jeo", Lastname = "Sequiera" },
            new Customer { Id = 4, Firstname = "Peter", Lastname = "Quill" },
            new Customer { Id = 5, Firstname = "Ethan", Lastname = "Hunt" }
            //, new Customer { Id = 6, Firstname = "Sophie", Lastname = "Ellis" }
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
