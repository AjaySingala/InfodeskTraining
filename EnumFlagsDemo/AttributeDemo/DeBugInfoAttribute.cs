using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    //[AttributeUsage(AttributeTargets.Class)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class DeBugInfoAttribute : System.Attribute
    {
        public int BugNo { get; }
        public string Developer { get; }
        public string LastReviewedOn { get; }

        public DeBugInfoAttribute(int bugNo, string developer, string lastReviewedOn) 
        {
            BugNo = bugNo;
            Developer = developer;
            LastReviewedOn = lastReviewedOn;
        }
    }
}
