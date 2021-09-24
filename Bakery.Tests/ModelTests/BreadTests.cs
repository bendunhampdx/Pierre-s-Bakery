using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
     Bread newBread = new Bread(quantityOrdered, cost);
     int resultQuantityOrdered = newBread.QuantityOrdered;
     double resultCost = newBread.Cost;

     //Assert
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultCost, newBread.Cost);
    }

    [TestMethod]
    public void SetBreadDiscount_CalculatesCostWithoutDiscounts_Double()
    {
     //Arrange
     int quantityOrdered = 2;
     double cost = 10;

     //Act
     Bread newBread = new Bread(quantityOrdered, cost);
     int resultQuantityOrdered = newBread.QuantityOrdered;
     double resultCost = newBread.Cost;

     //Assert
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultCost, 10);
    }
  }
}