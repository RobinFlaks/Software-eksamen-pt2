using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
	//Decorator, skal jobbes med...
	public abstract class RarityDecorator : IPack
	{
		private readonly IPack BasicPack;

		protected RarityDecorator(IPack _BasicPack)
		{
			BasicPack = _BasicPack;
		}

		public virtual string GetDescription()
		{
			return BasicPack.GetDescription();
		}
	}
}
