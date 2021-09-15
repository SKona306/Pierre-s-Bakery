using System;

namespace PierresBakery.Models
{
  public class Order
  {
    public int Total { get; set; }

    public Order( int total = 0 )
    {
      Total = total;
    }

    public int FinalCost(int breadCost, int pastryCost)
    {
      Total = breadCost + pastryCost;
      return Total;
    }
  }

}