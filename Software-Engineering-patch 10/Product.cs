using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem
{
    class Product
    {
        public string ProductID { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }
        private decimal price;
        private int stock;

        public Product(string pId, string name, string desc, decimal _price, int st)
        {
            ProductID = pId;
            Name = name;
            Description = desc;
            Price = _price;
            Stock = st;
        }
        // make sure we do checking if it is a number and >0 if false then ask them to re enter
        public decimal Price
        {
            get{ return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }                   
                else
                {
                    price = 0;
                }
            }
        }
        
        public int Stock
        {
            get { return stock; }
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
                else
                {
                    stock = 0;
                }
            }
        }
        // check for whether it is a number or not
        public void increaseStock(int value)
        {
            if(value > 0)
            {
                Stock = Stock + value;
            }
            else
            {
                MessageBox.Show("Enter values greater than 0");
            }
        }

        public void decreaseStock(int value)
        {
            if(value > 0)
            {
                Stock = Stock - value;
            }
            else
            {
                MessageBox.Show("Enter values greater than 0");
            }
        }
    }
}
