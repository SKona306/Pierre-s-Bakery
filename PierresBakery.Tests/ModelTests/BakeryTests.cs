using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstuctor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BreadClass_SetQuantityWanted_Int()
    {
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(3, newBread.Amount);
    }

    [TestMethod]
    public void PastryClass_SetQuantityWanted_Int()
    {
      int pastryAmount = 3;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(3, newPastry.Amount);
    }

    [TestMethod]
    public void BreadDeterminePrice_SetsPriceBasedOnQuantity_Int()
    {
      int breadAmount = 2;
      Bread newBread = new Bread(breadAmount);
      newBread.DeterminePrice();
      Assert.AreEqual(10, newBread.Price);
    }

    [TestMethod] 
    public void BreadDeterminePrice_SetPriceBasedOnQuantityUsingDeals_Int()
    {
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      newBread.DeterminePrice();
      Assert.AreEqual(10, newBread.Price);
    }

    [TestMethod]
    public void BreadDeterminePrice_ExtremeCaseTest_Int()
    {
      int breadAmount = 100;
      Bread newBread = new Bread(breadAmount);
      newBread.DeterminePrice();
      Assert.AreEqual(335, newBread.Price);
    }

    [TestMethod]
    public void PastryDeterminePrice_SetPriceBasedOnAmount_Int()
    {
      int pastryAmount = 2;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.DeterminePrice();
      Assert.AreEqual(4, newPastry.Price);
    }

    [TestMethod]
    public void PastryDeterminePrice_SetPriceBasedOnAmountUsingDeal_Int()
    {
      int pastryAmount = 4;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.DeterminePrice();
      Assert.AreEqual(7, newPastry.Price);
    }

    [TestMethod]
    public void PastryDeterminePrice_ExtremeCaseTest_Int()
    {
      int pastryAmount = 100;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.DeterminePrice();
      Assert.AreEqual(167, newPastry.Price);
    }
  }
}