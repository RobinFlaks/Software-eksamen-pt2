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
        static string[] InnNames = new string[] { "Lion's Pride Inn", "Shady Rest Inn" };
        public static void ThreadStore()
        {
            string Inn = InnNames[InnNumber];
            InnNumber++;
            Bazzar TheBazzar = Bazzar.Instance;
            while (TheBazzar.GetFinished() == false)
            {
                for (int i = 1; i <= 25; i++)
                {
                    while (TheBazzar.GetItemAvailable() == true)
                    {
                        Thread.Sleep(0);
                    }

                    TheBazzar.SetItemNumber(i);
                    Console.WriteLine( Inn + " put pack #" + i + " up for sale");
                    TheBazzar.SetItemAvailable(true);
                    Thread.Sleep(800);
                }
                TheBazzar.SetFinished(true);
            }
        }

        public static void CreateStore()
        {
            Thread t = new Thread(new ThreadStart(ThreadStore));
            t.Start();
        }
    }
}
