using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachineProcess();
            //Display the products
            vendingMachine.ProductDisplay();
            //choosing the product
            var selectedProduct = vendingMachine.ProductSelectionRequest();
            //get selected product
            ProductModel product = vendingMachine.FindAndReturnProduct(selectedProduct);
            //Display the coins
            vendingMachine.CoinDisplay();
            //choosing the coin
            var selectionNum1 = vendingMachine.CoinSelectionRequest();
            //get selected product
            CoinModel coin = vendingMachine.FindAndReturnCoin(selectionNum1);
            //Calculations & Final Result
            PaymentCalculation paymentCalc = new PaymentCalculation();
            var paymentInfo = paymentCalc.ReturnPaymentAndChange(product.Price, coin.Weight);
            vendingMachine.TakePayment(paymentInfo[0], paymentInfo[1], product.Name, coin.Weight, coin.Coin);
            
        }
    }
}
