using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eksamen;

namespace BazzarTesting
{
    [TestClass]
    public class BasicPackTest
    {
        [TestMethod]
        public void GetDescription_Returns_DefaultString()
        {

			//Test if the default value is equal to " with a Rare card"

			//Arrange
			var BasePack = new BasicPack();
			//Act
			var Result = BasePack.GetDescription();	
			//Assert
			Assert.AreEqual(Result, " with a Rare card");
        }
    }
}
