using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
    class Program
    {
        public static void Main()
        {
            Factory MainFactory = new Factory();
            MainFactory.StartProducing();
			Pause();

        }

		public static void Pause()
		{
			Console.ReadKey();
			Console.WriteLine("Press any key to continue...");
		}
    }
}
