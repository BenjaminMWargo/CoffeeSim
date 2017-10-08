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
        private bool ViewFullyLoaded;

        public MenuController()
        {
            ViewFullyLoaded = false;
            InitializeComponent();
        }

        // For when the Menu UI is loaded
        private void MenuController_Load(object sender, EventArgs e)
        {
            // Get the dynamic information for the various components of the form
            GetListOfCoffees();
            GetListOfToppings();

            ViewFullyLoaded = true;
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
            toppingsList.Add("Mocha $0.89");
            toppingsList.Add("Whip $0.49");
            toppingsList.Add("Milk $.99");

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

            if (ViewFullyLoaded)
            {
                if (OrderListBox.Items.Count > 0)    // If the orders list has a previous coffee selected, remove it
                {
                    OrderListBox.Items.RemoveAt(0);
                }

                OrderListBox.Items.Insert(0, CoffeesDropBox.SelectedItem);  // Add the selected coffee to the orders list
            }
        }

        #endregion

        private void ToppingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You selected {0}", ToppingsListBox.SelectedItem.ToString());

            if (ViewFullyLoaded)
            {
                if (CoffeesDropBox.SelectedItem.ToString() == "- Select a coffee -")
                {
                    MessageBox.Show("Please choose a coffee before you select a topping");
                }
            }
        }
    }
}
