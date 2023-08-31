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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromloanlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnViewRepaymentSchedule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lvwBorrowerList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerInListBorrower = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnViewRepaymentSchedule);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.lvwBorrowerList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 422);
            this.panel1.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.close1;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(599, 379);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 32);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "បិទ";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnViewRepaymentSchedule
            // 
            this.btnViewRepaymentSchedule.Location = new System.Drawing.Point(18, 349);
            this.btnViewRepaymentSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRepaymentSchedule.Name = "btnViewRepaymentSchedule";
            this.btnViewRepaymentSchedule.Size = new System.Drawing.Size(148, 28);
            this.btnViewRepaymentSchedule.TabIndex = 28;
            this.btnViewRepaymentSchedule.Text = "តារាងការសងត្រលប់";
            this.btnViewRepaymentSchedule.UseVisualStyleBackColor = true;
            this.btnViewRepaymentSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "កម្ចីសរុបសរុបៈ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(420, 335);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(288, 35);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // lvwBorrowerList
            // 
            this.lvwBorrowerList.CheckBoxes = true;
            this.lvwBorrowerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwBorrowerList.FullRowSelect = true;
            this.lvwBorrowerList.GridLines = true;
            this.lvwBorrowerList.HideSelection = false;
            this.lvwBorrowerList.Location = new System.Drawing.Point(8, 74);
            this.lvwBorrowerList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwBorrowerList.MultiSelect = false;
            this.lvwBorrowerList.Name = "lvwBorrowerList";
            this.lvwBorrowerList.Size = new System.Drawing.Size(700, 258);
            this.lvwBorrowerList.TabIndex = 2;
            this.lvwBorrowerList.UseCompatibleStateImageBehavior = false;
            this.lvwBorrowerList.View = System.Windows.Forms.View.Details;
            this.lvwBorrowerList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwBorrowerList_ColumnClick);
            this.lvwBorrowerList.Resize += new System.EventHandler(this.lvwBorrowerList_Resize);
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "រយៈពេលខ្ចីគិតជាឆ្នាំ";
            this.columnHeader6.Width = 358;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(290, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "តារាងកម្ចី";
            // 
            // timerInListBorrower
            // 
            this.timerInListBorrower.Tick += new System.EventHandler(this.timerInListBorrower_Tick);
            // 
            // fromloanlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(716, 422);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fromloanlist";
            this.Text = "Loan Listing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fromloanlist_FormClosed);
            this.Load += new System.EventHandler(this.fromloanlist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ListView lvwBorrowerList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnViewRepaymentSchedule;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timerInListBorrower;
    }
}