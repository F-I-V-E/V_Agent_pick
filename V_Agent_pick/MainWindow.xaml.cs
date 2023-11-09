using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace V_Agent_pick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] agentsComplete = new string[] { "Cypher", "Deadlock", "Killjoy", "Sage", "Chamber", "Fade", "Kayo", "Skye", "Sova", "Breach", "Gekko", "Iso", "Neon", "Raze", "Jett", "Phoenix", "Reyna", "Yoru", "Harbor", "Astra", "Brimstone", "Omen", "Viper" };
        string[] agents;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbSentinels(object sender, RoutedEventArgs e)
        {
            bool newVal = (Sentinels.IsChecked == true);
            Cypher.IsChecked = newVal;
            Deadlock.IsChecked = newVal;
            Killjoy.IsChecked = newVal;
            Sage.IsChecked = newVal;
            Chamber.IsChecked = newVal;
        }

        private void cbInitiators(object sender, RoutedEventArgs e)
        {
            bool newVal = (Initiators.IsChecked == true);
            Fade.IsChecked = newVal;
            Kayo.IsChecked = newVal;
            Skye.IsChecked = newVal;
            Sova.IsChecked = newVal;
            Breach.IsChecked = newVal;
            Gekko.IsChecked = newVal;
        }

        private void cbDuelists(object sender, RoutedEventArgs e)
        {
            bool newVal = (Duelists.IsChecked == true);
            Iso.IsChecked = newVal;
            Neon.IsChecked = newVal;
            Raze.IsChecked = newVal;
            Jett.IsChecked = newVal;
            Phoenix.IsChecked = newVal;
            Reyna.IsChecked = newVal;
            Yoru.IsChecked = newVal;
        }

        private void cbController(object sender, RoutedEventArgs e)
        {
            bool newVal = (Controller.IsChecked == true);
            Harbor.IsChecked = newVal;
            Astra.IsChecked = newVal;
            Brimstone.IsChecked = newVal;
            Omen.IsChecked = newVal;
            Viper.IsChecked = newVal;
        }

        private void btnSubmit(object sender, RoutedEventArgs e)
        {
            bool[] checkboxes = new bool[23];

            checkboxes[0] = Cypher.IsChecked == true;
            checkboxes[1] = Deadlock.IsChecked == true;
            checkboxes[2] = Killjoy.IsChecked == true;
            checkboxes[3] = Sage.IsChecked == true;
            checkboxes[4] = Chamber.IsChecked == true;
            checkboxes[5] = Fade.IsChecked == true;
            checkboxes[6] = Kayo.IsChecked == true;
            checkboxes[7] = Skye.IsChecked == true;
            checkboxes[8] = Sova.IsChecked == true;
            checkboxes[9] = Breach.IsChecked == true;
            checkboxes[10] = Gekko.IsChecked == true;
            checkboxes[11] = Iso.IsChecked == true;
            checkboxes[12] = Neon.IsChecked == true;
            checkboxes[13] = Raze.IsChecked == true;
            checkboxes[14] = Jett.IsChecked == true;
            checkboxes[15] = Phoenix.IsChecked == true;
            checkboxes[16] = Reyna.IsChecked == true;
            checkboxes[17] = Yoru.IsChecked == true;
            checkboxes[18] = Harbor.IsChecked == true;
            checkboxes[19] = Astra.IsChecked == true;
            checkboxes[20] = Brimstone.IsChecked == true;
            checkboxes[21] = Omen.IsChecked == true;
            checkboxes[22] = Viper.IsChecked == true;

            initializeAgents(checkboxes);
        }

        private void initializeAgents(bool[] c)
        {
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i]) count++;
            }

            agents = new string[count];
            int f = 0; //index for agents array
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i])
                {
                    agents[f] = agentsComplete[i];
                    f++;
                }
            }
        }
        private void btnRandomize(object sender, RoutedEventArgs e)
        {
            btnSubmit(sender, e);
            if (agents.Length > 0)
            {
                Random random = new Random();
                int selection = random.Next(0, agents.Length);
                Uri uri = new Uri(String.Format("pack://siteoforigin:,,,/Agents/{0}.png",agents[selection]));
                imgAgent.Source = new BitmapImage(uri);
            }
        }
    }
}