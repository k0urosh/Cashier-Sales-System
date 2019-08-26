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
    public partial class AccountDelete : Form
    {
        public AccountDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aid;
            aid = textBox1.Text;
            
            if (radioButton1.Checked == true)
            {
                foreach (Account a in Database.accountList.ToList())
                {
                    if (aid == a.Username)
                    {
                        Database.accountList.Remove(a);
                        AccountModification a1  = new AccountModification();
                        a1.Show();
                        this.Hide();
                        return;
                    }                                      
                                          
                }
                System.Windows.Forms.MessageBox.Show("Username Does not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountModification ad = new AccountModification();
            ad.Show();
        }
    }
    
}
