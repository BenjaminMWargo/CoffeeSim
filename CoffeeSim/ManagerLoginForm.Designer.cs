namespace CoffeeSim {
	partial class ManagerLoginForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.lbl_UserName = new System.Windows.Forms.Label();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(12, 12);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(199, 20);
			this.txt_UserName.TabIndex = 0;
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(12, 38);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(199, 20);
			this.txt_Password.TabIndex = 1;
			this.txt_Password.UseSystemPasswordChar = true;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(12, 64);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(199, 23);
			this.btn_Login.TabIndex = 2;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click); 
			// btn_Cancel
			// 
			this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Cancel.Location = new System.Drawing.Point(217, 64);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(55, 23);
			this.btn_Cancel.TabIndex = 3;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_UserName
			// 
			this.lbl_UserName.AutoSize = true;
			this.lbl_UserName.Location = new System.Drawing.Point(217, 15);
			this.lbl_UserName.Name = "lbl_UserName";
			this.lbl_UserName.Size = new System.Drawing.Size(55, 13);
			this.lbl_UserName.TabIndex = 4;
			this.lbl_UserName.Text = "Username";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(217, 41);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(53, 13);
			this.lbl_Password.TabIndex = 5;
			this.lbl_Password.Text = "Password";
			// 
			// ManagerLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 97);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.lbl_UserName);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_UserName);
			this.Name = "ManagerLoginForm";
			this.Text = "ManagerLoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label lbl_UserName;
		private System.Windows.Forms.Label lbl_Password;
	}
}