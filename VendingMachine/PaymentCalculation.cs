using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class PaymentCalculation
    {
        #region "Calculate the payments"
        public double[] ReturnPaymentAndChange(double productPrice, double acceptedCoin)
        {
            double cost = productPrice;
            double coinsRequired = Math.Ceiling(cost / acceptedCoin);
            double change = (coinsRequired * acceptedCoin) - cost;
            double[] paymentInfo = { coinsRequired, change };

            Console.Out.WriteLine("Please enter {0} x {1:c} coins", coinsRequired, acceptedCoin);
            Console.Out.WriteLine("Your change will be {0:c}", change);

            return paymentInfo;
        }
        #endregion
    }
}
