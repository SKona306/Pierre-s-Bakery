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