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
        ToppingsFileManager tfm;
        CoffeeFileManager cfm;

		//on form load
		private void ManagerControlForm_Load(object sender, EventArgs e) {
			CoffeeList = cfm.ReadData();
			ToppingList = tfm.ReadData();
			RegisterEvent(MenuHasChanged);
			OnMenuChanged(this, EventArgs.Empty);
            btn_OpenFileToppings.Text = "Overwrite Toppings";
            btn_LoadFile.Text = "Overwrite Coffees";
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

		#region List Changers
		void AddCoffee(string name, decimal price) {
			//add coffee to list
			CoffeeModel cf = new CoffeeModel(name, price);
            bool success = cfm.Add(cf);
            if (!success)
            {
                MessageBox.Show("Duplicate object entered, please choose a different name.", "Warning");
                return;
            }
            CoffeeList.Add(cf);


            OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void RemoveCoffee(CoffeeModel coffee) {
			//remove coffee from list
			CoffeeList.Remove(coffee);
            cfm.Delete(coffee.Name);
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void AddTopping(string name, decimal price) {
			//add topping to list
			ToppingModel tf = new ToppingModel(name, price);

            bool success = tfm.Add(tf);

            if (!success)
            {
                MessageBox.Show("Duplicate object entered, please choose a different name.", "Warning");
                return;
            }

            ToppingList.Add(tf);


			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void RemoveTopping(ToppingModel topping) {
			//remove topping from list
			ToppingList.Remove(topping);
            //write topping list here
            tfm.Delete(topping.Name);
            //write topping list here
			OnMenuChanged?.Invoke(this, EventArgs.Empty);
		}

		void GenerateReport() {
            //generate report
            List<OrderModel> orderHistory = ohfm.GetOrderHistory();

            if(orderHistory == null || orderHistory.Count == 0)
            {
                MessageBox.Show("No order history to show");
                return;
            }

            bool success = ohfm.WriteReport(orderHistory, "OrderReport.txt");
            if (success)
            {
                System.Diagnostics.Process.Start("OrderReport.txt");
            }
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

            tfm = ToppingsFileManager.GetInstance();
            cfm = CoffeeFileManager.GetInstance();
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
            ClearTextBoxes();
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
            string newFilePath = FileViewerDialog();
            if (!String.IsNullOrEmpty(newFilePath))
            {
                //then overwrite the file
                tfm.OverwriteFile(newFilePath);
            }
            RefreshDisplayLists();
        }

        //Legacy name:  This is the CoffeeManagerLoadFile
        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            string newFilePath = FileViewerDialog();
            if (!String.IsNullOrEmpty(newFilePath))
            {
                //then overwrite the file
                cfm.OverwriteFile(newFilePath);
            }
            RefreshDisplayLists();
        }

        private void RefreshDisplayLists()
        {
            CoffeeList = cfm.ReadData();
            ToppingList = tfm.ReadData();

            OnMenuChanged?.Invoke(this, EventArgs.Empty);
        }

        private string FileViewerDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else
            {
                return null;
            }
        }
    }
}
