using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public class BMW : Car
    {
        public bool HasGPS { get; set; }

        public new void Start()
        {
            Console.WriteLine("BMW.Start()...");
        }

        public void TurnLeft()
        {
            Console.WriteLine("BMW.TurnLeft()...");
        }
    }
}
