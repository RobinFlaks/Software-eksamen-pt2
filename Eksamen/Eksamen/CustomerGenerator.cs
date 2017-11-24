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
        static int CustomerID = 0;
        public static void ThreadCustomer()
        {
			BasicPack BasePack = new BasicPack();
			Rarities RandomRaritiy = new Rarities(BasePack);

			string[] Names = new string[] { "Jaina", "Uther", "Malfurian", "Gul'dan", "Valeera", "Anduin", "Rexxar", "Thral", "Garrosh" };
            Random Rnd = new Random();
            int i = Rnd.Next(0, 8);
            string Name = Names[CustomerID];
            CustomerID++;
            Bazzar Bazz = Bazzar.Instance;
            while (Bazz.GetFinished() == false)
            {
                while (Bazz.GetItemAvailable() == true)
                {
                    Bazz.SetItemAvailable(false);
                    Console.WriteLine(Name + " bought Pack #" + Bazz.GetItemNumber() + BasePack.GetDescription() + RandomRaritiy.GetDescription());
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
