﻿using System;
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
        static string[] CustomerNames = new string[] { "Jaina", "Uther", "Malfurian", "Gul'dan",
												"Valeera", "Anduin", "Rexxar", "Thral", "Garrosh" };

        public static void ThreadCustomer()
        {
			BasicPack BasePack = new BasicPack();
			Rarities RandomRaritiy = new Rarities(BasePack);

            bool NameFound = false;
            string Name = "";
            while (!NameFound)
            {
                Random Rnd = new Random();
                int i = Rnd.Next(0, 9);
                Name = CustomerNames[i];
                if(Name != null)
                {
                    NameFound = true;
                    CustomerNames[i] = null;
                }
            }
            Bazzar TheBazzar = Bazzar.Instance;
            while (TheBazzar.GetFinished() == false)
            {
                while (TheBazzar.GetItemAvailable() == true)
                {
                    TheBazzar.SetItemAvailable(false);
                    Console.WriteLine(String.Format("{0,100}", Name + " bought Pack #" + TheBazzar.GetItemNumber()
													+ BasePack.GetDescription() + RandomRaritiy.GetDescription()));
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
