using System.ComponentModel.DataAnnotations;

namespace FirstMinimalAPI
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
