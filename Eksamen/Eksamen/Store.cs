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
        public static void ThreadStore()
        {
			while (Bazzar.GetFinished() == false)
            {
                for (int i = 1; i <= 25; i++)
                {
                    while (Bazzar.GetItemAvailable() == true)
                    {
                        Thread.Sleep(0);
                    }
                    Bazzar.SetItemAvailable(true);
                    Bazzar.SetItemNumber(i);
                    Console.WriteLine("Store put pack #" + i + " up for sale");
                    Thread.Sleep(800);
                }
                Bazzar.SetFinished(true);
            }
        }

        public static void CreateStore()
        {
            Thread t = new Thread(new ThreadStart(ThreadStore));
            t.Start();
        }
    }
}
