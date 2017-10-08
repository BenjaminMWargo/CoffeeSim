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
            this.LogInButton.Location = new System.Drawing.Point(327, 12);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(139, 34);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "LOGIN";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CoffeesDropBox
            // 
            this.CoffeesDropBox.FormattingEnabled = true;
            this.CoffeesDropBox.Location = new System.Drawing.Point(4, 18);
            this.CoffeesDropBox.Name = "CoffeesDropBox";
            this.CoffeesDropBox.Size = new System.Drawing.Size(173, 28);
            this.CoffeesDropBox.TabIndex = 1;
            this.CoffeesDropBox.Text = "- Select a coffee -";
            this.CoffeesDropBox.SelectedIndexChanged += new System.EventHandler(this.CoffeesDropBox_SelectedIndexChanged);
            // 
            // ToppingsListBox
            // 
            this.ToppingsListBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ToppingsListBox.FormattingEnabled = true;
            this.ToppingsListBox.ItemHeight = 20;
            this.ToppingsListBox.Location = new System.Drawing.Point(249, 76);
            this.ToppingsListBox.Name = "ToppingsListBox";
            this.ToppingsListBox.Size = new System.Drawing.Size(217, 284);
            this.ToppingsListBox.TabIndex = 2;
            this.ToppingsListBox.SelectedIndexChanged += new System.EventHandler(this.ToppingsListBox_SelectedIndexChanged);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckoutButton.BackColor = System.Drawing.Color.Blue;
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.Location = new System.Drawing.Point(327, 387);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(139, 45);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "CHECKOUT";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            // 
            // DynamicTotalLabel
            // 
            this.DynamicTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DynamicTotalLabel.AutoSize = true;
            this.DynamicTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DynamicTotalLabel.Location = new System.Drawing.Point(233, 395);
            this.DynamicTotalLabel.Name = "DynamicTotalLabel";
            this.DynamicTotalLabel.Size = new System.Drawing.Size(61, 25);
            this.DynamicTotalLabel.TabIndex = 4;
            this.DynamicTotalLabel.Text = "$0.00";
            // 
            // OrderListBox
            // 
            this.OrderListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 20;
            this.OrderListBox.Location = new System.Drawing.Point(4, 77);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(209, 284);
            this.OrderListBox.TabIndex = 5;
            // 
            // MenuController
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.DynamicTotalLabel);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ToppingsListBox);
            this.Controls.Add(this.CoffeesDropBox);
            this.Controls.Add(this.LogInButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

