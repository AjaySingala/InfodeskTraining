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

        public int Create(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();

            return customer.Id;
        }

        public void Update(int id, Customer customerToUpdate)
        {
            var customer = _db.Customers.Find(id);
            if (customer == null)
            {
                throw new Exception($"Customer with Id {id} not found.");
            }
            customer.Firstname = customerToUpdate.Firstname;
            customer.Lastname = customerToUpdate.Lastname;

            _db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //_db.Update(customer);

            _db.SaveChanges(true);
        }

        public void Delete(int id)
        {
            var customer = _db.Customers.Find(id);
            if (customer == null)
            {
                throw new Exception($"Customer with Id {id} not found.");
            }
            _db.Remove(customer);
            _db.SaveChanges();
        }
    }
}
