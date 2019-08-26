using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem
{
    public partial class Login : Form
    {
        public static string logCheck;
        public static Boolean adminLogin = false;

        public Boolean AdminLogin
        {
            get
            {
                return adminLogin;
            }
            set
            {
                AdminLogin = adminLogin;
            }
        }

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Database.formList.Add(this);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Account a in Database.accountList)
            {
                if (a.checkLogin(textBox1.Text, textBox2.Text) == true)
                {
                    
                    if (a.Privilege == "cashier")
                    {
                        logCheck = a.Username;
                        this.Hide();
                        FormProvider.Ps.Show();
                        return;
                    }
                    else if (a.Privilege == "manager")
                    {
                        logCheck = a.Username;
                        this.Hide();
                        Form form2 = new SystemSelection();
                        form2.Show();
                        return;                       
                    }

                }
            }

                System.Windows.Forms.MessageBox.Show("Wrong Username/Password");
            

                    
                
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
