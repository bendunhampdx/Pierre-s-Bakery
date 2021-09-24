using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void SetProperties_BreadConstructorSetsPropertiesAccurately_IntDouble()
    {
     //Arrange
     int quantityOrdered = 5;
     double cost = 20;

     //Act
     Bread newBread = new Bread(quantityOrdered, totalCost);
     int resultQuantityOrdered = newBread.QuantityOrdered;
     double resultCost = newBread.Cost;

     //Assert
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newBread.TotalCost);
    }
  }
}