using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int YearOfManufacture { get; set; }

        private string _color;

        // Readonly property.
        public int NoOfTyres
        {
            get
            {
                if (Make == "Honda")
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
       }

        //public Car(int id, int year, string make)
        //{
        //    Id = id;
        //    Make = make;
        //    YearOfManufacture = year;
        //}
        public virtual void Start()
        {
            Console.WriteLine("Car.Start()...");
        }

        public void Stop()
        {
            Console.WriteLine("Car.Stop()...");
        }

    }
}
