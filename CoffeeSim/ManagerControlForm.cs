using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeSim {
	public partial class ManagerControlForm : Form {

		MenuController mainMenu;

		public ManagerControlForm(MenuController mainMenuController) {
			InitializeComponent();
			mainMenu = mainMenuController;
		}

		private void btn_Close_Click(object sender, EventArgs e) {
			this.Close();
			mainMenu.frmControl = null; //unset reference
		}
	}
}
