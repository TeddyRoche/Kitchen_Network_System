
namespace PointOfSale_Client
{
    partial class SeatingChart
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServerStatusBtn = new System.Windows.Forms.Button();
            this.ConnectToServerBtn = new System.Windows.Forms.Button();
            this.Order1 = new System.Windows.Forms.ListBox();
            this.Order2 = new System.Windows.Forms.ListBox();
            this.Order3 = new System.Windows.Forms.ListBox();
            this.Order4 = new System.Windows.Forms.ListBox();
            this.Order5 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1246, -590);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "White - Open Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Purple - Awaiting Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yellow - Food Delivered";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Orange - Table Ordered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue - Table Seated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Green - Selected";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ServerStatusBtn);
            this.groupBox3.Controls.Add(this.ConnectToServerBtn);
            this.groupBox3.Location = new System.Drawing.Point(283, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Options";
            // 
            // ServerStatusBtn
            // 
            this.ServerStatusBtn.BackColor = System.Drawing.Color.Red;
            this.ServerStatusBtn.Enabled = false;
            this.ServerStatusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStatusBtn.Location = new System.Drawing.Point(200, 19);
            this.ServerStatusBtn.Name = "ServerStatusBtn";
            this.ServerStatusBtn.Size = new System.Drawing.Size(185, 43);
            this.ServerStatusBtn.TabIndex = 8;
            this.ServerStatusBtn.Text = "Server: Disconnected";
            this.ServerStatusBtn.UseVisualStyleBackColor = false;
            // 
            // ConnectToServerBtn
            // 
            this.ConnectToServerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConnectToServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectToServerBtn.Location = new System.Drawing.Point(9, 19);
            this.ConnectToServerBtn.Name = "ConnectToServerBtn";
            this.ConnectToServerBtn.Size = new System.Drawing.Size(185, 43);
            this.ConnectToServerBtn.TabIndex = 6;
            this.ConnectToServerBtn.Text = "Connect To Server";
            this.ConnectToServerBtn.UseVisualStyleBackColor = false;
            this.ConnectToServerBtn.Click += new System.EventHandler(this.ConnectToServerBtn_Click);
            // 
            // Order1
            // 
            this.Order1.BackColor = System.Drawing.SystemColors.Info;
            this.Order1.Enabled = false;
            this.Order1.FormattingEnabled = true;
            this.Order1.Location = new System.Drawing.Point(12, 37);
            this.Order1.Name = "Order1";
            this.Order1.Size = new System.Drawing.Size(185, 290);
            this.Order1.TabIndex = 8;
            this.Order1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Order2
            // 
            this.Order2.BackColor = System.Drawing.SystemColors.Info;
            this.Order2.Enabled = false;
            this.Order2.FormattingEnabled = true;
            this.Order2.Location = new System.Drawing.Point(203, 37);
            this.Order2.Name = "Order2";
            this.Order2.Size = new System.Drawing.Size(185, 290);
            this.Order2.TabIndex = 9;
            this.Order2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Order3
            // 
            this.Order3.BackColor = System.Drawing.SystemColors.Info;
            this.Order3.Enabled = false;
            this.Order3.FormattingEnabled = true;
            this.Order3.Location = new System.Drawing.Point(394, 37);
            this.Order3.Name = "Order3";
            this.Order3.Size = new System.Drawing.Size(185, 290);
            this.Order3.TabIndex = 10;
            this.Order3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Order4
            // 
            this.Order4.BackColor = System.Drawing.SystemColors.Info;
            this.Order4.Enabled = false;
            this.Order4.FormattingEnabled = true;
            this.Order4.Location = new System.Drawing.Point(585, 38);
            this.Order4.Name = "Order4";
            this.Order4.Size = new System.Drawing.Size(185, 290);
            this.Order4.TabIndex = 11;
            this.Order4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Order5
            // 
            this.Order5.BackColor = System.Drawing.SystemColors.Info;
            this.Order5.Enabled = false;
            this.Order5.FormattingEnabled = true;
            this.Order5.Location = new System.Drawing.Point(776, 38);
            this.Order5.Name = "Order5";
            this.Order5.Size = new System.Drawing.Size(185, 290);
            this.Order5.TabIndex = 12;
            this.Order5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Complete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(394, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Complete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(585, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "Complete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(776, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 43);
            this.button5.TabIndex = 17;
            this.button5.Text = "Complete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Table: XX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Table: XX";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Table: XX";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(655, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Table: XX";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(848, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Table: XX";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // SeatingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(974, 461);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Order5);
            this.Controls.Add(this.Order4);
            this.Controls.Add(this.Order3);
            this.Controls.Add(this.Order2);
            this.Controls.Add(this.Order1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeatingChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malas Point of Sale System (Kitchen)";
            this.Load += new System.EventHandler(this.SeatingChart_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConnectToServerBtn;
        private System.Windows.Forms.Button ServerStatusBtn;
        private System.Windows.Forms.ListBox Order1;
        private System.Windows.Forms.ListBox Order2;
        private System.Windows.Forms.ListBox Order3;
        private System.Windows.Forms.ListBox Order4;
        private System.Windows.Forms.ListBox Order5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label1;
    }
}

