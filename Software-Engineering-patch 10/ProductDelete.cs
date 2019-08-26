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
    public partial class ProductDelete : Form
    {
        public ProductDelete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductModification p = new ProductModification();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pid;
            pid = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                foreach (Product p in Database.productList.ToList())
                {
                    if (pid == p.ProductID)
                    {
                        Database.productList.Remove(p);
                        ProductModification p1 = new ProductModification();
                        p1.Show();
                        this.Hide();
                        return;
                    }
                }
                System.Windows.Forms.MessageBox.Show("Product ID entered is incorrect");
            }
            else if ( radioButton1.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Please check the radio button to confirm");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProductDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
