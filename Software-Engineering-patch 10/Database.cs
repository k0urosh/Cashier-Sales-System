using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashierSystem
{
    static class Database
    {
        public static List<Product> productList = new List<Product>();
        public static List<Membership> membershipList = new List<Membership>();
        public static List<Account> accountList = new List<Account>();
        public static List<SalesItemPar> salesItemsRef = new List<SalesItemPar>();
        public static List<Sales> sales = new List<Sales>();
        public static List<Form> formList = new List<Form>();
        public static List<SalesItemPar> salesWorkItems = new List<SalesItemPar>();

        public static void initializeProductList()
        {
            //PRODUCT
            string fileName2 = "DatabaseSys/ProductSys.txt";
            using (FileStream f = new FileStream(fileName2, FileMode.OpenOrCreate))
            {
                using (TextReader r = new StreamReader(f))
                {
                    string flag;
                    while ((flag = r.ReadLine()) != null)
                    {
                        string[] s = flag.Split(' ');
                        Product p = new Product(s[0], s[1], s[2], Decimal.Parse(s[3]), Convert.ToInt32(s[4]));

                       productList.Add(p);
                       
                    }
                }
            }
            //MEMBERSHIP
            string fileName3 = "DatabaseSys/MembershipSys.txt";
            using (FileStream f = new FileStream(fileName3, FileMode.OpenOrCreate))
            {
                using (TextReader r = new StreamReader(f))
                {
                    string flag;
                    while ((flag = r.ReadLine()) != null)
                    {
                        string[] s = flag.Split(' ');
                        Membership m = new Membership(s[0], s[1], s[2], s[3], s[4], Convert.ToInt32(s[5]));

                        membershipList.Add(m);

                    }
                }
            }
           //ACCOUNT
            string fileName = "DatabaseSys/AccountSys.txt";
            using (FileStream f = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (TextReader r = new StreamReader(f))
                {
                    string flag;
                    while ((flag = r.ReadLine()) != null)
                    {
                        string[] s = flag.Split(' ');
                        Account a = new Account(s[0], s[1], s[2]);

                        accountList.Add(a);

                    }
                }               
            }
            //Sales 
            string fileName4 = "DatabaseSys/SalesSys.txt";
            using (FileStream f = new FileStream(fileName4, FileMode.OpenOrCreate))
            {
                using (TextReader r = new StreamReader(f))
                {
                    string flag;
                    while ((flag = r.ReadLine()) != null)
                    {
                        string[] s = flag.Split(',');

                        DateTime saledate = DateTime.Parse(s[3]);


                        Sales sles = new Sales(s[0], s[1], s[2] ,saledate, s[4]);

                        sales.Add(sles);
                    }
                }
            }

            //SalesItem 
            string fileName5 = "DatabaseSys/SalesItemSys.txt";
            using (FileStream f = new FileStream(fileName5, FileMode.OpenOrCreate))
            {
                using (TextReader r = new StreamReader(f))
                {
                    int t = 0;
                    string flag;
                    while ((flag = r.ReadLine()) != null)
                    {
                        string[] s = flag.Split(' ');

                        foreach(Product p in Database.productList)
                        {
                            foreach (Sales s0 in Database.sales)
                            {
                                if (p.ProductID == s[0])
                                {
                                    if (s0.SalesID == s[2])
                                    {
                                        t = Convert.ToInt32(s[1]);
                                        SalesItemPar sles = new SalesItemPar(p.ProductID, t, s0.SalesID);

                                        salesItemsRef.Add(sles);
                                    }

                                }
                            }



                        }

                    }
                }
            }


        }
         
        
            
        


        
        
    }
}
