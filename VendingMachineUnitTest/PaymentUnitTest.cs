using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineUnitTest
{
    [TestClass]
    public class PaymentUnitTest
    {
        //Test for coins count
        [TestMethod]
        public void TestMethod_CalculatePayment()
        {
            PaymentCalculation paymentCalculation = new PaymentCalculation();
            double[] result = paymentCalculation.ReturnPaymentAndChange(1.0, 0.25);
            Assert.AreEqual(result[0], 4);
        }

        
    }
}
