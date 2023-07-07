using FirstCoreAPI.Models;

namespace FirstCoreAPI.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int id);
    }
}
