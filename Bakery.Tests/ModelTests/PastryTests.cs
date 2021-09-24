using Microsoft.VisualStudio.TestTools.UnitTesting;



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

    [TestMethod]
    public void SetPastryDiscount_PastryDiscountAccountedForAndQuantityIsLessThanThree_Double()
    {
    //Arrange
    int quantityOrdered = 1;
    double cost = 2;

    //Act
      Pastry newPastry = new Pastry(quantityOrdered, cost);
      int resultQuantityOrdered = newPastry.QuantityOrdered;
      double resultCost = newPastry.Cost;

    //Assert
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultCost, 2);
    }

    [TestMethod]
    public void SetPastryDiscount_PastryDiscountAccountedFor_Double()
    {
    //Arrange
    int quantityOrdered = 9;
    double cost = 15;

    //Act
      Pastry newPastry = new Pastry(quantityOrdered, cost);
      int resultQuantityOrdered = newPastry.QuantityOrdered;
      double resultCost = newPastry.Cost;

    //Assert
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultCost, 15);
    }
  }
}
