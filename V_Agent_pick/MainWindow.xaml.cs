using System;
using System.Collections.Generic;
using System.Linq;
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
        int agentsCount = 0;
        private AgentList agents = new AgentList();
        //string[] agentsComplete = new string[] { "Cypher", "Deadlock", "Killjoy", "Sage", "Chamber", "Vyse", "Fade", "Kayo", "Skye", "Sova", "Breach", "Gekko", "Iso", "Neon", "Raze", "Jett", "Phoenix", "Reyna", "Yoru", "Harbor", "Astra", "Brimstone", "Omen", "Viper", "Clove"};
        string[] agentsComplete;


        CheckBox[] sentinels;
        CheckBox[] initiators;
        CheckBox[] duelists;
        CheckBox[] controllers;

        
        bool[] checkboxes;

        public MainWindow()
        {
            InitializeComponent();
            ApplyAgentCheckboxes();
        }

        public void ApplyAgentCheckboxes()
        {
            sentinels = new CheckBox[] { Cypher, Deadlock, Killjoy, Sage, Chamber, Vyse };
            initiators = new CheckBox[] { Fade, Kayo, Skye, Sova, Breach, Gekko };
            duelists = new CheckBox[] { Iso, Neon, Raze, Jett, Phoenix, Reyna, Yoru };
            controllers = new CheckBox[] { Harbor, Astra, Brimstone, Omen, Viper, Clove };

            CheckBox[] checkboxesComplete = sentinels.Concat(initiators).Concat(duelists).Concat(controllers).ToArray();
            agentsComplete = new string[agents.getLength()];

            for (int i = 0; i < agentsComplete.Length; i++)
            {
                agentsComplete[i] = agents[i].Name;
            }

            for (int i = 0; i < agentsComplete.Length; i++)
            {
                agents.setCheckBox(checkboxesComplete[i], agentsComplete[i]);
            }
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

            checkboxes = new bool[agentsComplete.Length];

            for (int i = 0; i < sentinels.Length; i++)
            {
                checkboxes[i] = sentinels[i].IsChecked == true;
            }

            for (int i = 0; i < initiators.Length; i++)
            {
                checkboxes[i+sentinels.Length] = sentinels[i].IsChecked == true;
            }

            for (int i = 0; i < duelists.Length; i++)
            {
                checkboxes[i + sentinels.Length + initiators.Length] = duelists[i].IsChecked == true;
            }

            for (int i = 0; i < controllers.Length; i++)
            {
                checkboxes[i + sentinels.Length + initiators.Length + duelists.Length] = controllers[i].IsChecked == true;
            }

/*            checkboxes[0] = Cypher.IsChecked == true;
            checkboxes[1] = Deadlock.IsChecked == true;
            checkboxes[2] = Killjoy.IsChecked == true;
            checkboxes[3] = Sage.IsChecked == true;
            checkboxes[4] = Chamber.IsChecked == true;
            checkboxes[5] = Vyse.IsChecked == true;


            checkboxes[6] = Fade.IsChecked == true;
            checkboxes[7] = Kayo.IsChecked == true;
            checkboxes[8] = Skye.IsChecked == true;
            checkboxes[9] = Sova.IsChecked == true;
            checkboxes[10] = Breach.IsChecked == true;
            checkboxes[11] = Gekko.IsChecked == true;


            checkboxes[12] = Iso.IsChecked == true;
            checkboxes[13] = Neon.IsChecked == true;
            checkboxes[14] = Raze.IsChecked == true;
            checkboxes[15] = Jett.IsChecked == true;
            checkboxes[16] = Phoenix.IsChecked == true;
            checkboxes[17] = Reyna.IsChecked == true;
            checkboxes[18] = Yoru.IsChecked == true;


            checkboxes[19] = Harbor.IsChecked == true;
            checkboxes[20] = Astra.IsChecked == true;
            checkboxes[21] = Brimstone.IsChecked == true;
            checkboxes[22] = Omen.IsChecked == true;
            checkboxes[23] = Viper.IsChecked == true;
            checkboxes[24] = Clove.IsChecked == true;*/

            initializeAgents(checkboxes);
        }

        /// <summary>
        /// initializes the agents array for randomization
        /// </summary>
        /// <param name="c">Bool array which states if checkboxes are checked</param>
        private void initializeAgents(bool[] c)
        {
            agentsCount = 0;
            for (int i = 0; i < c.Length; i++)
                if (c[i]) agentsCount++;
        }
        /// <summary>
        /// randomizes the agent and displays the picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandomize(object sender, RoutedEventArgs e)
        {
            generateArrays(sender, e);
            if (agentsCount > 0)
            {
                int selection = new Random().Next(0, agentsCount);
                convertNumber(ref selection);
                lbl_Agent_Name.Content = agents[selection].Name;
                imgAgent.Source = agents[selection].agentImage;
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
    }
}