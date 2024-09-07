
namespace PointOfSale_Client.Forms
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DrinksTab = new System.Windows.Forms.TabPage();
            this.RootBeerButton = new System.Windows.Forms.Button();
            this.BottledWaterButton = new System.Windows.Forms.Button();
            this.LemonadeButton = new System.Windows.Forms.Button();
            this.IcedTeaButton = new System.Windows.Forms.Button();
            this.FountainDrinkBtn = new System.Windows.Forms.Button();
            this.AppetizersTab = new System.Windows.Forms.TabPage();
            this.HotWingsButton = new System.Windows.Forms.Button();
            this.FriedPicklesButton = new System.Windows.Forms.Button();
            this.ChipsSalsaButton = new System.Windows.Forms.Button();
            this.SandwichesTab = new System.Windows.Forms.TabPage();
            this.ClubButton = new System.Windows.Forms.Button();
            this.PizzaButton = new System.Windows.Forms.Button();
            this.BurgerButton = new System.Windows.Forms.Button();
            this.SaladsTab = new System.Windows.Forms.TabPage();
            this.SteakTipSaladButton = new System.Windows.Forms.Button();
            this.CobSaladButton = new System.Windows.Forms.Button();
            this.StrawberrySaladButton = new System.Windows.Forms.Button();
            this.DesertTab = new System.Windows.Forms.TabPage();
            this.CakeButton = new System.Windows.Forms.Button();
            this.IceCreamButton = new System.Windows.Forms.Button();
            this.MiscTab = new System.Windows.Forms.TabPage();
            this.GiftCard10Button = new System.Windows.Forms.Button();
            this.GiftCard5Button = new System.Windows.Forms.Button();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubTotalAmount = new System.Windows.Forms.Label();
            this.TaxAmount = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DrinksTab.SuspendLayout();
            this.AppetizersTab.SuspendLayout();
            this.SandwichesTab.SuspendLayout();
            this.SaladsTab.SuspendLayout();
            this.DesertTab.SuspendLayout();
            this.MiscTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitButton.Location = new System.Drawing.Point(290, 415);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton.Location = new System.Drawing.Point(419, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DrinksTab);
            this.tabControl1.Controls.Add(this.AppetizersTab);
            this.tabControl1.Controls.Add(this.SandwichesTab);
            this.tabControl1.Controls.Add(this.SaladsTab);
            this.tabControl1.Controls.Add(this.DesertTab);
            this.tabControl1.Controls.Add(this.MiscTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 397);
            this.tabControl1.TabIndex = 2;
            // 
            // DrinksTab
            // 
            this.DrinksTab.BackColor = System.Drawing.SystemColors.Info;
            this.DrinksTab.Controls.Add(this.RootBeerButton);
            this.DrinksTab.Controls.Add(this.BottledWaterButton);
            this.DrinksTab.Controls.Add(this.LemonadeButton);
            this.DrinksTab.Controls.Add(this.IcedTeaButton);
            this.DrinksTab.Controls.Add(this.FountainDrinkBtn);
            this.DrinksTab.Location = new System.Drawing.Point(4, 22);
            this.DrinksTab.Name = "DrinksTab";
            this.DrinksTab.Padding = new System.Windows.Forms.Padding(3);
            this.DrinksTab.Size = new System.Drawing.Size(530, 371);
            this.DrinksTab.TabIndex = 1;
            this.DrinksTab.Text = "Drinks";
            // 
            // RootBeerButton
            // 
            this.RootBeerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RootBeerButton.Location = new System.Drawing.Point(6, 59);
            this.RootBeerButton.Name = "RootBeerButton";
            this.RootBeerButton.Size = new System.Drawing.Size(112, 47);
            this.RootBeerButton.TabIndex = 4;
            this.RootBeerButton.Text = "Root Beer";
            this.RootBeerButton.UseVisualStyleBackColor = false;
            this.RootBeerButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BottledWaterButton
            // 
            this.BottledWaterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottledWaterButton.Location = new System.Drawing.Point(360, 6);
            this.BottledWaterButton.Name = "BottledWaterButton";
            this.BottledWaterButton.Size = new System.Drawing.Size(112, 47);
            this.BottledWaterButton.TabIndex = 3;
            this.BottledWaterButton.Text = "Bottled Water";
            this.BottledWaterButton.UseVisualStyleBackColor = false;
            this.BottledWaterButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // LemonadeButton
            // 
            this.LemonadeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LemonadeButton.Location = new System.Drawing.Point(242, 6);
            this.LemonadeButton.Name = "LemonadeButton";
            this.LemonadeButton.Size = new System.Drawing.Size(112, 47);
            this.LemonadeButton.TabIndex = 2;
            this.LemonadeButton.Text = "Lemonade";
            this.LemonadeButton.UseVisualStyleBackColor = false;
            this.LemonadeButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // IcedTeaButton
            // 
            this.IcedTeaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IcedTeaButton.Location = new System.Drawing.Point(124, 6);
            this.IcedTeaButton.Name = "IcedTeaButton";
            this.IcedTeaButton.Size = new System.Drawing.Size(112, 47);
            this.IcedTeaButton.TabIndex = 1;
            this.IcedTeaButton.Text = "Iced Tea";
            this.IcedTeaButton.UseVisualStyleBackColor = false;
            this.IcedTeaButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // FountainDrinkBtn
            // 
            this.FountainDrinkBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FountainDrinkBtn.Location = new System.Drawing.Point(6, 6);
            this.FountainDrinkBtn.Name = "FountainDrinkBtn";
            this.FountainDrinkBtn.Size = new System.Drawing.Size(112, 47);
            this.FountainDrinkBtn.TabIndex = 0;
            this.FountainDrinkBtn.Text = "Fountain Drink";
            this.FountainDrinkBtn.UseVisualStyleBackColor = false;
            this.FountainDrinkBtn.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // AppetizersTab
            // 
            this.AppetizersTab.BackColor = System.Drawing.SystemColors.Info;
            this.AppetizersTab.Controls.Add(this.HotWingsButton);
            this.AppetizersTab.Controls.Add(this.FriedPicklesButton);
            this.AppetizersTab.Controls.Add(this.ChipsSalsaButton);
            this.AppetizersTab.Location = new System.Drawing.Point(4, 22);
            this.AppetizersTab.Name = "AppetizersTab";
            this.AppetizersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppetizersTab.Size = new System.Drawing.Size(530, 371);
            this.AppetizersTab.TabIndex = 0;
            this.AppetizersTab.Text = "Appetizers";
            // 
            // HotWingsButton
            // 
            this.HotWingsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HotWingsButton.Location = new System.Drawing.Point(242, 6);
            this.HotWingsButton.Name = "HotWingsButton";
            this.HotWingsButton.Size = new System.Drawing.Size(112, 47);
            this.HotWingsButton.TabIndex = 7;
            this.HotWingsButton.Text = "Hot Wings";
            this.HotWingsButton.UseVisualStyleBackColor = false;
            this.HotWingsButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // FriedPicklesButton
            // 
            this.FriedPicklesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FriedPicklesButton.Location = new System.Drawing.Point(124, 6);
            this.FriedPicklesButton.Name = "FriedPicklesButton";
            this.FriedPicklesButton.Size = new System.Drawing.Size(112, 47);
            this.FriedPicklesButton.TabIndex = 6;
            this.FriedPicklesButton.Text = "Fried Pickles";
            this.FriedPicklesButton.UseVisualStyleBackColor = false;
            this.FriedPicklesButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // ChipsSalsaButton
            // 
            this.ChipsSalsaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChipsSalsaButton.Location = new System.Drawing.Point(6, 6);
            this.ChipsSalsaButton.Name = "ChipsSalsaButton";
            this.ChipsSalsaButton.Size = new System.Drawing.Size(112, 47);
            this.ChipsSalsaButton.TabIndex = 5;
            this.ChipsSalsaButton.Text = "Chips and Salsa";
            this.ChipsSalsaButton.UseVisualStyleBackColor = false;
            this.ChipsSalsaButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // SandwichesTab
            // 
            this.SandwichesTab.BackColor = System.Drawing.SystemColors.Info;
            this.SandwichesTab.Controls.Add(this.ClubButton);
            this.SandwichesTab.Controls.Add(this.PizzaButton);
            this.SandwichesTab.Controls.Add(this.BurgerButton);
            this.SandwichesTab.Location = new System.Drawing.Point(4, 22);
            this.SandwichesTab.Name = "SandwichesTab";
            this.SandwichesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SandwichesTab.Size = new System.Drawing.Size(530, 371);
            this.SandwichesTab.TabIndex = 2;
            this.SandwichesTab.Text = "Sandwiches";
            // 
            // ClubButton
            // 
            this.ClubButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClubButton.Location = new System.Drawing.Point(242, 6);
            this.ClubButton.Name = "ClubButton";
            this.ClubButton.Size = new System.Drawing.Size(112, 47);
            this.ClubButton.TabIndex = 10;
            this.ClubButton.Text = "Club Sandwich";
            this.ClubButton.UseVisualStyleBackColor = false;
            this.ClubButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // PizzaButton
            // 
            this.PizzaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PizzaButton.Location = new System.Drawing.Point(124, 6);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(112, 47);
            this.PizzaButton.TabIndex = 9;
            this.PizzaButton.Text = "Pizza";
            this.PizzaButton.UseVisualStyleBackColor = false;
            this.PizzaButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BurgerButton
            // 
            this.BurgerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BurgerButton.Location = new System.Drawing.Point(6, 6);
            this.BurgerButton.Name = "BurgerButton";
            this.BurgerButton.Size = new System.Drawing.Size(112, 47);
            this.BurgerButton.TabIndex = 8;
            this.BurgerButton.Text = "Burger";
            this.BurgerButton.UseVisualStyleBackColor = false;
            this.BurgerButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // SaladsTab
            // 
            this.SaladsTab.BackColor = System.Drawing.SystemColors.Info;
            this.SaladsTab.Controls.Add(this.SteakTipSaladButton);
            this.SaladsTab.Controls.Add(this.CobSaladButton);
            this.SaladsTab.Controls.Add(this.StrawberrySaladButton);
            this.SaladsTab.Location = new System.Drawing.Point(4, 22);
            this.SaladsTab.Name = "SaladsTab";
            this.SaladsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaladsTab.Size = new System.Drawing.Size(530, 371);
            this.SaladsTab.TabIndex = 3;
            this.SaladsTab.Text = "Salads";
            // 
            // SteakTipSaladButton
            // 
            this.SteakTipSaladButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SteakTipSaladButton.Location = new System.Drawing.Point(242, 6);
            this.SteakTipSaladButton.Name = "SteakTipSaladButton";
            this.SteakTipSaladButton.Size = new System.Drawing.Size(112, 47);
            this.SteakTipSaladButton.TabIndex = 13;
            this.SteakTipSaladButton.Text = "Steak Tip Salad";
            this.SteakTipSaladButton.UseVisualStyleBackColor = false;
            this.SteakTipSaladButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // CobSaladButton
            // 
            this.CobSaladButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CobSaladButton.Location = new System.Drawing.Point(124, 6);
            this.CobSaladButton.Name = "CobSaladButton";
            this.CobSaladButton.Size = new System.Drawing.Size(112, 47);
            this.CobSaladButton.TabIndex = 12;
            this.CobSaladButton.Text = "Cob Salad";
            this.CobSaladButton.UseVisualStyleBackColor = false;
            this.CobSaladButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // StrawberrySaladButton
            // 
            this.StrawberrySaladButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StrawberrySaladButton.Location = new System.Drawing.Point(6, 6);
            this.StrawberrySaladButton.Name = "StrawberrySaladButton";
            this.StrawberrySaladButton.Size = new System.Drawing.Size(112, 47);
            this.StrawberrySaladButton.TabIndex = 11;
            this.StrawberrySaladButton.Text = "Strawberry Chicken";
            this.StrawberrySaladButton.UseVisualStyleBackColor = false;
            this.StrawberrySaladButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // DesertTab
            // 
            this.DesertTab.BackColor = System.Drawing.SystemColors.Info;
            this.DesertTab.Controls.Add(this.CakeButton);
            this.DesertTab.Controls.Add(this.IceCreamButton);
            this.DesertTab.Location = new System.Drawing.Point(4, 22);
            this.DesertTab.Name = "DesertTab";
            this.DesertTab.Padding = new System.Windows.Forms.Padding(3);
            this.DesertTab.Size = new System.Drawing.Size(530, 371);
            this.DesertTab.TabIndex = 4;
            this.DesertTab.Text = "Deserts";
            // 
            // CakeButton
            // 
            this.CakeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CakeButton.Location = new System.Drawing.Point(124, 6);
            this.CakeButton.Name = "CakeButton";
            this.CakeButton.Size = new System.Drawing.Size(112, 47);
            this.CakeButton.TabIndex = 15;
            this.CakeButton.Text = "Cake";
            this.CakeButton.UseVisualStyleBackColor = false;
            this.CakeButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // IceCreamButton
            // 
            this.IceCreamButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IceCreamButton.Location = new System.Drawing.Point(6, 6);
            this.IceCreamButton.Name = "IceCreamButton";
            this.IceCreamButton.Size = new System.Drawing.Size(112, 47);
            this.IceCreamButton.TabIndex = 14;
            this.IceCreamButton.Text = "Ice Cream";
            this.IceCreamButton.UseVisualStyleBackColor = false;
            this.IceCreamButton.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // MiscTab
            // 
            this.MiscTab.BackColor = System.Drawing.SystemColors.Info;
            this.MiscTab.Controls.Add(this.GiftCard10Button);
            this.MiscTab.Controls.Add(this.GiftCard5Button);
            this.MiscTab.Location = new System.Drawing.Point(4, 22);
            this.MiscTab.Name = "MiscTab";
            this.MiscTab.Size = new System.Drawing.Size(530, 371);
            this.MiscTab.TabIndex = 5;
            this.MiscTab.Text = "Misc.";
            // 
            // GiftCard10Button
            // 
            this.GiftCard10Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GiftCard10Button.Location = new System.Drawing.Point(121, 3);
            this.GiftCard10Button.Name = "GiftCard10Button";
            this.GiftCard10Button.Size = new System.Drawing.Size(112, 47);
            this.GiftCard10Button.TabIndex = 17;
            this.GiftCard10Button.Text = "Gift Card ($10)";
            this.GiftCard10Button.UseVisualStyleBackColor = false;
            this.GiftCard10Button.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // GiftCard5Button
            // 
            this.GiftCard5Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GiftCard5Button.Location = new System.Drawing.Point(3, 3);
            this.GiftCard5Button.Name = "GiftCard5Button";
            this.GiftCard5Button.Size = new System.Drawing.Size(112, 47);
            this.GiftCard5Button.TabIndex = 16;
            this.GiftCard5Button.Text = "Gift Card ($5)";
            this.GiftCard5Button.UseVisualStyleBackColor = false;
            this.GiftCard5Button.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // OrderListBox
            // 
            this.OrderListBox.BackColor = System.Drawing.SystemColors.Info;
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(556, 60);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(232, 290);
            this.OrderListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveButton.Location = new System.Drawing.Point(556, 34);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tax:";
            // 
            // SubTotalAmount
            // 
            this.SubTotalAmount.AutoSize = true;
            this.SubTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalAmount.Location = new System.Drawing.Point(682, 353);
            this.SubTotalAmount.Name = "SubTotalAmount";
            this.SubTotalAmount.Size = new System.Drawing.Size(66, 25);
            this.SubTotalAmount.TabIndex = 8;
            this.SubTotalAmount.Text = "$0.00";
            // 
            // TaxAmount
            // 
            this.TaxAmount.AutoSize = true;
            this.TaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAmount.Location = new System.Drawing.Point(682, 380);
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.Size = new System.Drawing.Size(66, 25);
            this.TaxAmount.TabIndex = 9;
            this.TaxAmount.Text = "$0.00";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(682, 405);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(66, 25);
            this.TotalAmount.TabIndex = 10;
            this.TotalAmount.Text = "$0.00";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.TaxAmount);
            this.Controls.Add(this.SubTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateOrder";
            this.tabControl1.ResumeLayout(false);
            this.DrinksTab.ResumeLayout(false);
            this.AppetizersTab.ResumeLayout(false);
            this.SandwichesTab.ResumeLayout(false);
            this.SaladsTab.ResumeLayout(false);
            this.DesertTab.ResumeLayout(false);
            this.MiscTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AppetizersTab;
        private System.Windows.Forms.TabPage DrinksTab;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RootBeerButton;
        private System.Windows.Forms.Button BottledWaterButton;
        private System.Windows.Forms.Button LemonadeButton;
        private System.Windows.Forms.Button IcedTeaButton;
        private System.Windows.Forms.Button FountainDrinkBtn;
        private System.Windows.Forms.Button HotWingsButton;
        private System.Windows.Forms.Button FriedPicklesButton;
        private System.Windows.Forms.Button ChipsSalsaButton;
        private System.Windows.Forms.TabPage SandwichesTab;
        private System.Windows.Forms.Button ClubButton;
        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Button BurgerButton;
        private System.Windows.Forms.TabPage SaladsTab;
        private System.Windows.Forms.Button SteakTipSaladButton;
        private System.Windows.Forms.Button CobSaladButton;
        private System.Windows.Forms.Button StrawberrySaladButton;
        private System.Windows.Forms.TabPage DesertTab;
        private System.Windows.Forms.Button CakeButton;
        private System.Windows.Forms.Button IceCreamButton;
        private System.Windows.Forms.TabPage MiscTab;
        private System.Windows.Forms.Button GiftCard10Button;
        private System.Windows.Forms.Button GiftCard5Button;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubTotalAmount;
        private System.Windows.Forms.Label TaxAmount;
        private System.Windows.Forms.Label TotalAmount;
    }
}