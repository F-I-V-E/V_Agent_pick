using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Agent_pick
{
    internal class Ability
    {
        public string Name;
        public string Description;
        public int MaxAmount;
        public int Count;
        public int Cost;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Name</param>
        /// <param name="d">Description</param>
        /// <param name="maxA">Maximum Amount</param>
        /// <param name="c">Cost</param>
        /// <param name="b">Base Amount</param>
        public Ability(string n, string d, int maxA, int c, int b) 
        {
            Name = n;
            Description = d;
            MaxAmount = maxA;
            Cost = c;
            Count = b;
        }

        public int buy()
        {
            if (Count != MaxAmount)
            {
                Count++;
                return Cost;
            }
            return -1;
        }
    }
}
