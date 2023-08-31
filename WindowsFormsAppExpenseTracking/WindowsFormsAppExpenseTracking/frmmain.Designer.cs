
namespace WindowsFormsAppExpenseTracking
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewExpense = new System.Windows.Forms.Button();
            this.btnRestartExpense = new System.Windows.Forms.Button();
            this.btnCleanExpense = new System.Windows.Forms.Button();
            this.btnTrackExpense = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpenNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewExpense);
            this.panel1.Controls.Add(this.btnRestartExpense);
            this.panel1.Controls.Add(this.btnCleanExpense);
            this.panel1.Controls.Add(this.btnTrackExpense);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtExpenseAmount);
            this.panel1.Controls.Add(this.txtExpenseType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtExpenNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 303);
            this.panel1.TabIndex = 0;
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.Location = new System.Drawing.Point(55, 246);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(114, 30);
            this.btnViewExpense.TabIndex = 4;
            this.btnViewExpense.Text = "បង្ហាញតារាងចំណាយ";
            this.btnViewExpense.UseVisualStyleBackColor = true;
            this.btnViewExpense.Click += new System.EventHandler(this.btnViewExpense_Click);
            // 
            // btnRestartExpense
            // 
            this.btnRestartExpense.Location = new System.Drawing.Point(185, 247);
            this.btnRestartExpense.Name = "btnRestartExpense";
            this.btnRestartExpense.Size = new System.Drawing.Size(73, 29);
            this.btnRestartExpense.TabIndex = 4;
            this.btnRestartExpense.Text = "ចាប់ផ្ដើមឡើងវិញ";
            this.btnRestartExpense.UseVisualStyleBackColor = true;
            this.btnRestartExpense.Click += new System.EventHandler(this.btnRestartExpense_Click);
            // 
            // btnCleanExpense
            // 
            this.btnCleanExpense.Location = new System.Drawing.Point(264, 246);
            this.btnCleanExpense.Name = "btnCleanExpense";
            this.btnCleanExpense.Size = new System.Drawing.Size(77, 30);
            this.btnCleanExpense.TabIndex = 4;
            this.btnCleanExpense.Text = "សំអាត";
            this.btnCleanExpense.UseVisualStyleBackColor = true;
            this.btnCleanExpense.Click += new System.EventHandler(this.btnCleanExpense_Click);
            // 
            // btnTrackExpense
            // 
            this.btnTrackExpense.Location = new System.Drawing.Point(347, 246);
            this.btnTrackExpense.Name = "btnTrackExpense";
            this.btnTrackExpense.Size = new System.Drawing.Size(85, 30);
            this.btnTrackExpense.TabIndex = 3;
            this.btnTrackExpense.Text = "កត់ចំណាយ";
            this.btnTrackExpense.UseVisualStyleBackColor = true;
            this.btnTrackExpense.Click += new System.EventHandler(this.btnTrackExpense_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "ទឹកប្រាក់ចំណាយ​​ :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(141, 197);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(256, 21);
            this.txtTotalAmount.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ចំណាយសរុប​  :";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(141, 158);
            this.txtExpenseAmount.Multiline = true;
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(256, 21);
            this.txtExpenseAmount.TabIndex = 2;
            this.txtExpenseAmount.TextChanged += new System.EventHandler(this.txtExpenseAmount_TextChanged);
            this.txtExpenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpenseAmount_KeyPress);
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.Location = new System.Drawing.Point(141, 122);
            this.txtExpenseType.Multiline = true;
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.Size = new System.Drawing.Size(256, 21);
            this.txtExpenseType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "ចំណាយ​លើ :";
            // 
            // txtExpenNumber
            // 
            this.txtExpenNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtExpenNumber.Location = new System.Drawing.Point(141, 86);
            this.txtExpenNumber.Multiline = true;
            this.txtExpenNumber.Name = "txtExpenNumber";
            this.txtExpenNumber.ReadOnly = true;
            this.txtExpenNumber.Size = new System.Drawing.Size(256, 21);
            this.txtExpenNumber.TabIndex = 2;
            this.txtExpenNumber.TextChanged += new System.EventHandler(this.txtExpenNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "លេខរៀងចំណាយ​ :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 56);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ការគ្រប់គគ្រងចំណាយ";
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            this.errorPro.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPro.Icon")));
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(443, 302);
            this.Controls.Add(this.panel1);
            this.Name = "frmmain";
            this.Text = "Expense Tracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewExpense;
        private System.Windows.Forms.Button btnRestartExpense;
        private System.Windows.Forms.Button btnCleanExpense;
        private System.Windows.Forms.Button btnTrackExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpenNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorPro;
    }
}

