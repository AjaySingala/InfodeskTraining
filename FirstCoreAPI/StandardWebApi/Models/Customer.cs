using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardWebApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}