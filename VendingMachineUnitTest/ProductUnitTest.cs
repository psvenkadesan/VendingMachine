using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineUnitTest
{
    [TestClass]
    public class ProductUnitTest
    {
        #region "Positive Scenario"
        //Test for coin detail 
        [TestMethod]
        public void TestMethod_ProductDetail()
        {
            VendingMachineProcess vendingMachingProcess = new VendingMachineProcess();
            int productSNo = 1;
            ProductModel result = vendingMachingProcess.FindAndReturnProduct(productSNo);
            Assert.AreEqual(result.Name, "Cola");
        }

        //Test for product detail 
        [TestMethod]
        public void TestMethod_CoinDetail()
        {
            VendingMachineProcess vendingMachingProcess = new VendingMachineProcess();
            int coinSNo = 3;
            CoinModel result = vendingMachingProcess.FindAndReturnCoin(coinSNo);
            Assert.AreEqual(result.Coin, "Quarters");
        }
        #endregion

        #region "Negative Scenario"
        //Test for product detail 
        [TestMethod]
        public void TestMethod_ProductDetail_Negative()
        {
            VendingMachineProcess vendingMachingProcess = new VendingMachineProcess();
            int productSNo = 5;
            ProductModel result = vendingMachingProcess.FindAndReturnProduct(productSNo);
            string finalResult = null;
            if(result != null) 
                {
                finalResult = result.Name;
            }
            Assert.AreEqual(finalResult, null);
        }

        //Test for coin detail 
        [TestMethod]
        public void TestMethod_CoinDetail_Negative()
        {
            VendingMachineProcess vendingMachingProcess = new VendingMachineProcess();
            int coinSNo = 5;
            CoinModel result = vendingMachingProcess.FindAndReturnCoin(coinSNo);
            string finalResult = null;
            if (result != null) {
                finalResult = result.Coin;
            }
            Assert.AreEqual(finalResult, null);
        }
        #endregion
    }
}
