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
    public partial class AccountAdd : Form
    {
        public AccountAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string pass;
            string privi;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (radioButton1.Checked)
            {
                privi = radioButton1.Text;
            }
            else
            {
                privi = radioButton2.Text;
            }

            Database.accountList.Add(new Account(name, pass, privi));

            this.Hide();
            Form form2 = new AccountModification();
            form2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new AccountModification();
            form2.Show();
        }

        private void AccountAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
