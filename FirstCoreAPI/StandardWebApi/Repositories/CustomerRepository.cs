using StandardWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardWebApi.Repositories
{
    public class CustomerRepository : IDataRepository<Customer>
    {
        CustomerDbContext _db;

        public CustomerRepository(CustomerDbContext context) 
        {
            _db = context;
        }
        
        public Customer Get(int id)
        {
            var customer = _db.Customers.Find(id);
            return customer;
        }

        public List<Customer> Get()
        {
            var customers = _db.Customers.ToList();

            return customers;
        }

        public int Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}