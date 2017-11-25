using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eksamen;

namespace BazzarTest
{
	[TestClass]
	public class BasicPackTest
	{
		[TestMethod]
		public void GetDescription_Scenario_ExpectedBehavior()
		{
			//Arrange
			var BasePack = new BasicPack();
			//Act
			var Result = BasePack.GetDescription();
			//Assert
			Assert.AreEqual(Result, " with a Rare card");

		}
	}
}
