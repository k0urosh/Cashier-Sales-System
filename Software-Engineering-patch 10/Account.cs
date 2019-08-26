using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Privilege { get; set; }

        public Account(string uName, string pWord, string prvige)
        {
            Username = uName;
            Password = pWord;
            Privilege = prvige;
        }

        public Boolean checkLogin(string uName, string pWord)
        {
            if(uName.Equals(Username) && pWord.Equals(Password))
            {
                return true;
            }
            return false;
        }
        public string holdUser(string un)
        {
            string n;
            n = un;
            return un;
        }
    }
}
