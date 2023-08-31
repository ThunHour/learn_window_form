namespace WindowsFormsAppAmortizationCalculator
{
    partial class fromloanlist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalexpense = new System.Windows.Forms.TextBox();
            this.lvwexpense = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttotalexpense);
            this.panel1.Controls.Add(this.lvwexpense);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 757);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 673);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 54);
            this.label6.TabIndex = 15;
            this.label6.Text = "កម្ចីសរុបសរុបៈ";
            // 
            // txttotalexpense
            // 
            this.txttotalexpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttotalexpense.Location = new System.Drawing.Point(840, 670);
            this.txttotalexpense.Name = "txttotalexpense";
            this.txttotalexpense.ReadOnly = true;
            this.txttotalexpense.Size = new System.Drawing.Size(572, 62);
            this.txttotalexpense.TabIndex = 14;
            // 
            // lvwexpense
            // 
            this.lvwexpense.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwexpense.FullRowSelect = true;
            this.lvwexpense.GridLines = true;
            this.lvwexpense.HideSelection = false;
            this.lvwexpense.Location = new System.Drawing.Point(27, 153);
            this.lvwexpense.MultiSelect = false;
            this.lvwexpense.Name = "lvwexpense";
            this.lvwexpense.Size = new System.Drawing.Size(1397, 511);
            this.lvwexpense.TabIndex = 2;
            this.lvwexpense.UseCompatibleStateImageBehavior = false;
            this.lvwexpense.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "លេខកូដកម្ចី";
            this.columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ឈ្មោះអ្នកខ្ខី";
            this.columnHeader2.Width = 273;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ទំហំកម្ចី";
            this.columnHeader3.Width = 286;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "អត្រាការប្រាក់ជាឆ្នាំ";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "សុពលភាពពីថ្ងៃ";
            this.columnHeader5.Width = 312;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 138);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(580, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "តារាងកម្ចី";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "រយៈពេលខ្ចីគិតជាឆ្នាំ";
            this.columnHeader6.Width = 358;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 57);
            this.button1.TabIndex = 28;
            this.button1.Text = "តារាងការសងត្រលប់";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fromloanlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1424, 757);
            this.Controls.Add(this.panel1);
            this.Name = "fromloanlist";
            this.Text = "Loan Listing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotalexpense;
        private System.Windows.Forms.ListView lvwexpense;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}