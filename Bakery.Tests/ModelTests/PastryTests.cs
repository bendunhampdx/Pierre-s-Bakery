using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void SetProperties_PastryConstructorSetsPropertiesAccurately_IntDouble()
    {
     //Arrange
     int quantityOrdered = 5;
     double cost = 9;

     //Act
      Pastry newPastry = new Pastry(quantityOrdered, cost);
     int resultQuantityOrdered = newPastry.QuantityOrdered;
     double resultCost = newPastry.Cost;

     //Assert
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultCost, newPastry.Cost);
    }
  }
}
