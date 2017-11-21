using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Eksamen
{
	//Singleton, skal jobbes med...
	public sealed class ProductLogger : ILogger
	{
		private static readonly Object padlock = new Object();

		public ProductLogger()
		{
		}

		public void ThreadCustomer()
		{
		}

		public void ItemBought()
		{
		}

		public void GenerateCustomer()
		{
		}

		public void CreateCustomer()
		{
			Thread t = new Thread(new ThreadStart(ThreadCustomer));
			t.Start();
		}
	}
}
