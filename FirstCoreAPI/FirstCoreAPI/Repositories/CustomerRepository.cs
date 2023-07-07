using FirstCoreAPI.Models;

namespace FirstCoreAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDbContext _db;

        public CustomerRepository(CustomerDbContext dbContext)
        {
            _db = dbContext;
        }

        public List<Customer> Get()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public Customer Get(int id)
        {
            var customer = _db.Customers.Find(id);
            return customer;
        }
    }
}
