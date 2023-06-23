using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        public List<OrderDetails> Details { get; set; }

        public Order()
        {
            Details = new List<OrderDetails>();
        }
    }
}
