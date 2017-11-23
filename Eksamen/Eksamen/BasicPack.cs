using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
	public class BasicPack : IPack
	{
		private readonly string _Description;

		public BasicPack(string Description = " with a Rare card")
		{
			_Description = Description;
		}

		public virtual string GetDescription()
		{
			return _Description;
		}
	}
}
