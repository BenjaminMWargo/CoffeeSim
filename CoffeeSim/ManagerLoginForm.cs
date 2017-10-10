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
	public partial class ManagerLoginForm : Form {

		MenuController mainForm;

		public ManagerLoginForm(MenuController mainMenuForm) {
			InitializeComponent();
			mainForm = mainMenuForm;
		}

		bool ValidateLogin(string username, string password) {
			//check username
			if (username != "admin") {
				return false;
			}
			//check password
			if (password != "password") {
				return false;
			}
			//return status
			return true;
		}

		private void btn_Login_Click(object sender, EventArgs e) {
			string username = txt_UserName.Text;
			string password = txt_Password.Text;
			//check credentials
			if (ValidateLogin(username, password)) {
				Console.WriteLine("Manager Logged in");
				//open manager control window
				if (mainForm.frmControl == null) {
					mainForm.frmControl = new ManagerControlForm(mainForm);
					mainForm.frmControl.Show();
					this.Close();
					mainForm.frmLogin = null;
				}
			} else {
				Console.WriteLine("Failed Login");
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e) {
			//return to main form
			this.Close();
			mainForm.frmLogin = null;//unset the reference
		}
	}
}
