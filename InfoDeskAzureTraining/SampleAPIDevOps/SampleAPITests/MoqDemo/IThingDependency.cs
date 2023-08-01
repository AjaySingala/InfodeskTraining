using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPITests.MoqDemo
{
    public interface IThingDependency
    {
        string Join(string str1, string str2);
        int Age { get; }
        bool Charge(int amount, Card card);
    }

    public class ThingDependency : IThingDependency
    {
        public int Age => throw new NotImplementedException();

        public string Join(string str1, string str2)
        {
            //return $"{str1} {str2}";
            throw new NotImplementedException();
        }

        //public bool Charge(string name, int number, int cvv)
        public bool Charge(int amount, Card card)
        {
            throw new NotImplementedException();
        }
    }

    public class Card
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int CVV { get; set; }
    }

    public class ThingToBeTested
    {
        IThingDependency _dep;
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ThingToBeTested(IThingDependency dep)
        {
            _dep = dep;
        }

        public string DoTheThing()
        {
            var name = _dep.Join(Firstname, Lastname);
            return $"{name} is {_dep.Age} years old.";
        }

        public bool ChargeTheCard(int amt, Card crd)
        {
            return _dep.Charge(amt, crd);
        }
 
    }
}
