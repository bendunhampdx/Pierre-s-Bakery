using System;

namespace Bakery
{
  public class Pastry
  {
    public int QuantityOrdered { get; set;}
    public double Cost { get; set;}

    public Pastry(int quantityOrdered, double cost)
    {
      QuantityOrdered = quantityOrdered;
      Cost = cost;
    }

    public double SetPastryDiscount(int quantityOrdered)
    {
      double convertedQuantityOrdered = Convert.ToDouble(quantityOrdered);
      // double freePastry = Math.Floor(convertedQuantityOrdered/3);
      double individualCost = 2;

      if (convertedQuantityOrdered < 3)
      {
        double cost = (individualCost * convertedQuantityOrdered);
        return cost;
      }
      else 
      {
        return Cost;
      }
    }
  }
}