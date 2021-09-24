using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int QuantityOrdered { get; set;}
    public double Cost { get; set;}

    public Bread(int quantityOrdered, double cost)
    {
      QuantityOrdered = quantityOrdered;
      Cost = cost;
    }

    public double SetBreadDiscount(int quantityOrdered)
    {
      double convertedQuantityOrdered = Convert.ToDouble(quantityOrdered);
      double freeBread= convertedQuantityOrdered/3;
      double individualCost = 5;

      if (convertedQuantityOrdered % 3 == 0)
      {
        double cost = (individualCost * convertedQuantityOrdered) - (individualCost * freeBread);
        return cost;
      }

      else if (convertedQuantityOrdered < 3)
      {
        double cost = (individualCost * convertedQuantityOrdered);
          return cost;
      }
      else
      {
        double cost = (individualCost * convertedQuantityOrdered) - individualCost;
        return cost;
      }
    }

  }
}