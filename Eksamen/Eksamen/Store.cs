using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Eksamen
{
    public static class Store
    {
        static int InnNumber = 0;
        static string[] Names = new string[] { "Lion's Pride Inn", "Shady Rest Inn" };
        public static void ThreadStore()
        {
            string Inn = Names[InnNumber];
            InnNumber++;
            Bazzar Bazz = Bazzar.Instance;
            while (Bazz.GetFinished() == false)
            {
                for (int i = 1; i <= 25; i++)
                {
                    while (Bazz.GetItemAvailable() == true)
                    {
                        Thread.Sleep(0);
                    }
 
                    Bazz.SetItemNumber(i);
                    Console.WriteLine( Inn + " put pack #" + i + " up for sale");
                    Bazz.SetItemAvailable(true);
                    Thread.Sleep(800);
                }
                Bazz.SetFinished(true);
            }
        }

        public static void CreateStore()
        {
            Thread t = new Thread(new ThreadStart(ThreadStore));
            t.Start();
        }
    }
}
