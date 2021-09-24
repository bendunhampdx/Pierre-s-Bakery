using System;
using Bakery;
using Bakery.Models;


namespace Bakery
{  
  public class Program
  {
    public Bread bread;
    public Pastry pastry;
    string error = "Invalid response; please try again.";
    public static void Main()
    {
      Program program = new Program();

      program.TakeOrder();
      program.OrderBread();
      program.SecondOrderQuestion();
      program.OrderPastry();
      program.Checkout();
    }

    public void TakeOrder()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Our bread is $5 a loaf and pastries are $2 each. If you order multiple items you may receive a discount!.");
      Console.WriteLine("Would you like to order bread? Type 'bread' for bread and 'no' if not.");

      string bakeryChoice = Console.ReadLine().ToUpper();
      bread = new Bread(0, 0);
      pastry = new Pastry(0, 0);

      try
      {
        if (bakeryChoice == "BREAD")
        {
          OrderBread();
        }
        else if (bakeryChoice == "NO")
        {
          SecondOrderQuestion();
        }
        else
        {
          Console.WriteLine($"That is not a readable response. Perhaps you meant 'bread'");
        }
      }
      catch
      {
        Console.WriteLine($"{error}");
      }
    }


    public void SecondOrderQuestion()
    {
      Console.WriteLine("Would you like to order any pastries? Type 'pastry' to add pastries to your order and 'no' if not");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      try
      {
        if (bakeryChoice == "PASTRY")
        {
          OrderPastry();
        }
        else if (bakeryChoice == "NO")
        {
          Checkout();
        }
        else
        {
          Console.WriteLine($"{error}");
        }
      }
      catch
      {
        Console.WriteLine($"{error}");
      }
    }

    public void OrderBread()
    {
      Console.WriteLine("We're currently running a bread special! Buy 2 loaves- get one FREE");
      Console.WriteLine("How many loaves would you like to purchase?");
      
      string breadOrder = Console.ReadLine();
      int quantityOrdered = 0;

      try
      {
        quantityOrdered += int.Parse(breadOrder);

        bread.Cost = bread.SetBreadDiscount(quantityOrdered);
        Console.WriteLine($"Your total cost for bread is ${bread.Cost}" );

      }
      catch
      {
        Console.WriteLine($"Unable to parse '{breadOrder}'");
      }
    SecondOrderQuestion();
    }

    public void OrderPastry()
    {
      Console.WriteLine("We're currently running a pastry special! Buy 1 pastry for $2 or 3 pastries for $5!");
      Console.WriteLine("How many pastries would you like to purchase?");
      
      string pastryOrder = Console.ReadLine();
      int quantityOrdered = 0;

      try
      {
        quantityOrdered += int.Parse(pastryOrder);

        pastry.Cost = pastry.SetPastryDiscount(quantityOrdered);
        Console.WriteLine($"Your total cost for pastry is ${pastry.Cost}" );

      }
      catch
      {
        Console.WriteLine($"Unable to parse '{pastryOrder}'");
      }
    Checkout();
    }

    public void Checkout()
    {
      Console.WriteLine("Would you like to checkout? Type 'checkout' to checkout and click 'Enter' to restart our program");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      if (bakeryChoice == "CHECKOUT")
          {
            double finalTotal = bread.Cost + pastry.Cost;
            Console.WriteLine($"Your order total comes to ${finalTotal}");
            Console.WriteLine($"Thank you for choosing Pierre's Bakery!");
            TakeOrder();
          }
      else
      {

        TakeOrder();
      }
    }
  }
}