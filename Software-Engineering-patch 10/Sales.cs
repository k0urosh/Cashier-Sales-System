using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    class Sales
    {
        public string SalesID { get; set; }        
        public string Cashier { get; set; }
        public string PaymentType { get; set; }
        public DateTime Date { get; set; }
        public string MembershipID { get; set; }


        public List<SalesItemPar> SalesItemList = new List<SalesItemPar>();

        public Sales(string sid, string csh, string ptype, DateTime dte, string memid)
        {
            SalesID = sid;
            Cashier = csh;
            PaymentType = ptype;
            Date = dte;
            MembershipID = memid;
        }

        public decimal calculateTotal()
        {
            decimal value = 0;
            foreach(SalesItemPar s in SalesItemList)
            {
                value += s.calculateCost(s.ProductID,s.quantity);
            }
            return value;
        }
    }
}
