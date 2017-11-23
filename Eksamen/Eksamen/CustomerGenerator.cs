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
		//Skal skrive om alt så dette blir main, der alt skjer, muligens lage alt fra facade som kjøres på mainen.
        private static readonly Object ThreadLock = new Object();
        static int CustomerID = 0;
        public static void ThreadCustomer()
        {
			BasicPack BasePack = new BasicPack();
			Rarities RandomRaritiy = new Rarities(BasePack);

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
                    Console.WriteLine(Name + " bought Pack #" + Bazzar.GetItemNumber() + BasePack.GetDescription() + RandomRaritiy.GetDescription());
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
