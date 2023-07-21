using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [DeBugInfo(123, "John Smith", "05/02/2023")]
    [Author("Peter", "0.1"), Author("Ajay", "0.2")]
    [Author("Neo", "1.0")]
    public class ProcessData
    {
        public string Name { get; set; }

        [DeBugInfo(123, "John Smith", "05/02/2023")]
        [DeBugInfo(456, "Mary Jane", "25/02/2023")]
        public string StartProcess()
        {
            return "Done!";
        }
    }
}
