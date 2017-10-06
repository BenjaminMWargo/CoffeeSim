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
        private void MenuController_Load_1(object sender, EventArgs e)
        {
            this.Text = "Coffee Shop";

            Controls.Add(GetCoffeesDropBox());
            Controls.Add(GetToppingsList());
        }

		// A drop down menu for selecting the desired coffee
		private ComboBox GetCoffeesDropBox()
		{
			List<string> coffees = new List<string>();
			ComboBox coffeesDropBox = new ComboBox();
			coffeesDropBox.DataSource = coffees;

			coffees.Add("- Select a coffee - ");
			coffees.Add("Regular");
			coffees.Add("Decaf");
			coffees.Add("House Blend");

			return coffeesDropBox;
		}

		// A list of toppings for the user to choose from
		private ListBox GetToppingsList()
		{
			List<string> toppingsList = new List<string>();
			ListBox toppingsListBox = new ListBox();

			toppingsList.Add("Mocha");
			toppingsList.Add("Whip");
			toppingsList.Add("Milk");

			toppingsListBox.Location = new System.Drawing.Point(30, 30);
			toppingsListBox.Size = new System.Drawing.Size(245, 200);
			toppingsListBox.DataSource = toppingsList;

			return toppingsListBox;
		}

        
	}
}
