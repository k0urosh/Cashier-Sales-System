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
    public partial class SystemSelection : Form
    {
        public SystemSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new SalesReport();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new AccountModification();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductModification pmod = new ProductModification();
            pmod.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductSelection ps = new ProductSelection();
            this.Hide();
            ps.Show();
        }

        private void SystemSelection_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                this.Close();
                Login l = new Login();
                l.Show();
            }
        }
    }
}
