using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price {get; set;}
    public int Amount {get; set;}

    public Bread(int amount, int price = 0)
    {
      Price = price;
      Amount = amount;
    }

    public int DeterminePrice()
    {
      if(Amount > 2) 
      {
        int remainder = Amount % 3;
        Price = (((Amount - remainder) * 10) + (remainder * 5));
        return Price;
      }
      else 
      {
        Price = Amount * 5;
        return Price;
      }
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
    public int Amount { get; set; }

    public Pastry(int amount, int price = 0)
    {
      Price = price;
      Amount = amount;
    }
  }
}