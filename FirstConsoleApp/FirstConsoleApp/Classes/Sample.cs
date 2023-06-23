using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public class Sample
    {
        // Fields.
        private int _id;
        private string _name;

        public Sample()
        {
            _id = 0;
            _name = "Nothing";
        }

        public Sample(int id, string name)
        {
            _id = id;
            _name = name;
        }

        // Property Definition.
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                if (_id > 0 && _id < 10)
                {
                    _name = "TEN";
                }
                else if (_id >= 10)
                {
                    _name = "TWENTY";
                }
                else
                {
                    _name = value;
                }
            }
        }

        private void foo()
        {
            _name = "abc";
        }
    }
}
