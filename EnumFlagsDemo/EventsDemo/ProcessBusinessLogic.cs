using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class ProcessBusinessLogic
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess(int i, int j)
        {
            Console.WriteLine("Process started...");
            //OnProcessCompleted(EventArgs.Empty);
            if (j == 0)
            {
                OnProcessCompleted(false);
            }
            else
            {
                OnProcessCompleted(true);
            }

        }

        //protected void OnProcessCompleted(EventArgs e)
        //{
        //    ProcessCompleted?.Invoke(this, EventArgs.Empty);
        //}

        protected virtual void OnProcessCompleted(bool isSuccessful)
        {
            ProcessCompleted?.Invoke(this, isSuccessful);
        }
    }
}
