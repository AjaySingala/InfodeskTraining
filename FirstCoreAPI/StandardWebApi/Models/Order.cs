using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardWebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
    }
}