using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Agent_pick
{
    internal class Weapon
    {
        public int price;
        public string name;
        public Weapon(int p, string n) 
        { 
            price = p;
            name = n;
        }
        public int buy(int money)
        {
            return money - price;
        }
    }
}
