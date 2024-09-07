
namespace PointOfSale_Client.Forms
{
    partial class EndOfDayReport
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalRevenueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTaxesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(107, 365);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(210, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.Location = new System.Drawing.Point(12, 25);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(403, 277);
            this.OrdersListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders for the day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Revenue:";
            // 
            // TotalRevenueLabel
            // 
            this.TotalRevenueLabel.AutoSize = true;
            this.TotalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TotalRevenueLabel.Location = new System.Drawing.Point(176, 308);
            this.TotalRevenueLabel.Name = "TotalRevenueLabel";
            this.TotalRevenueLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalRevenueLabel.TabIndex = 5;
            this.TotalRevenueLabel.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(39, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Taxes:";
            // 
            // TotalTaxesLabel
            // 
            this.TotalTaxesLabel.AutoSize = true;
            this.TotalTaxesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TotalTaxesLabel.Location = new System.Drawing.Point(176, 337);
            this.TotalTaxesLabel.Name = "TotalTaxesLabel";
            this.TotalTaxesLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalTaxesLabel.TabIndex = 7;
            this.TotalTaxesLabel.Text = "$0.00";
            // 
            // EndOfDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 398);
            this.ControlBox = false;
            this.Controls.Add(this.TotalTaxesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalRevenueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersListBox);
            this.Controls.Add(this.CloseButton);
            this.Name = "EndOfDayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "End Of Day Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalRevenueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalTaxesLabel;
    }
}