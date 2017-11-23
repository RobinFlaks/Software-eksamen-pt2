using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
	public class Rarities : RarityDecorator
	{
		public Rarities(IPack BasicPack)
			: base(BasicPack){
		}

		public override string GetDescription()
		{
			// By adding more empty strings to the Rarity list we decrease the frequency of 3 Rarities being printed + the base 
			// to the screen, while at the same time adding the possiblitiy of only printing out the base GetDescription() string
			Random Rand = new Random();
			string[] Rarity = { " and a Legendary card", " and an Epic card", " and a Rare card",
				"", "", "", "", "", };
			string RandIndex = Rarity[Rand.Next(0, 3)];
			string[] RandomlySelected = new string[3];
			StringBuilder TotalStrings = new StringBuilder();
				for (int i = 0; i < RandomlySelected.Length; i++)
				{
					RandomlySelected[i] = Rarity[Rand.Next(Rarity.Length)];
					TotalStrings.Append(RandomlySelected[i]);
				}
			return "" + TotalStrings;
		}
	}
}
