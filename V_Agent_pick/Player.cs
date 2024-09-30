using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace V_Agent_pick
{
    internal class Player
    {
        public Agent Agent;
        public Weapon Weapon;
        public string Name;
        public int Money;
        
        public Player(string name)
        {
            this.Name = name;
            this.Money = 800;
        }

        public void getAgent(AgentList agents)
        {
            Random random = new();
            int temp = random.Next(0,agents.getLength());

            for (int i = 0; i < temp; i++)
            {
                if (!(bool)agents[i].cb.IsChecked)
                {
                    temp++;
                }
                if (i > agents.getLength())
                {
                    temp = 0;
                    i = 0;
                }
                if (i == temp)
                {
                    this.Agent = agents[i];
                }
            }
        }

        public void getWeapon()
        {

        }
    }
}
