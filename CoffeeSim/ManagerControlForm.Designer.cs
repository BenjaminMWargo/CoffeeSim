namespace CoffeeSim {
	partial class ManagerControlForm {
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_Coffees = new System.Windows.Forms.ListBox();
            this.lb_Toppings = new System.Windows.Forms.ListBox();
            this.btn_AddCoffee = new System.Windows.Forms.Button();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.btn_AddTopping = new System.Windows.Forms.Button();
            this.btn_RemoveCoffee = new System.Windows.Forms.Button();
            this.btn_RemoveTopping = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_OpenFileToppings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(263, 226);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_Coffees
            // 
            this.lb_Coffees.FormattingEnabled = true;
            this.lb_Coffees.Location = new System.Drawing.Point(12, 12);
            this.lb_Coffees.Name = "lb_Coffees";
            this.lb_Coffees.Size = new System.Drawing.Size(160, 95);
            this.lb_Coffees.TabIndex = 1;
            // 
            // lb_Toppings
            // 
            this.lb_Toppings.FormattingEnabled = true;
            this.lb_Toppings.Items.AddRange(new object[] {
            "Coffee",
            "Mocha",
            "Frap"});
            this.lb_Toppings.Location = new System.Drawing.Point(178, 12);
            this.lb_Toppings.Name = "lb_Toppings";
            this.lb_Toppings.Size = new System.Drawing.Size(160, 95);
            this.lb_Toppings.TabIndex = 2;
            // 
            // btn_AddCoffee
            // 
            this.btn_AddCoffee.Location = new System.Drawing.Point(12, 139);
            this.btn_AddCoffee.Name = "btn_AddCoffee";
            this.btn_AddCoffee.Size = new System.Drawing.Size(160, 23);
            this.btn_AddCoffee.TabIndex = 3;
            this.btn_AddCoffee.Text = "Add as Coffee";
            this.btn_AddCoffee.UseVisualStyleBackColor = true;
            this.btn_AddCoffee.Click += new System.EventHandler(this.btn_AddCoffee_Click);
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(73, 113);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(99, 20);
            this.txt_ItemName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Price";
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(238, 113);
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemPrice.TabIndex = 7;
            // 
            // btn_AddTopping
            // 
            this.btn_AddTopping.Location = new System.Drawing.Point(178, 139);
            this.btn_AddTopping.Name = "btn_AddTopping";
            this.btn_AddTopping.Size = new System.Drawing.Size(160, 23);
            this.btn_AddTopping.TabIndex = 8;
            this.btn_AddTopping.Text = "Add as Topping";
            this.btn_AddTopping.UseVisualStyleBackColor = true;
            this.btn_AddTopping.Click += new System.EventHandler(this.btn_AddTopping_Click);
            // 
            // btn_RemoveCoffee
            // 
            this.btn_RemoveCoffee.Location = new System.Drawing.Point(12, 168);
            this.btn_RemoveCoffee.Name = "btn_RemoveCoffee";
            this.btn_RemoveCoffee.Size = new System.Drawing.Size(160, 23);
            this.btn_RemoveCoffee.TabIndex = 9;
            this.btn_RemoveCoffee.Text = "Remove Coffee";
            this.btn_RemoveCoffee.UseVisualStyleBackColor = true;
            this.btn_RemoveCoffee.Click += new System.EventHandler(this.btn_RemoveCoffee_Click);
            // 
            // btn_RemoveTopping
            // 
            this.btn_RemoveTopping.Location = new System.Drawing.Point(178, 168);
            this.btn_RemoveTopping.Name = "btn_RemoveTopping";
            this.btn_RemoveTopping.Size = new System.Drawing.Size(160, 23);
            this.btn_RemoveTopping.TabIndex = 10;
            this.btn_RemoveTopping.Text = "Remove Topping";
            this.btn_RemoveTopping.UseVisualStyleBackColor = true;
            this.btn_RemoveTopping.Click += new System.EventHandler(this.btn_RemoveTopping_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(12, 226);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(160, 23);
            this.btn_Report.TabIndex = 11;
            this.btn_Report.Text = "Generate Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(12, 197);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(160, 23);
            this.btn_LoadFile.TabIndex = 12;
            this.btn_LoadFile.Text = "Open File Coffee";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // btn_OpenFileToppings
            // 
            this.btn_OpenFileToppings.Location = new System.Drawing.Point(178, 197);
            this.btn_OpenFileToppings.Name = "btn_OpenFileToppings";
            this.btn_OpenFileToppings.Size = new System.Drawing.Size(160, 23);
            this.btn_OpenFileToppings.TabIndex = 13;
            this.btn_OpenFileToppings.Text = "Open File Toppings";
            this.btn_OpenFileToppings.UseVisualStyleBackColor = true;
            this.btn_OpenFileToppings.Click += new System.EventHandler(this.btn_OpenFileToppings_Click);
            // 
            // ManagerControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.btn_OpenFileToppings);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_RemoveTopping);
            this.Controls.Add(this.btn_RemoveCoffee);
            this.Controls.Add(this.btn_AddTopping);
            this.Controls.Add(this.txt_ItemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.btn_AddCoffee);
            this.Controls.Add(this.lb_Toppings);
            this.Controls.Add(this.lb_Coffees);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerControlForm";
            this.Text = "Manager Control Panel";
            this.Load += new System.EventHandler(this.ManagerControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.ListBox lb_Coffees;
		private System.Windows.Forms.ListBox lb_Toppings;
		private System.Windows.Forms.Button btn_AddCoffee;
		private System.Windows.Forms.TextBox txt_ItemName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ItemPrice;
		private System.Windows.Forms.Button btn_AddTopping;
		private System.Windows.Forms.Button btn_RemoveCoffee;
		private System.Windows.Forms.Button btn_RemoveTopping;
		private System.Windows.Forms.Button btn_Report;
		private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Button btn_OpenFileToppings;
    }
}