using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem
{
    public partial class Payment : Form
    {
        string value;
        string value2;
        decimal valueD;
        decimal valueD2;
        decimal tot = 0;
        public Payment()
        {
            InitializeComponent();
            Database.formList.Add(this);
            this.StartPosition = FormStartPosition.CenterScreen;

            decimal total = 0;

            foreach (SalesItemPar s2 in Database.salesWorkItems)
                foreach (Product p in Database.productList)
                {
                    {
                        if (p.ProductID == s2.ProductID)
                        {
                            dataGridView1.Rows.Add(s2.ProductID, p.Name, s2.quantity, s2.calculateCost(s2.ProductID,s2.quantity));

                            total = total + s2.calculateCost(s2.ProductID,s2.quantity);
                            string ttl = total.ToString();
                            totalV.Text = ttl;
                        }

                    }
                }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            foreach ( Membership m in Database.membershipList)
            {
                comboBox1.Items.Add(m.Id);
            }
            
            
                textBox3.Text = Login.logCheck;                        
                     

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        /*    foreach (Membership m in Database.membershipList)
            {
                comboBox1.Items.Add(m.Id);
            }
            */ 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.Ps.Show();
           // ps.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Set the total value to original sales
            decimal total = 0;
            foreach (SalesItemPar s2 in Database.salesWorkItems)
            {
               
                total = total + s2.calculateCost(s2.ProductID,s2.quantity);
                string ttl = total.ToString();
                totalV.Text = ttl;
            }

            //Modify the total value dynamically while we input sales value
            value = textBox1.Text;
            if ( value == "")
            {
                value = "0";
                valueD = 0;
            }
            else
            {
                valueD = Decimal.Parse(value);
                value2 = totalV.Text;
                valueD2 = Decimal.Parse(value2);

                tot = valueD2 - valueD;
                if (tot < 0)
                {
                    totalV.Text = "0.00";
                    tot = tot * -1;
                    textBox2.Text = tot.ToString();
                }
                else
                {
                    totalV.Text = tot.ToString();
                }
            }




  
        }

        private void totalV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            int count = 1;
            if( totalV.Text == "0.00")
            {
                string id;
                id = comboBox1.SelectedText;
                foreach (Membership m in Database.membershipList)
                    foreach (SalesItemPar s in Database.salesWorkItems)
                    {
                        {
                            if (id == m.Id)
                            {
                                m.points = (int)s.calculateCost(s.ProductID,s.quantity) / 10;
                            }
                        }
                    }

                foreach(Sales s in Database.sales)
                {
                    count += 1;
                }
              //  String test = DateTime.Today.ToString("d");
               // DateTime m1 = DateTime.ParseExact(test, "d",null);

              //  Console.WriteLine(DateTime.Today.ToString("d"));
                foreach (SalesItemPar s in Database.salesWorkItems)
                {
                    Database.salesItemsRef.Add(new SalesItemRef(s.ProductID, s.quantity, count.ToString()));
                }
                Database.sales.Add(new Sales(count.ToString(),textBox3.Text, comboBox2.Text, DateTime.Now, comboBox1.Text));
                this.Hide();
                Receipt r = new Receipt();
                r.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not paid enough");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Card")
            {
                textBox1.Text = "0";
                textBox1.Enabled = false;
                totalV.Text = "0.00";
                textBox2.Text = "0.00";

            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberAdd m = new MemberAdd();          
            m.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
