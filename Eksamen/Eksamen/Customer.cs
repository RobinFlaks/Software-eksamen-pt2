using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Eksamen

{
    public class CustomerGenerator
    {
        private System.Object ThreadLock = new System.Object();
        static int CustomerID = 0;
        public void ThreadCustomer()
        {
            string[] Names = new string[] { "Jaina", "Uther", "Malfurian", "Gul'dan", "Valeera", "Anduin", "Rexxar", "Thral", "Garrosh" };
            Random Rnd = new Random();
            string Name = Names[CustomerID];
            CustomerID++;

            while (Bazzar.GetFinished() == false)
            {
                while (Bazzar.GetItemAvailable() == true)
                {
                    lock(ThreadLock);
                    Bazzar.SetItemAvailable(false);
                    Console.WriteLine(Name + " bought Item #" + Bazzar.GetItemNumber());
                }
                Thread.Sleep(0);
            }
        }

        public void CreateCustomer()
        {
            Thread t = new Thread(new ThreadStart(ThreadCustomer));
            t.Start();
        }
    }
}
