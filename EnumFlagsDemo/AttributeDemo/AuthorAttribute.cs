using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        public string Author { get; }
        public string Version { get; }

        public AuthorAttribute(string author, string version)
        {
            Author = author;
            Version = version;
        }
    }
}
