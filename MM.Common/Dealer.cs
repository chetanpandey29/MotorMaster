using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Common
{
    public class Dealer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string URL { get; private set; }
        public string Logo { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public bool Active { get; private set; }

        protected  Dealer() { }
        public Dealer(string name, string description, string url, string logo, string phone, string email, string address)
        {

        }
    }
}
