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
        static string[] InnNames = new string[] { "Lion's Pride Inn", "Shady Rest Inn"};
        public static void ThreadStore()
        {
            string Inn = InnNames[InnNumber];
            InnNumber++;
            Bazzar TheBazzar = Bazzar.Instance;
            for (int i = 1; i <= 25; i++)
            {
                bool ObjectForSale = false;
                while(!ObjectForSale)
                {
                    ObjectForSale = TheBazzar.PublishItem(i, Inn);
                }
                Thread.Sleep(800);
            }
            TheBazzar.SetFinished();
            
        }

        public static void CreateStore()
        {
            Thread t = new Thread(new ThreadStart(ThreadStore));
            t.Start();
        }
    }
}
