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
      double individualCost = 5;

      if (convertedQuantityOrdered < 3)
      {
        double Cost = (individualCost * convertedQuantityOrdered);
          return Cost;
      }
      else
      {
        return Cost;
      }
    }

  }
}