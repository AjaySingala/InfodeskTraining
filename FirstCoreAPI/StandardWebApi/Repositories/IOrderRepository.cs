using StandardWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardWebApi.Repositories
{
    public interface IOrderRepository : IDataRepository<Order>
    {
        decimal CalculateTax(Order order);
    }
}
