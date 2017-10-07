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
            this.Text = "Coffee Shop";
            this.Size = new System.Drawing.Size(400, 400);

            // Add the various components to the form
            Controls.Add(GetCoffeesDropBox());
            Controls.Add(GetLogInPanel());
            Controls.Add(GetToppingsList());
            Controls.Add(GetCheckoutPanel());
        }

        #region Control Builders

        // A panel and log in button for accessing the manager interface
        private Panel GetLogInPanel()
        {
            Panel logInPanel = new Panel();
            Button logInButton = new Button();

            // Log-in button properties
            logInButton.Text = "LOGIN";
            logInButton.BackColor = Color.Blue;
            logInButton.ForeColor = Color.White;
            logInButton.Click += new EventHandler(this.GetManagerLogIn_OnClick);

            // Log-in panel properties
            logInPanel.Location = new System.Drawing.Point(315, 5);
            logInPanel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            logInPanel.AutoSize = true;
            logInPanel.Controls.Add(logInButton);

            return logInPanel;
        }

        // A drop down menu for selecting the desired coffee
        private ComboBox GetCoffeesDropBox()
        {
            List<string> coffees = new List<string>();  // Will instead call ReadData from CoffeesFileManager
            ComboBox coffeesDropBox = new ComboBox();
            coffeesDropBox.DataSource = coffees;

            // Just for testing without coffee file manager
            coffees.Add("- Select a coffee - ");
            coffees.Add("Regular $2.50");
            coffees.Add("Decaf $3.00");
            coffees.Add("House Blend $3.25");

            coffeesDropBox.Location = new System.Drawing.Point(5, 5);   // Drop box goes in the upper left corner

            return coffeesDropBox;
        }

        // A list of toppings for the user to choose from
        private ListBox GetToppingsList()
        {
            List<string> toppingsList = new List<string>(); // Will instead call ReadData from ToppingsFileManager
            ListBox toppingsListBox = new ListBox();

            // Just for testing without toppings file manager
            toppingsList.Add("Mocha");
            toppingsList.Add("Whip");
            toppingsList.Add("Milk");

            // 
            toppingsListBox.Location = new System.Drawing.Point(30, 30);
            toppingsListBox.Size = new System.Drawing.Size(245, 200);
            toppingsListBox.DataSource = toppingsList;

            return toppingsListBox;
        }

		private Control GetCheckoutPanel()
		{
            Panel checkoutPanel = new Panel();

            return checkoutPanel;
		}

        #endregion

        #region EventHandlers

        // This method calls the manager log in form to get manager credentials
        private void GetManagerLogIn_OnClick(Object sender, EventArgs e)
        {
            Console.WriteLine("Manager wants to log in");
        }

        #endregion
    }
}
