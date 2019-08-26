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
    public partial class SelectAmount : Form
    {
        decimal total = 0;
        string tag = null;
        DataGridView dataGridView1;
        TextBox TotalV;
        public SelectAmount(string _tag, DataGridView d, TextBox x)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tag = _tag;
            dataGridView1 = d;
            TotalV = x;
        }
        public SelectAmount( DataGridView d, TextBox x)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridView1 = d;
            TotalV = x;
        }

        private void SelectAmount_Load(object sender, EventArgs e)
        {
        }

        private void b_confirm_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {      
                System.Windows.Forms.MessageBox.Show("Please enter a valid integer amount");

            }
            else
            {
                foreach (SalesItemPar s in Database.salesWorkItems)
                    foreach (Product p in Database.productList)
                    {
                        if (s.ProductID == tag && s.ProductID == p.ProductID)
                        {
                            if (Convert.ToInt32(textBox1.Text) > p.Stock)
                            {
                                System.Windows.Forms.MessageBox.Show("There is not enough product stock for the selected product");

                            }
                        }
                    }



                bool cond = false;
                if (Database.salesWorkItems.Count > 0)
                {
                    foreach (SalesItemPar s in Database.salesWorkItems)
                    {
                        if (s.ProductID == tag)
                        {
                            cond = true;

                            s.quantity = s.quantity + Convert.ToInt32(textBox1.Text);
                        }
                    }
                    if (cond == false)
                    {
                        foreach (Product p in Database.productList)
                        {
                            if (p.ProductID == tag)
                            {
                                if (Convert.ToInt32(textBox1.Text) > p.Stock)
                                {
                                    System.Windows.Forms.MessageBox.Show("There is not enough product stock for the selected product");
                                    break;
                                }
                                else
                                {
                                    Database.salesWorkItems.Add(new SalesItemPar(p.ProductID, Convert.ToInt32(textBox1.Text)));
                                }
                            }
                        }
                    }
                }
                else if (Database.salesWorkItems.Count == 0)
                {
                    foreach (Product p in Database.productList)
                    {
                        if (p.ProductID == tag)
                        {
                            if (Convert.ToInt32(textBox1.Text) > p.Stock)
                            {
                                System.Windows.Forms.MessageBox.Show("There is not enough product stock for the selected product");
                                break;
                            }
                            else
                            {
                                Database.salesWorkItems.Add(new SalesItemPar(p.ProductID, Convert.ToInt32(textBox1.Text)));
                            }

                        }
                    }
                }

                dataGridView1.Rows.Clear();
                foreach (SalesItemPar s2 in Database.salesWorkItems)
                    foreach (Product p in Database.productList)
                    {
                        {
                            if (p.ProductID == s2.ProductID)
                            {
                                dataGridView1.Rows.Add(s2.ProductID, p.Name, s2.quantity, s2.calculateCost(s2.ProductID, s2.quantity));

                                total = total + s2.calculateCost(p.ProductID, s2.quantity);
                                string ttl = total.ToString();
                                TotalV.Text = ttl;
                            }

                        }
                    }

                this.Close();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
