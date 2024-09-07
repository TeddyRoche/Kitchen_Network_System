
namespace PointOfSale_Client.Forms
{
    partial class AcceptPayment
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
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.TaxAmount = new System.Windows.Forms.Label();
            this.SubTotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayByCardButton = new System.Windows.Forms.Button();
            this.PayByCashButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderListBox
            // 
            this.OrderListBox.BackColor = System.Drawing.SystemColors.Info;
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(12, 35);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(216, 251);
            this.OrderListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Order:";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(360, 253);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(66, 25);
            this.TotalAmount.TabIndex = 16;
            this.TotalAmount.Text = "$0.00";
            // 
            // TaxAmount
            // 
            this.TaxAmount.AutoSize = true;
            this.TaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAmount.Location = new System.Drawing.Point(360, 228);
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.Size = new System.Drawing.Size(66, 25);
            this.TaxAmount.TabIndex = 15;
            this.TaxAmount.Text = "$0.00";
            // 
            // SubTotalAmount
            // 
            this.SubTotalAmount.AutoSize = true;
            this.SubTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalAmount.Location = new System.Drawing.Point(360, 201);
            this.SubTotalAmount.Name = "SubTotalAmount";
            this.SubTotalAmount.Size = new System.Drawing.Size(66, 25);
            this.SubTotalAmount.TabIndex = 14;
            this.SubTotalAmount.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total:";
            // 
            // PayByCardButton
            // 
            this.PayByCardButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PayByCardButton.Location = new System.Drawing.Point(65, 293);
            this.PayByCardButton.Name = "PayByCardButton";
            this.PayByCardButton.Size = new System.Drawing.Size(142, 59);
            this.PayByCardButton.TabIndex = 17;
            this.PayByCardButton.Text = "Pay by Card";
            this.PayByCardButton.UseVisualStyleBackColor = false;
            this.PayByCardButton.Click += new System.EventHandler(this.PayByCardButton_Click);
            // 
            // PayByCashButton
            // 
            this.PayByCashButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PayByCashButton.Location = new System.Drawing.Point(239, 293);
            this.PayByCashButton.Name = "PayByCashButton";
            this.PayByCashButton.Size = new System.Drawing.Size(142, 59);
            this.PayByCashButton.TabIndex = 18;
            this.PayByCashButton.Text = "Pay by Cash";
            this.PayByCashButton.UseVisualStyleBackColor = false;
            this.PayByCashButton.Click += new System.EventHandler(this.PayByCashButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton.Location = new System.Drawing.Point(147, 358);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(142, 24);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PayByCashButton);
            this.Controls.Add(this.PayByCardButton);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.TaxAmount);
            this.Controls.Add(this.SubTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.Name = "AcceptPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AcceptPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label TaxAmount;
        private System.Windows.Forms.Label SubTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PayByCardButton;
        private System.Windows.Forms.Button PayByCashButton;
        private System.Windows.Forms.Button CancelButton;
    }
}