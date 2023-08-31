
namespace WindowsFormsAppSimpleInterestCalculator
{
    partial class frmSimpleInterestCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleInterestCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPaymentSchedule = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmoundPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInterestEarned = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeAsYearly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterestPerAnnum = new System.Windows.Forms.TextBox();
            this.txtPrinciple = new System.Windows.Forms.Label();
            this.txtPriciple = new System.Windows.Forms.TextBox();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPaymentSchedule);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCalculator);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalAmoundPaid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInterestEarned);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTimeAsYearly);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtInterestPerAnnum);
            this.panel1.Controls.Add(this.txtPrinciple);
            this.panel1.Controls.Add(this.txtPriciple);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 332);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPaymentSchedule
            // 
            this.btnPaymentSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPaymentSchedule.Location = new System.Drawing.Point(53, 287);
            this.btnPaymentSchedule.Name = "btnPaymentSchedule";
            this.btnPaymentSchedule.Size = new System.Drawing.Size(131, 34);
            this.btnPaymentSchedule.TabIndex = 5;
            this.btnPaymentSchedule.Text = "View Payment Schedule";
            this.btnPaymentSchedule.UseVisualStyleBackColor = false;
            this.btnPaymentSchedule.Click += new System.EventHandler(this.btnPaymentSchedule_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(203, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 45);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Simple Interest Caculator";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculator.Location = new System.Drawing.Point(291, 287);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(204, 34);
            this.btnCalculator.TabIndex = 3;
            this.btnCalculator.Text = "Calcularte";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "TotalAmountPaid :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTotalAmoundPaid
            // 
            this.txtTotalAmoundPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAmoundPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTotalAmoundPaid.Location = new System.Drawing.Point(163, 246);
            this.txtTotalAmoundPaid.Name = "txtTotalAmoundPaid";
            this.txtTotalAmoundPaid.Size = new System.Drawing.Size(332, 20);
            this.txtTotalAmoundPaid.TabIndex = 7;
            this.txtTotalAmoundPaid.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Interest Earned :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInterestEarned
            // 
            this.txtInterestEarned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterestEarned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtInterestEarned.Location = new System.Drawing.Point(149, 212);
            this.txtInterestEarned.Name = "txtInterestEarned";
            this.txtInterestEarned.ReadOnly = true;
            this.txtInterestEarned.Size = new System.Drawing.Size(346, 20);
            this.txtInterestEarned.TabIndex = 6;
            this.txtInterestEarned.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time as yearly  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTimeAsYearly
            // 
            this.txtTimeAsYearly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeAsYearly.Location = new System.Drawing.Point(148, 160);
            this.txtTimeAsYearly.Name = "txtTimeAsYearly";
            this.txtTimeAsYearly.Size = new System.Drawing.Size(346, 20);
            this.txtTimeAsYearly.TabIndex = 2;
            this.txtTimeAsYearly.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtTimeAsYearly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeAsYearly_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interest per annum :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInterestPerAnnum
            // 
            this.txtInterestPerAnnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterestPerAnnum.Location = new System.Drawing.Point(179, 112);
            this.txtInterestPerAnnum.Name = "txtInterestPerAnnum";
            this.txtInterestPerAnnum.Size = new System.Drawing.Size(316, 20);
            this.txtInterestPerAnnum.TabIndex = 1;
            this.txtInterestPerAnnum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtInterestPerAnnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestPerAnnum_KeyPress);
            // 
            // txtPrinciple
            // 
            this.txtPrinciple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrinciple.AutoSize = true;
            this.txtPrinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinciple.Location = new System.Drawing.Point(50, 66);
            this.txtPrinciple.Name = "txtPrinciple";
            this.txtPrinciple.Size = new System.Drawing.Size(61, 15);
            this.txtPrinciple.TabIndex = 7;
            this.txtPrinciple.Text = "Principle :";
            this.txtPrinciple.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPriciple
            // 
            this.txtPriciple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriciple.Location = new System.Drawing.Point(117, 65);
            this.txtPriciple.Multiline = true;
            this.txtPriciple.Name = "txtPriciple";
            this.txtPriciple.Size = new System.Drawing.Size(378, 20);
            this.txtPriciple.TabIndex = 0;
            this.txtPriciple.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPriciple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriciple_KeyPress);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            this.errorPro.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPro.Icon")));
            this.errorPro.RightToLeftChanged += new System.EventHandler(this.errorProvider1_RightToLeftChanged);
            // 
            // frmSimpleInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(574, 331);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimpleInterestCalculator";
            this.Text = "FormSimpleInterestCalculator";
            this.Load += new System.EventHandler(this.FormSimpleInterestCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPriciple;
        private System.Windows.Forms.Label txtPrinciple;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmoundPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInterestEarned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeAsYearly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterestPerAnnum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPaymentSchedule;
        private System.Windows.Forms.ErrorProvider errorPro;
    }
}

