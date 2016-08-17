using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Customer
    {
        private string name;
        private string username;
        private string password;
        private char type;
        private int loaned;


        public Customer()
        {
        }
        public Customer(string name,string username,string password,char type,int loaned)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.type = type;
            this.loaned = loaned;
        }

        public string Name { get { return name; }set { name = value; } }
        public string Username { get { return username; } set {username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public char Type { get { return type; } set { type = value; } }
        public int Loaned { get { return loaned; } set { loaned = value; } }

    }
}
