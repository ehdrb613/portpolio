using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Seller
    {
        string name;
        string tel;
        string email;
        string agent;
        string position;
        

        public Seller(string name, string tel, string email,  string agent, string position)
        {
            this.name = name;
            this.tel = tel;
            this.email = email;
            this.agent = agent;
            this.position = position;
            
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Position { get => position; set => position = value; }
        public string Agent { get => agent; set => agent = value; }
    }
}
