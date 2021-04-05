using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine;

namespace VendingMachine
{
    public class VendingMachineProcess
    {
        #region "Products" 
        public void ProductDisplay()
        {
            Console.Out.WriteLine("Available Products:");
            Console.Out.WriteLine();
            var items = ProductList();
            foreach (var item in items)
            {
                Console.Out.WriteLine("{0} - Price {1:c}p", item.Name, item.Price);
            }

            Console.Out.WriteLine();
        }

        public int ProductSelectionRequest()
        {
            List<int> selected = new List<int>();

            Console.Out.WriteLine("Please select your product...");
            var items = ProductList();
            foreach (var item in items)
            {
                int productNo = item.SNo;
                selected.Add(productNo);
                Console.Out.WriteLine("Please enter {0} for {1}.", productNo, item.Name);
            }
            int selection = ReadInput();
                while (!selected.Contains(selection))
                {
                    Console.Out.WriteLine("{0} Not avilable, please select again.", selection);
                }
           
            return selection;
        }

        public ProductModel FindAndReturnProduct(int selection)
        {
            string stringselection = Convert.ToString(selection);
            //get the product List
            var items = ProductList();
            var product = items.Find(item => item.SNo.ToString().Contains(stringselection));
            return product;
        }

        //List of products
        public List<ProductModel> ProductList()
        {
            List<ProductModel> productList = new List<ProductModel>();
            productList.Add(new ProductModel(1, "Cola", Convert.ToDouble("1.0")));
            productList.Add(new ProductModel(2, "Chips", Convert.ToDouble("0.50")));
            productList.Add(new ProductModel(3, "Candy", Convert.ToDouble("0.65")));
            return productList;
        }

        #endregion

        #region "Coins" 
        public void CoinDisplay()
        {
            Console.Out.WriteLine("Accepted Coins:");
            Console.Out.WriteLine();
            var items = CoinsList();
            foreach (var item in items)
            {
                Console.Out.WriteLine("{0} - Weight {1:c}$", item.Coin, item.Weight);
            }

            Console.Out.WriteLine();
        }

        public int CoinSelectionRequest()
        {
            List<int> selected = new List<int>();
            Console.Out.WriteLine("Please select your coin...");
            var items = CoinsList();
            foreach (var item in items)
            {
                int coinNo = item.SNo;
                selected.Add(coinNo);
                Console.Out.WriteLine("Please enter {0} for {1}.", coinNo, item.Coin);
            }
            int selection = ReadInput();
            while (!selected.Contains(selection))
            {
                    Console.Out.WriteLine("{0} Not avilable, please select again.", selection);
            }
            return selection;
        }

        public CoinModel FindAndReturnCoin(int selection)
        {
            string stringselection = Convert.ToString(selection);
            var items = CoinsList();
            var coin = items.Find(item => item.SNo.ToString().Contains(stringselection));
            return coin;
        }

        //List of coins
        public List<CoinModel> CoinsList()
        {
            List<CoinModel> coinList = new List<CoinModel>();
            coinList.Add(new CoinModel(1, "Nickels", Convert.ToDouble("0.05")));
            coinList.Add(new CoinModel(2, "Dimes", Convert.ToDouble("0.10")));
            coinList.Add(new CoinModel(3, "Quarters", Convert.ToDouble("0.25")));
            return coinList;
        }
        #endregion

        #region "Common"
        public int ReadInput() {
            string readInput = Console.ReadLine(); // Read string from console
            int input = 0;
            int.TryParse(readInput, out input);
            return input;
        }

        public void TakePayment(double coinsRequired, double change, string productName, double acceptedCoin, string acceptedCoinName)
        {
            int total = 0;
            double paymentReceived = 0;
            double receivedCoin = 0;

            Console.WriteLine("Please enter a payment of {0} as {1}", acceptedCoinName, acceptedCoin);

            while (total < coinsRequired)
            {
                try
                {
                    receivedCoin = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                    if (receivedCoin == acceptedCoin)
                    {
                        total += 1;
                        paymentReceived += receivedCoin;
                        Console.Out.WriteLine("Received {0}, Outstanding {1}", total, coinsRequired - total);
                    }
                    else
                    {
                        Console.Out.WriteLine("Sorry only {0} coins are accepted", acceptedCoin);
                    }
                }

                catch (FormatException)
                {
                    Console.Out.WriteLine("Sorry only {0} coins are accepted", acceptedCoin);
                }
            }

            ThankCustomer(paymentReceived, productName, change);
        }

        public void ThankCustomer(double paymentReceived, string name, double change)
        {
            Console.WriteLine("Thank you for your payment of {0:c}", paymentReceived);
            Console.WriteLine("Your product {0} has been dispensed", name);
            Console.WriteLine("Your change of {0:c} has been dispensed also", change);
            Console.ReadLine();
        }
        #endregion
    }
}
