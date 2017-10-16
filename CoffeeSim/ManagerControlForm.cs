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

namespace CoffeeSim {
	public partial class ManagerControlForm : Form {

		List<CoffeeModel> CoffeeList;
		List<ToppingModel> ToppingList;
        OrderHistoryFileManager ohfm;

		//on form load
		private void ManagerControlForm_Load(object sender, EventArgs e) {
			CoffeeList = new List<CoffeeModel>();
			ToppingList = new List<ToppingModel>();
			RegisterEvent(MenuHasChanged);
			OnMenuChanged(this, EventArgs.Empty);
            
		}

		public delegate void MenuChangeEvent(object sender, EventArgs e);
		MenuChangeEvent OnMenuChanged;

		MenuController mainMenu;

		void MenuHasChanged(object sender, EventArgs e) {
			//load menus

			//repopulate lists
			lb_Coffees.Items.Clear();
			lb_Toppings.Items.Clear();
			foreach (CoffeeModel c in CoffeeList) {
				lb_Coffees.Items.Add(c.Name);
			}
			foreach (ToppingModel t in ToppingList) {
				lb_Toppings.Items.Add(t.Name);
			}
		}

		void ClearTextBoxes() {
			txt_ItemName.Clear();
			txt_ItemPrice.Clear();
		}

		void SetNewFilePath() {
			//set new filepath
			throw new NotImplementedException();
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		#region List Changers
		void AddCoffee(string name, decimal price) {
			//add coffee to list
			CoffeeModel cf = new CoffeeModel(name, price);
			CoffeeList.Add(cf);
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void RemoveCoffee(CoffeeModel coffee) {
			//remove coffee from list
			CoffeeList.Remove(coffee);
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void AddTopping(string name, decimal price) {
			//add topping to list
			ToppingModel tf = new ToppingModel(name, price);
			ToppingList.Add(tf);
            //write topping list here

            //write topping list here
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void RemoveTopping(ToppingModel topping) {
			//remove topping from list
			ToppingList.Remove(topping);
            //write topping list here

            //write topping list here
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void GenerateReport() {
            //generate report
            List<OrderModel> orderHistory = ohfm.GetOrderHistory();
            ohfm.WriteReport(orderHistory, "OrderReport.txt");
		}

		void LoadNewFile() {
			//open file browser
			throw new Exception("Do File stuff");
		}
		#endregion

		public void RegisterEvent(MenuChangeEvent e){
			OnMenuChanged += e;
		}

		public ManagerControlForm(MenuController mainMenuController, OrderHistoryFileManager pOHFM) {
			InitializeComponent();
			mainMenu = mainMenuController;
            ohfm = pOHFM;
            mainMenu.SubscribeManagerEvents(this);
        }

		private void btn_Close_Click(object sender, EventArgs e) {
			this.Close();
			mainMenu.frmControl = null; //unset reference
			OnMenuChanged = null; //unset event handler
		}

		private void btn_AddCoffee_Click(object sender, EventArgs e) {
			//make sure that there is input
			string itemName = txt_ItemName.Text.Trim();
			decimal itemPrice = 0.00m;
			if (txt_ItemName.Text.Trim() == "" || txt_ItemPrice.Text.Trim() == "") {
				MessageBox.Show("You must enter a name and a valid price.");
				return;
			}
			if (!decimal.TryParse(txt_ItemPrice.Text, out itemPrice)) {
				MessageBox.Show("Invalid price");
				return;
			}
			//if successful
			AddCoffee(itemName, itemPrice);
			ClearTextBoxes();
		}

		private void btn_AddTopping_Click(object sender, EventArgs e) {
			//make sure that there is input
			string itemName = txt_ItemName.Text.Trim();
			decimal itemPrice = 0.00m;
			if (txt_ItemName.Text.Trim() == "" || txt_ItemPrice.Text.Trim() == "") {
				MessageBox.Show("You must enter a name and a valid price.");
				return;
			}
			if (!decimal.TryParse(txt_ItemPrice.Text, out itemPrice)) {
				MessageBox.Show("Invalid price");
				return;
			}
			//if successful
			AddTopping(itemName, itemPrice);
		}

		private void btn_RemoveCoffee_Click(object sender, EventArgs e) {
			int index = lb_Coffees.SelectedIndex;
			//get coffee at index
			if (index != -1) {
				RemoveCoffee(CoffeeList[index]);
			}
		}

		private void btn_RemoveTopping_Click(object sender, EventArgs e) {
			int index = lb_Toppings.SelectedIndex;
			//get coffee at index
			if (index != -1) {
				RemoveTopping(ToppingList[index]);
			}
		}

        private void btn_Report_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }


        //Calls to FileManagers
        private void btn_OpenFileToppings_Click(object sender, EventArgs e)
        {

        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {

        }
    }
}
