using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class EventOrder
    {
        public event EventHandler<string> Done;

        public void Start(string msg)
        {
            Console.WriteLine($"Starting process with {msg}...");
            Broadcast(msg);
        }

        public virtual void Broadcast(string msg)
        {
            Done?.Invoke(this, msg);
        }
    }
}
