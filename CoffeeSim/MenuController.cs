using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeSim 
{
    public partial class MenuController : Form
    {
        public MenuController()
        {
            InitializeComponent();
        }

        // For when the Menu UI is loaded
        private void MenuController_Load(object sender, EventArgs e)
        {
            // Get the dynamic information for the various components of the form
            GetListOfCoffees();
            GetListOfToppings();
        }

        #region Dynamic Info Getters

        // A drop down menu for selecting the desired coffee
        private void GetListOfCoffees()
        {
            List<string> coffeesList = new List<string>();  // Will instead call ReadData from CoffeesFileManager

            // Just for testing without coffee file manager
            coffeesList.Add(CoffeesDropBox.Text);
            coffeesList.Add("Regular $2.50");
            coffeesList.Add("Decaf $3.00");
            coffeesList.Add("House Blend $3.25");

            CoffeesDropBox.DataSource = coffeesList;
        }

        // A list of toppings for the user to choose from
        private void GetListOfToppings()
        {
            List<string> toppingsList = new List<string>(); // Will instead call ReadData from ToppingsFileManager

            // Just for testing without toppings file manager
            toppingsList.Add("Mocha");
            toppingsList.Add("Whip");
            toppingsList.Add("Milk");

            // Toppings list properties
            ToppingsListBox.DataSource = toppingsList;
        }

        #endregion

        #region EventHandlers

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Manager wants to log in");
        }

        private void CoffeesDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You selected {0}", CoffeesDropBox.SelectedItem.ToString());

            if (CoffeesDropBox.SelectedItem.ToString() != "- Select a coffee -")
            {
                DynamicTotalLabel.Text = "$100.00";
            }
            else
            {
                DynamicTotalLabel.Text = "$0.00";
            }
        }

        #endregion
    }
}
