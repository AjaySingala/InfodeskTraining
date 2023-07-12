//using Microsoft.EntityFrameworkCore;

namespace FirstMinimalAPI
{
    public class CustomerDbContext //: DbContext
    {
        // public DbSet<Customer> Customers { get; set; }

        //public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        //    :base(options)
        //{
            
        //}

        public List<Customer> Customers = new List<Customer>();
        public void SaveChanges()
        {
            return;
        }
    }
}
