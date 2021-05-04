using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Customer
    {
        string name;
        string addr;
        string tel;
        string email;

        public Customer(string name, string addr,string tel, string email)
        {
            this.name = name;
            this.addr = addr;
            this.tel = tel;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Email { get => email; set => email = value; }
    }
}
