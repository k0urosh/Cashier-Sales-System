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
    public partial class ProductSelection : Form
    {
        public List<GroupBox> groupBoxList = new List<GroupBox>();

        public ProductSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Database.formList.Add(this);

            foreach (Product p in Database.productList)
            {

                cb_search_items.Items.Add(p.ProductID);
            }

            
            
            textBox1.Text = Login.logCheck;
          
            
        }

        protected override void OnLoad(EventArgs e)
        {
            // base.OnLoad(e);
            control();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalV.Text != null)
            {
                this.Hide();
                Payment p = new Payment();
                p.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No product selected for sales");
            }
        }

        public void control()
        {
            int i = 0;
            flp_display_product.Controls.Clear();
            foreach (Product p in Database.productList)
            {

                string temp = p.ProductID + "  " + p.Name + "  " + p.Price.ToString();
                if (temp == cb_search_items.Text || cb_search_items.Text == "")
                {
                    // product image
                    PictureBox pb = new PictureBox();
                    pb.Height = 200;
                    pb.Width = 200;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BackColor = Color.Black;
                    string imgLoc = "resources/images/product_images/" + p.ProductID + ".jpg";
                    pb.Tag = p.ProductID;
                    pb.ImageLocation = imgLoc;
                    pb.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));

                    // product label
                    Label l = new Label();
                    l.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                    l.Tag = p.ProductID;
                    l.Width = 200;
                    l.Text = "ID: " + p.ProductID + "   Brand: " + p.Name + "   RM " + p.Price.ToString();

                    // place product image and label together
                    SplitContainer s = new SplitContainer();
                    s.Tag = p.ProductID;
                    s.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                    s.Size = new System.Drawing.Size(200, 220);
                    s.BorderStyle = BorderStyle.FixedSingle;
                    s.Panel1MinSize = 200;
                    s.Panel2MinSize = 20;
                    s.SplitterWidth = 1;
                    s.IsSplitterFixed = true;
                    s.Orientation = Orientation.Horizontal;
                    SplitterPanel topPanel = s.Panel1;
                    SplitterPanel bottomPanel = s.Panel2;
                    topPanel.Controls.Add(pb);
                    bottomPanel.Controls.Add(l);

                    // place splitcontainer into flowLayoutPanel
                    flp_display_product.Controls.Add(s);
                    i++;
                }

            }
        }

        private void clickedTiles(string tag)
        {
            SelectAmount selectAmount = new SelectAmount(tag, dataGridView1, totalV);
            selectAmount.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flp_display_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductSelection_Load(object sender, EventArgs e)
        {
            cb_loadItems();

            
            
        }

        private void cb_search_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Product p in Database.productList) {

                string temp = p.ProductID + "  " + p.Name + "  " + p.Price.ToString();
                if (cb_search_items.Text == p.ProductID )
                {
                    flp_display_product.Controls.Clear();
                    // product image
                    PictureBox pb = new PictureBox();
                    pb.Height = 200;
                    pb.Width = 200;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BackColor = Color.Black;
                    string imgLoc = "resources/images/product_images/" + p.ProductID + ".jpg";
                    pb.Tag = p.ProductID;
                    pb.ImageLocation = imgLoc;
                    pb.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));

                    // product label
                    Label l = new Label();
                    l.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                    l.Tag = p.ProductID;
                    l.Width = 200;
                    l.Text = "ID: " + p.ProductID + "   Brand: " + p.Name + "   RM " + p.Price.ToString();

                    // place product image and label together
                    SplitContainer s = new SplitContainer();
                    s.Tag = p.ProductID;
                    s.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                    s.Size = new System.Drawing.Size(200, 220);
                    s.BorderStyle = BorderStyle.FixedSingle;
                    s.Panel1MinSize = 200;
                    s.Panel2MinSize = 20;
                    s.SplitterWidth = 1;
                    s.IsSplitterFixed = true;
                    s.Orientation = Orientation.Horizontal;
                    SplitterPanel topPanel = s.Panel1;
                    SplitterPanel bottomPanel = s.Panel2;
                    topPanel.Controls.Add(pb);
                    bottomPanel.Controls.Add(l);

                    // place splitcontainer into flowLayoutPanel
                    flp_display_product.Controls.Add(s);
                    
                }
                else if(cb_search_items.Text == "0")
                {
                    int i = 0;
                    flp_display_product.Controls.Clear();
                    foreach (Product p1 in Database.productList)
                    {
                        string temp1 = p1.ProductID + "  " + p1.Name + "  " + p1.Price.ToString();
                        if (temp1 == cb_search_items.Text || cb_search_items.Text == "")
                        {
                            // product image
                            PictureBox pb = new PictureBox();
                            pb.Height = 200;
                            pb.Width = 200;
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.BackColor = Color.Black;
                            string imgLoc = "resources/images/product_images/" + p1.ProductID + ".jpg";
                            pb.Tag = p1.ProductID;
                            pb.ImageLocation = imgLoc;
                            pb.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));

                            // product label
                            Label l = new Label();
                            l.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                            l.Tag = p1.ProductID;
                            l.Width = 200;
                            l.Text = "ID: " + p.ProductID + "   Brand: " + p.Name + "   RM " + p.Price.ToString();

                            // place product image and label together
                            SplitContainer s = new SplitContainer();
                            s.Tag = p1.ProductID;
                            s.Click += new System.EventHandler((o, a) => clickedTiles(pb.Tag.ToString()));
                            s.Size = new System.Drawing.Size(200, 220);
                            s.BorderStyle = BorderStyle.FixedSingle;
                            s.Panel1MinSize = 200;
                            s.Panel2MinSize = 20;
                            s.SplitterWidth = 1;
                            s.IsSplitterFixed = true;
                            s.Orientation = Orientation.Horizontal;
                            SplitterPanel topPanel = s.Panel1;
                            SplitterPanel bottomPanel = s.Panel2;
                            topPanel.Controls.Add(pb);
                            bottomPanel.Controls.Add(l);

                            // place splitcontainer into flowLayoutPanel
                            flp_display_product.Controls.Add(s);
                            i++;
                        }

                    }
                }
            }
        }

        private void cb_loadItems()
        {
            foreach (Product p in Database.productList)
            {
                string s = p.ProductID + "  " + p.Name + "  " + p.Price;
                cb_search_items.Items.Add(s);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // call form to change amount
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        { 

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
