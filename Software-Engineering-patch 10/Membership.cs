using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierSystem
{
    class Membership
    {
        public string Id { get; set; }
        // do checking
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        // do checking for this also
        public string Email { get; set; }
        public int points;

        public Membership(string id, string nm, string pn, string adr, string em, int p)
        {
            Id = id;
            Name = nm;
            PhoneNumber = pn;
            Address = adr;
            Email = em;
            points = p;
        }

        public int Points
        {
            get { return points; }
            set
            {
                if(value > 0)
                {
                    points = value;
                }
                else
                {
                    points = 0;
                }
            }
        }

        public void increasePoints(int value)
        {
            if(value > 0)
            {
                Points = Points + value;
            }
            else
            {
                MessageBox.Show("Enter value greater than 0");
            }
        }
        
        public void decreasePoints(int value)
        {
            if(value > 0)
            {
                Points = Points - value;
            }
            else
            {
                MessageBox.Show("Enter value greater than 0");
            }
        }
    }
}
