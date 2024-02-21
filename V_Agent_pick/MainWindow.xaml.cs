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

        int agents;
        bool[] checkboxes = new bool[23];

        public MainWindow()
        {
            InitializeComponent();

            sentinels = new CheckBox[] { Cypher, Deadlock, Killjoy, Sage, Chamber };
            initiators = new CheckBox[] { Fade, Kayo, Skye, Sova, Breach, Gekko };
            duelists = new CheckBox[] { Iso, Neon, Raze, Jett, Phoenix, Reyna, Yoru };
            controllers = new CheckBox[] { Harbor, Astra, Brimstone, Omen, Viper };
        }

        /// <summary>
        /// Sets an array of checkboxes to a new value
        /// </summary>
        /// <param name="cba">array of checkboxes</param>
        /// <param name="val">new bool value for the checkboxes</param>
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

        /// <summary>
        /// checks if a checkbox array is fully true
        /// </summary>
        /// <param name="cba">checkbox array</param>
        /// <returns>checkbox array true?</returns>
        private bool CheckCheckboxArray(CheckBox[] cba)
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

        /// <summary>
        /// Updates all sentinel checkboxes when the 'SENTINEL' Checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSentinels(object sender, RoutedEventArgs e)
        {
            bool newVal = (Sentinels.IsChecked == true);
            UpdateCb(sentinels, newVal);
        }

        /// <summary>
        /// Updates the 'SENTINELS' Checkbox when a sentinel is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAgentsSentinels_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Sentinels.IsChecked = CheckCheckboxArray(sentinels);
        }


        /// <summary>
        /// Updates all initiator checkboxes when the 'INITIATOR' Checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbInitiators(object sender, RoutedEventArgs e)
        {
            bool newVal = (Initiators.IsChecked == true);
            UpdateCb(initiators, newVal);
        }

        /// <summary>
        /// Updates the 'INITIATORS' Checkbox when a initiator is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAgentsInitiators_Click(object sender, RoutedEventArgs e)			
        {
            CheckBox checkBox = (CheckBox)sender;
            Initiators.IsChecked = CheckCheckboxArray(initiators);
        }

        /// <summary>
        /// Updates all duelist checkboxes when the 'DUELISTS' Checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDuelists(object sender, RoutedEventArgs e)
        {
            bool newVal = (Duelists.IsChecked == true);
            UpdateCb(duelists, newVal);
        }

        /// <summary>
        /// Updates the 'DUELIST' Checkbox when a duelist is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAgentsDuelists_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Duelists.IsChecked = CheckCheckboxArray(duelists);
        }

        /// <summary>
        /// Updates all controller checkboxes when the 'CONTROLLER' Checkbox is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbController(object sender, RoutedEventArgs e)
        {
            bool newVal = (Controller.IsChecked == true);
            UpdateCb(controllers, newVal);
        }

        /// <summary>
        /// Updates the 'CONTROLLER' Checkbox when a controller is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAgentsController_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Controller.IsChecked = CheckCheckboxArray(controllers);
        }

        /// <summary>
        /// Creates arrays for all checkboxes and initializes the agents array for randomization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateArrays(object sender, RoutedEventArgs e)
        {
            

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

        /// <summary>
        /// initializes the agents array for randomization
        /// </summary>
        /// <param name="c">Bool array which states if checkboxes are checked</param>
        private void initializeAgents(bool[] c)
        {
            agents = 0;
            for (int i = 0; i < c.Length; i++)
                if (c[i]) agents++;
            
        }
        /// <summary>
        /// randomizes the agent and displays the picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandomize(object sender, RoutedEventArgs e)
        {
            generateArrays(sender, e);
            if (agents > 0)
            {
                int selection = new Random().Next(0, agents);
                convertNumber(ref selection);
                Uri uri = new Uri(String.Format($"pack://application:,,,/images/Agents/{agentsComplete[selection]}.png"));
                lbl_Agent_Name.Content = agentsComplete[selection];
                imgAgent.Source = new BitmapImage(uri);
                //this.Title = agents[selection];
                //this.Icon = new BitmapImage(new Uri($"pack://application:,,,/images/Types/{getAgentType(selection)}.png"));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selection"></param>
        private void convertNumber(ref int selection)
        {
            for (int i = 0; i < selection; i++)
                if (!checkboxes[i]) selection++;
        }
        private string getAgentType(int selection)
        {
            int con = agentsComplete.Length - controllers.Length;
            int due = con - duelists.Length;
            int ini = due - initiators.Length;

            return selection - con > 0 ? "Controller" : selection - due > 0 ? "Duelist" : selection - ini > 0 ? "Initiator" : "Sentinel";
        }
    }
}