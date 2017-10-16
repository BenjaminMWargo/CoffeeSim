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
		public ManagerLoginForm frmLogin;
		public ManagerControlForm frmControl;

        private CoffeeModel coffeeOrdered;
        private List<CoffeeModel> coffeesList;
        private List<ToppingModel> toppingList;
        private bool ViewFullyLoaded;

        // File Managers
        private OrderHistoryFileManager ohfm;
        private CoffeeFileManager cfm;
        private ToppingsFileManager tfm;

        public MenuController()
        {
            ViewFullyLoaded = false;
            InitializeComponent();
            ohfm = OrderHistoryFileManager.GetInstance();
            cfm = CoffeeFileManager.GetInstance();
            tfm = ToppingsFileManager.GetInstance();
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
            coffeesList = cfm.ReadData();  // Will instead call ReadData from CoffeesFileManager

            List<string> coffeesListDisplay = new List<string>();
            coffeesListDisplay.Add("- Select a coffee -");

            for (int i = 0; i < coffeesList.Count; i++)
            {
                coffeesListDisplay.Add(coffeesList[i].GetDescription());
            }

            CoffeesDropBox.DataSource = coffeesListDisplay;
        }

        // A list of toppings for the user to choose from
        private void GetListOfToppings()
        {
            this.ToppingsListBox.SelectedIndexChanged -= new EventHandler(ToppingsListBox_SelectedIndexChanged);
            List<string> toppingListDisplay = new List<string>();
            toppingList = tfm.ReadData();

            for (int i = 0; i < toppingList.Count; i++)
            {
                toppingListDisplay.Add(toppingList[i].GetDescription());
            }

            // Toppings list properties
            ToppingsListBox.DataSource = toppingListDisplay;
            this.ToppingsListBox.SelectedIndexChanged += new EventHandler(ToppingsListBox_SelectedIndexChanged);
        }

        #endregion

        #region EventHandlers

        private void LogInButton_Click(object sender, EventArgs e)
        {
			//open manager login form
			if (frmLogin == null && frmControl == null) {
				frmLogin = new ManagerLoginForm(this, ohfm);
				frmLogin.Show();
				Console.WriteLine("Manager wants to log in");
			} else {
				Console.WriteLine("Login Screen is open");
			}
        }

        private void CoffeesDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ToppingModel> temp = null;

            if (coffeeOrdered != null)
            {
                temp = coffeeOrdered.Toppings;
                coffeeOrdered.Toppings = null;

                OrderListBox.Items.RemoveAt(0);
            }

            if (CoffeesDropBox.SelectedIndex == 0)
            {
                OrderListBox.Items.Clear();
                coffeeOrdered = null;
            }
            else
            {
                Console.WriteLine("Hello");
                Console.WriteLine("You selected {0}", CoffeesDropBox.SelectedItem.ToString());

                OrderListBox.Items.Insert(0, CoffeesDropBox.SelectedItem);  // Add the selected coffee to the orders list

                coffeeOrdered = (CoffeeModel)coffeesList[CoffeesDropBox.SelectedIndex - 1];

                if (coffeeOrdered.GetType() == typeof(CoffeeModel))
                {
                    coffeeOrdered.Toppings = temp;
                }
            }

            DynamicTotalLabel.Text = getTotal().ToString("C");
        }

        #endregion

        private void ToppingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You selected {0}", ToppingsListBox.SelectedItem.ToString());

            if (ViewFullyLoaded)
            {
                if (coffeeOrdered == null)
                {
                    MessageBox.Show("Please choose a coffee before you select a topping");
                    return;
                }

                if (coffeeOrdered.Toppings == null)
                {
                    coffeeOrdered.Toppings = new List<ToppingModel>();
                }

                coffeeOrdered.Toppings.Add((ToppingModel)toppingList[ToppingsListBox.SelectedIndex]);

                foreach (ToppingModel topping in coffeeOrdered.Toppings)
                {
                    Console.WriteLine(topping.Name);
                }

                OrderListBox.Items.Add(ToppingsListBox.SelectedItem.ToString());

                DynamicTotalLabel.Text = getTotal().ToString("C");
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Console Checkout");
               
            if(coffeeOrdered == null)
            {
                MessageBox.Show("Please select a coffee");
            }
            else if(CustomerTextField.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a customer name");
                return;
            }

            if (coffeeOrdered != null)
            {
                ohfm.AddOrder(new IOModels.OrderModel
                {
                    Coffee = coffeeOrdered,
                    Price = getTotal(),
                    Date = DateTime.Now,
                    CustomerName = CustomerTextField.Text
                });
            }
        }

        private Decimal getTotal()
        {
            if (coffeeOrdered == null)
            {
                return Decimal.Parse("0.00");
            }
                
            Decimal total = coffeeOrdered.Price;

            if (coffeeOrdered.Toppings != null)
            {
                foreach (ToppingModel topping in coffeeOrdered.Toppings)
                {
                    total += topping.Price;
                }
            }
                
            return total;
        }

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrderListBox.SelectedItem == null)
            {
                return;
            }

            int selectedIndex = OrderListBox.SelectedIndex;

            if (selectedIndex == 0) // Selection is coffee
            {
                OrderListBox.Items.Clear();
                coffeeOrdered = null;
            }
            else // Selection is topping
            {
                Console.WriteLine("Here");
                OrderListBox.SelectedItem = null;   
                OrderListBox.Items.RemoveAt(selectedIndex);
                coffeeOrdered.Toppings.RemoveAt(selectedIndex - 1);
            }

            DynamicTotalLabel.Text = getTotal().ToString("C");
        }

		private void OnMenuChanged(object seender, EventArgs e) {
			GetListOfCoffees();
			GetListOfToppings();
            Console.Write("hey");
		}

        public void SubscribeManagerEvents(ManagerControlForm frm)
        {
            frmControl = frm;
            frmControl.RegisterEvent(OnMenuChanged);
        }

    }
}
