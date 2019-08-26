using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashierSystem
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
          

            InitializeComponent();
            //Membership
            File.WriteAllText("DatabaseSys/MembershipSys.txt", String.Empty);

            TextWriter tw = new StreamWriter("DatabaseSys/MembershipSys.txt", true);
        
            foreach (Membership m in Database.membershipList)
            {
                tw.Write(m.Id);
                tw.Write(' ');
                tw.Write(m.Name);
                tw.Write(' ');
                tw.Write(m.PhoneNumber);
                tw.Write(' ');
                tw.Write(m.Address);
                tw.Write(' ');
                tw.Write(m.Email);
                tw.Write(' ');
                tw.Write(m.Points);
                tw.WriteLine();
            }

            tw.Close();

            //Sales
            File.WriteAllText("DatabaseSys/SalesSys.txt", String.Empty);
            TextWriter tw2 = new StreamWriter("DatabaseSys/SalesSys.txt", true);

            foreach (Sales s in Database.sales)
            {
                tw2.Write(s.SalesID);
                tw2.Write(',');
                tw2.Write(s.Cashier);
                tw2.Write(',');
                tw2.Write(s.PaymentType);
                tw2.Write(',');
                tw2.Write(s.Date);
                tw2.Write(',');
                tw2.Write(s.MembershipID);
                tw2.Write(',');
                tw2.WriteLine();
            }

            tw2.Close();

            //SalesItem
            File.WriteAllText("DatabaseSys/SalesItemSys.txt", String.Empty);
            TextWriter tw3 = new StreamWriter("DatabaseSys/SalesItemSys.txt", true);

            foreach (SalesItemRef s in Database.salesItemsRef)
            {
                tw3.Write(s.ProductID);
                tw3.Write(' ');
                tw3.Write(s.quantity);
                tw3.Write(' ');
                tw3.Write(s.SalesID);
                tw3.WriteLine();
            }

            tw3.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database.salesWorkItems.Clear();
            this.Hide();
            Form form = new ProductSelection();
            form.Show();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
