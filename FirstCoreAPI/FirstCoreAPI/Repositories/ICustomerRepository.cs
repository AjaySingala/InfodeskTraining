using FirstCoreAPI.Models;

namespace FirstCoreAPI.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int id);
        int Create(Customer customer);
        void Update(int id, Customer customer);
        void Delete(int id);
    }
}
