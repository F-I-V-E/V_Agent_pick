using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace V_Agent_pick
{
    internal class Agent
    {
        public string Name;
        public string Type;
        public string Description;
        public Ability q;
        public Ability e;
        public Ability c;
        public BitmapImage agentImage;
        public BitmapImage typeImage;
        public CheckBox cb;

        public Agent(string n, string t, string d, Ability q, Ability e, Ability c)
        {
            Name = n;
            Type = t;
            Description = d;
            this.q = q;
            this.e = e;
            this.c = c;
            agentImage = new BitmapImage(new Uri($"pack://application:,,,/images/Agents/{n}.png"));
            typeImage = new BitmapImage(new Uri($"pack://application:,,,/images/Types/{t}.png"));
        }
        public void ConfigureCheckbox(CheckBox cb)
        {
            this.cb = cb;
        }
    }
}
