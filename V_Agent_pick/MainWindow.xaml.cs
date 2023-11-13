using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace V_Agent_pick
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string[] agentsComplete = new string[] { "Cypher", "Deadlock", "Killjoy", "Sage", "Chamber", "Fade", "Kayo", "Skye", "Sova", "Breach", "Gekko", "Iso", "Neon", "Raze", "Jett", "Phoenix", "Reyna", "Yoru", "Harbor", "Astra", "Brimstone", "Omen", "Viper" };

		CheckBox[] sentinels;
		CheckBox[] initiators;
		CheckBox[] duelists;
		CheckBox[] controllers;

		string[] agents;

		public MainWindow()
		{
			InitializeComponent();

            sentinels = new CheckBox[] { Cypher, Deadlock, Killjoy, Sage, Chamber };
            initiators = new CheckBox[] { Fade, Kayo, Skye, Sova, Breach, Gekko };
            duelists = new CheckBox[] { Iso, Neon, Raze, Jett, Phoenix, Reyna, Yoru };
            controllers = new CheckBox[] { Harbor, Astra, Brimstone, Omen, Viper };
        }

		private void UpdateCb(CheckBox[] cba, bool val)
		{
			if (this.IsLoaded)
			{
				foreach (CheckBox cb in cba)
				{
					cb.IsChecked = val;
				}
			}
		}

		private bool UpdateGrupCb(CheckBox[] cba)
		{
			bool check = false;
			foreach (CheckBox cb in cba)
			{
				if ((bool)cb.IsChecked)
					check = true;
				else
					return false;
			}
			return check;
		}

		//Sentinels--------------------------------------------------------------------------
		private void cbSentinels(object sender, RoutedEventArgs e)
		{
			bool newVal = (Sentinels.IsChecked == true);
			UpdateCb(sentinels, newVal);
		}

		private void cbAgentsSentinels_Click(object sender, RoutedEventArgs e)			//Sentinells alle Checked
        {
            CheckBox checkBox = (CheckBox)sender;
			Sentinels.IsChecked = UpdateGrupCb(sentinels);
		}
        //-----------------------------------------------------------------------------------
        //Initiators-------------------------------------------------------------------------
        private void cbInitiators(object sender, RoutedEventArgs e)
		{	
			bool newVal = (Initiators.IsChecked == true);
			UpdateCb(initiators, newVal);
		}

        private void cbAgentsInitiators_Click(object sender, RoutedEventArgs e)			//Initiators alle Checked
        {
            CheckBox checkBox = (CheckBox)sender;
            Initiators.IsChecked = UpdateGrupCb(initiators);
        }
        //-----------------------------------------------------------------------------------
        //Suelists---------------------------------------------------------------------------
        private void cbDuelists(object sender, RoutedEventArgs e)
		{	
			bool newVal = (Duelists.IsChecked == true);
			UpdateCb(duelists, newVal);
		}

        private void cbAgentsDuelists_Click(object sender, RoutedEventArgs e)			//Duelists alle Checked
        {
            CheckBox checkBox = (CheckBox)sender;
            Duelists.IsChecked = UpdateGrupCb(duelists);
        }
        //-----------------------------------------------------------------------------------
        //Controler--------------------------------------------------------------------------
        private void cbController(object sender, RoutedEventArgs e)
		{
			bool newVal = (Controller.IsChecked == true);
			UpdateCb(controllers, newVal);
		}

        private void cbAgentsController_Click(object sender, RoutedEventArgs e)			//Controller alle Checked
        {
            CheckBox checkBox = (CheckBox)sender;
            Controller.IsChecked = UpdateGrupCb(controllers);
        }
        //-----------------------------------------------------------------------------------
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
			int f = 0;
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
				Uri uri = new Uri(String.Format("pack://application:,,,/images/Agents/{0}.png", agents[selection]));
				imgAgent.Source = new BitmapImage(uri);
			}
		}
	}
}