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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].Points.Clear();
            foreach (Sales s in Database.sales)
            {
                foreach (SalesItemRef s1 in Database.salesItemsRef)
                {
                    if (s.SalesID == s1.SalesID)
                    {
                        String day = s.Date.ToString("d");
                        if( day == DateTime.Today.ToString("d"))
                        {
                            label1.Text = "Showing Data for Day:" + day;
                            chart1.Series["Sales"].Points.AddXY(s1.ProductID, s1.calculateCost(s1.ProductID, s1.quantity));
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].Points.Clear();
            foreach (Sales s in Database.sales)
            {
                foreach (SalesItemRef s1 in Database.salesItemsRef)
                {
                    if( s.SalesID == s1.SalesID)
                    {
                        String month = s.Date.ToString("MMM");

                        if (month == DateTime.Today.ToString("MMM"))
                        {
                            label1.Text = "Showing Data for Month:" + month;
                            chart1.Series["Sales"].Points.AddXY(s1.ProductID, s1.calculateCost(s1.ProductID, s1.quantity));
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            SystemSelection s0 = new SystemSelection();
            s0.Show();
        }
    }
}
