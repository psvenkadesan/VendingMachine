using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    #region "Product Model"
    public class ProductModel
    {
        public int sno;
        public string name;
        public double price;

        public ProductModel(int sNo, string productName, double productPrice)
        {
            sno = sNo;
            name = productName;
            price = productPrice;
        }

        public int SNo
        {
            get
            {
                return sno;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }
    }
    #endregion
}
