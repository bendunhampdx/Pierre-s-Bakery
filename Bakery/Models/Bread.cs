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
  }
}