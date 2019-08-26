using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem 
{
    class SalesItemPar
    {
        public int quantity;
        public String ProductID { get; set; }
        public String SalesID { get; set; }


        public SalesItemPar(String p, int q, String sid)
        {
            ProductID = p;
            Quantity = q;
            SalesID = sid;
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    quantity = 0;
                }
            }
        }

        public decimal calculateCost(String pID, int qty)
        {
            foreach (Product p in Database.productList)
            {
                if (p.ProductID == pID)
                {
                    return p.Price * qty;
                }
            }
            return 0.00M;

        }
    }
}
