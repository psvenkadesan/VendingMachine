using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    #region "Coin Model"
    public class CoinModel
    {
        public int sno;
        public string coin;
        public double weight;

        public CoinModel(int sNo, string Coin, double Weight)
        {
            sno = sNo;
            coin = Coin;
            weight = Weight;
        }

        public int SNo
        {
            get
            {
                return sno;
            }
        }

        public string Coin
        {
            get
            {
                return coin;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
        }
    }
    #endregion
}
