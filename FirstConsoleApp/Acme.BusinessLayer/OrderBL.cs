using Acme.DAL;
using Acme.Entities;

namespace Acme.BusinessLayer
{
    public class OrderBL
    {
        public List<Order> GetOrders(int customerId)
        {
            // code to get and process customer's orders.
            OrderDAL dal = new OrderDAL();
            var orders = dal.GetOrders(customerId);
            // Process the orders here.

            // return list of orders.
            return orders;
        }
    }
}