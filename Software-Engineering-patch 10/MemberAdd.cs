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
    public partial class MemberAdd : Form
    {
        int count = 1;
        public MemberAdd()
        {
            InitializeComponent();
        }

        private void MemberAdd_Load(object sender, EventArgs e)
        {
            
            foreach (Membership m in Database.membershipList)
            {
                count += 1;
            }
            textBox1.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pt;
            pt = Convert.ToInt32(textBox6.Text);
            Database.membershipList.Add(new Membership(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, pt));
            Payment p = new Payment();
            p.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
