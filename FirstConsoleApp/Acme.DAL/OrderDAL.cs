using Acme.Entities;

namespace Acme.DAL
{
    public class OrderDAL
    {
        public List<Order> GetOrders(int customerId)
        {
            List<Order> orders = new List<Order>();
            // Connect to the database.
            // fetch all orders for the given customer.
            // return a list of orders.
            return orders;
        }

    }
}