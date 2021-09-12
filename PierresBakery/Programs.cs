using System;
using PierresBakery.Models;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery Home of the world's finest Pastries and Bread! \n");
      Console.WriteLine("Below are our current prices: \n");
      Console.WriteLine("One Loaf of bread: $5");
      Console.WriteLine("One Pastry: $2 \n");
      Console.WriteLine("Our Current Deals are as displayed below: \n");
      Console.WriteLine("Buy two get one free on Bread");
      Console.WriteLine("Buy three Pastries and get $1 off \n");
      
      Console.WriteLine("Would you like to purchase some goods? (please respond yes or no)");
      string userResponse = Console.ReadLine();
      string lowerCaseResponse = userResponse.ToLower();
      if(lowerCaseResponse == "yes")
      {
        CalculateOrder();
      }
      else
      {
        Console.WriteLine("It looks like you do not want to order any goods. Please come back if you change your mind!");
        Main();
      }
    }
    public static void CalculateOrder()
    {
      Console.Clear();
      Console.WriteLine("Please enter how many loafs of bread you would like (enter 0 if you don't want bread):");
      string breadAmount = Console.ReadLine();
      int amount = int.Parse(breadAmount);
      Bread newBreadOrder = new Bread(amount);
      newBreadOrder.DeterminePrice();

      Console.WriteLine("Please enter how many Pasteries you would like (enter 0 if you don't want pasteries):");
      string pastryAmount = Console.ReadLine();
      int numPastryAmount = int.Parse(pastryAmount);
      Pastry newPastryOrder = new Pastry(numPastryAmount);
      newPastryOrder.DeterminePrice();
      Console.Clear();

      int finalCost = newBreadOrder.Price + newPastryOrder.Price;

      Console.WriteLine($"You order contains {breadAmount} loafs of bread and {pastryAmount} of pasteries");
      Console.WriteLine($"The total cost for your pasteries is ${newPastryOrder.Price}");
      Console.WriteLine($"The total cost for your bread is ${newBreadOrder.Price}");
      Console.WriteLine($"The total of all your goodies is ${finalCost} \n");

      Console.WriteLine("If you are finished with your order enter: main");
      string userEndResponse = Console.ReadLine();
      if(userEndResponse == "main")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Sorry the bakery is currently closed please come back tomorrow!");
        Main();
      }
    }
  }
}