using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EventsDemo
{
    internal class Program
    {
        // Delegate.
        public delegate void DelEvent();

        // Event.
        public static event DelEvent Show;

        static void Main(string[] args)
        {
            //SimpleEventDemo();

            //ProcessBusinessLogic obj = new ProcessBusinessLogic();
            //obj.ProcessCompleted += MyProcessCompleted_Handler; // register.
            //obj.StartProcess(10, 2);
            //obj.StartProcess(10, 0);

            EventOrder eo = new EventOrder();
            eo.Done += EventOrder_Handler1;
            eo.Done += EventOrder_Handler2;
            eo.Done += EventOrder_Handler1;
            eo.Done += EventOrder_Handler3;
            eo.Start("abcd");
            eo.Done -= EventOrder_Handler1;
            eo.Start("abcd");
        }

        static void EventOrder_Handler1(object sender, string e) 
        {
            Console.WriteLine($"EventOrder_Handler1: Completed process for {e}");
        }

        static void EventOrder_Handler2(object sender, string e)
        {
            Console.WriteLine($"EventOrder_Handler2: Completed process for {e}");
        }

        static void EventOrder_Handler3(object sender, string e)
        {
            Console.WriteLine($"EventOrder_Handler3: Completed process for {e}");
        }

        //static void MyProcessCompleted_Handler(object sender, EventArgs e)
        //{
        //    Console.WriteLine("MyProcessCompleted_Handler()...");
        //    Console.WriteLine("Process Completed...");
        //}

        static void MyProcessCompleted_Handler(object sender, bool isValid)
        {
            Console.WriteLine("MyProcessCompleted_Handler()...");
            Console.WriteLine("Process " + (isValid ? "Successfully completed" : "failed!"));
        }

        static void SimpleEventDemo()
        {
            Show += new DelEvent(UK);
            Show += new DelEvent(USA);
            Show += new DelEvent(UK);
            if (Show != null)
                Show.Invoke();

            //Console.WriteLine("Round #2...");
            //Show -= new DelEvent(UK);
            //Show -= new DelEvent(UK);
            //if (Show != null)
            //    Show.Invoke();

        }

        // Event Handler #1.
        static void UK()
        {
            Console.WriteLine($"This is UK.");
        }

        // Event Handler #2.
        static void USA()
        {
            Console.WriteLine($"This is USA.");
        }

    }
}