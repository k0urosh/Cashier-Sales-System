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
    public partial class ProductModification : Form
    {
        public ProductModification()
        {
            InitializeComponent();

            foreach (Product p in Database.productList)
            {
                richTextBox1.AppendText(p.ProductID + "\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductAdd padd = new ProductAdd();
            padd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Product
            File.WriteAllText("DatabaseSys/ProductSys.txt", String.Empty);
            TextWriter tw2 = new StreamWriter("DatabaseSys/ProductSys.txt", true);

            foreach (Product p in Database.productList)
            {
                tw2.Write(p.ProductID);
                tw2.Write(' ');
                tw2.Write(p.Name);
                tw2.Write(' ');
                tw2.Write(p.Description);
                tw2.Write(' ');
                tw2.Write(p.Price);
                tw2.Write(' ');
                tw2.Write(p.Stock);
                tw2.WriteLine();
            }

            tw2.Close();

            this.Hide();
            SystemSelection sse = new SystemSelection();
            sse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDelete pd = new ProductDelete();
            pd.Show();
            this.Hide();
        }

        private void ProductModification_Load(object sender, EventArgs e)
        {

        }
    }
}
