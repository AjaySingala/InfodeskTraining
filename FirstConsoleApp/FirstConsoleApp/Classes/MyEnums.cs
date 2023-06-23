using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public enum Status
    {
        [EnumMember(Value = "New Document")]
        New,
        [Description("In Progress")]
        InProgress = 20,
        OnHold = 21,
        Approved = 30,
        Rejected = 40
    }

    public class MyEnums
    {
    }
}
