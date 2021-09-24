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
  }
}