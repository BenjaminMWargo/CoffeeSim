using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeSim.IOModels;

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
            List<CoffeeModel> coffeesList = new List<CoffeeModel>();  // Will instead call ReadData from CoffeesFileManager
            List<string> coffeesListDisplay = new List<string>();
            coffeesListDisplay.Add("- Select a coffee -");

            // Just for testing without coffee file manager
            coffeesList.Add(new CoffeeModel("Regular", Decimal.Parse("2.50")));
            coffeesList.Add(new CoffeeModel("Decaf", Decimal.Parse("3.00")));
            coffeesList.Add(new CoffeeModel("House Blend", Decimal.Parse("3.25")));

            for (int i = 0; i < coffeesList.Count; i++)
            {
                coffeesListDisplay.Add(coffeesList[i].Name + " - " + coffeesList[i].Price);
            }

            CoffeesDropBox.DataSource = coffeesListDisplay;
        }

        // A list of toppings for the user to choose from
        private void GetListOfToppings()
        {
            List<string> toppingListDisplay = new List<string>();
            List<ToppingModel> toppingList = new List<ToppingModel>(); // Will instead call ReadData from ToppingsFileManager

            // Just for testing without toppings file manager
            toppingList.Add(new ToppingModel("Mocha", Decimal.Parse("0.50")));
            toppingList.Add(new ToppingModel("Milk", Decimal.Parse("0.70")));
            toppingList.Add(new ToppingModel("Water", Decimal.Parse("0.00")));


            for (int i = 0; i < toppingList.Count; i++)
            {
                toppingListDisplay.Add(toppingList[i].Name + " - " + toppingList[i].Price);
            }


            // Toppings list properties
            ToppingsListBox.DataSource = toppingList;
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

            if (OrderListBox.Items.Count > 0)    // If the orders list has a previous coffee selected, remove it
            {
                OrderListBox.Items.RemoveAt(0);
            }

            OrderListBox.Items.Insert(0, CoffeesDropBox.SelectedItem);  // Add the selected coffee to the orders list
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
                else
                {
                    OrderListBox.Items.Add(ToppingsListBox.SelectedItem.ToString());
                }
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
