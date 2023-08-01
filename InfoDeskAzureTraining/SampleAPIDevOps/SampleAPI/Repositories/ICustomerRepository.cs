using SampleAPI.Entities;

namespace SampleAPI.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int id);
    }
}
