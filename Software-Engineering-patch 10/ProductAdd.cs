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
    public partial class ProductAdd : Form
    {
        int count = 0;
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            string pname;
            string pdesc;
            decimal pprice;
            int pstock;

            id = textBox1.Text;
            pname = textBox2.Text;
            pdesc = textBox3.Text;
            pprice = Decimal.Parse(textBox4.Text);
            pstock = int.Parse(textBox5.Text);

            Database.productList.Add(new Product(id, pname, pdesc, pprice, pstock));



            this.Hide();
            Form form20 = new ProductModification();
            form20.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductModification p = new ProductModification();
            p.Show();
            this.Hide();
        }

        private void ProductAdd_Load_1(object sender, EventArgs e)
        {
            foreach (Product p in Database.productList)
            {
                count += 1;
            }
            textBox1.Text = count.ToString();
        }
    }
}
