using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public static class MyExtension
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static string AllCaps(this string s)
        {
            return s.ToUpper();
        }
    }
}
