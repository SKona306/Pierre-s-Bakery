using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; private set;}
    public int Amount { get; private set; }

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
        Price = (((Amount - remainder) / 3) * 10) + (remainder * 5);
        return Price;
      }
      else 
      {
        Price = Amount * 5;
        return Price;
      }
    }
  }
}