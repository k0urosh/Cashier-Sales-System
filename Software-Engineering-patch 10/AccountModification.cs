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
    public partial class AccountModification : Form
    {
        public AccountModification()
        {
            InitializeComponent();
            foreach (Account a in Database.accountList)
            {
                
                richTextBox1.AppendText(a.Username + "\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new AccountAdd();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Account
            File.WriteAllText("DatabaseSys/AccountSys.txt", String.Empty);
            TextWriter tw2 = new StreamWriter("DatabaseSys/AccountSys.txt", true);

            foreach (Account a in Database.accountList)
            {
                tw2.Write(a.Username);
                tw2.Write(' ');
                tw2.Write(a.Password);
                tw2.Write(' ');
                tw2.Write(a.Privilege);
                tw2.WriteLine();
            }

            tw2.Close();

            this.Hide();
            Form form2 = new SystemSelection();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountDelete ad = new AccountDelete();
            ad.Show();
        }

        private void AccountModification_Load(object sender, EventArgs e)
        {

        }
    }
}
