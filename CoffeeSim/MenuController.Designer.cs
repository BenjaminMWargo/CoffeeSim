namespace CoffeeSim {
	partial class MenuController {
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.CoffeesDropBox = new System.Windows.Forms.ComboBox();
            this.ToppingsListBox = new System.Windows.Forms.ListBox();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.DynamicTotalLabel = new System.Windows.Forms.Label();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.Color.Blue;
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(218, 8);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(93, 22);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "LOGIN";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CoffeesDropBox
            // 
            this.CoffeesDropBox.FormattingEnabled = true;
            this.CoffeesDropBox.Location = new System.Drawing.Point(3, 12);
            this.CoffeesDropBox.Margin = new System.Windows.Forms.Padding(2);
            this.CoffeesDropBox.Name = "CoffeesDropBox";
            this.CoffeesDropBox.Size = new System.Drawing.Size(117, 21);
            this.CoffeesDropBox.TabIndex = 1;
            this.CoffeesDropBox.Text = "- Select a coffee -";
            this.CoffeesDropBox.SelectedIndexChanged += new System.EventHandler(this.CoffeesDropBox_SelectedIndexChanged);
            // 
            // ToppingsListBox
            // 
            this.ToppingsListBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ToppingsListBox.FormattingEnabled = true;
            this.ToppingsListBox.Location = new System.Drawing.Point(166, 49);
            this.ToppingsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ToppingsListBox.Name = "ToppingsListBox";
            this.ToppingsListBox.Size = new System.Drawing.Size(146, 186);
            this.ToppingsListBox.TabIndex = 2;
            this.ToppingsListBox.SelectedIndexChanged += new System.EventHandler(this.ToppingsListBox_SelectedIndexChanged);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckoutButton.BackColor = System.Drawing.Color.Blue;
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.Location = new System.Drawing.Point(218, 252);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(93, 29);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "CHECKOUT";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // DynamicTotalLabel
            // 
            this.DynamicTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DynamicTotalLabel.AutoSize = true;
            this.DynamicTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DynamicTotalLabel.Location = new System.Drawing.Point(155, 257);
            this.DynamicTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DynamicTotalLabel.Name = "DynamicTotalLabel";
            this.DynamicTotalLabel.Size = new System.Drawing.Size(44, 17);
            this.DynamicTotalLabel.TabIndex = 4;
            this.DynamicTotalLabel.Text = "$0.00";
            // 
            // OrderListBox
            // 
            this.OrderListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(3, 50);
            this.OrderListBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(141, 186);
            this.OrderListBox.TabIndex = 5;
            this.OrderListBox.SelectedIndexChanged += new System.EventHandler(this.OrderListBox_SelectedIndexChanged);
            // 
            // MenuController
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.DynamicTotalLabel);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ToppingsListBox);
            this.Controls.Add(this.CoffeesDropBox);
            this.Controls.Add(this.LogInButton);
            this.Name = "MenuController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.MenuController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.ComboBox CoffeesDropBox;
        private System.Windows.Forms.ListBox ToppingsListBox;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Label DynamicTotalLabel;
        private System.Windows.Forms.ListBox OrderListBox;
    }
}

