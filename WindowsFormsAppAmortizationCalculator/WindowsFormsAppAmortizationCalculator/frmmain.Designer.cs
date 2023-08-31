namespace WindowsFormsAppAmortizationCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreviewrepaymentschedule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloantenure = new System.Windows.Forms.TextBox();
            this.txtinterestrate = new System.Windows.Forms.TextBox();
            this.lblposition = new System.Windows.Forms.Label();
            this.btnmovelast = new System.Windows.Forms.Button();
            this.btnmovenext = new System.Windows.Forms.Button();
            this.btnmoveprevious = new System.Windows.Forms.Button();
            this.btnmovefirst = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnviewloanlist = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpeffectivedate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtloanamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtborrowername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtloanid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnreviewrepaymentschedule);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtloantenure);
            this.panel1.Controls.Add(this.txtinterestrate);
            this.panel1.Controls.Add(this.lblposition);
            this.panel1.Controls.Add(this.btnmovelast);
            this.panel1.Controls.Add(this.btnmovenext);
            this.panel1.Controls.Add(this.btnmoveprevious);
            this.panel1.Controls.Add(this.btnmovefirst);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnviewloanlist);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpeffectivedate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtloanamount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtborrowername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtloanid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 354);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnreviewrepaymentschedule
            // 
            this.btnreviewrepaymentschedule.Location = new System.Drawing.Point(448, 243);
            this.btnreviewrepaymentschedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreviewrepaymentschedule.Name = "btnreviewrepaymentschedule";
            this.btnreviewrepaymentschedule.Size = new System.Drawing.Size(106, 58);
            this.btnreviewrepaymentschedule.TabIndex = 27;
            this.btnreviewrepaymentschedule.Text = "តារាងការសង ត្រលប់";
            this.btnreviewrepaymentschedule.UseVisualStyleBackColor = true;
            this.btnreviewrepaymentschedule.Click += new System.EventHandler(this.btnreviewrepaymentschedule_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "សុពលភាពពីថ្ងៃ";
            // 
            // txtloantenure
            // 
            this.txtloantenure.Location = new System.Drawing.Point(147, 229);
            this.txtloantenure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtloantenure.Name = "txtloantenure";
            this.txtloantenure.Size = new System.Drawing.Size(288, 32);
            this.txtloantenure.TabIndex = 25;
            // 
            // txtinterestrate
            // 
            this.txtinterestrate.Location = new System.Drawing.Point(147, 192);
            this.txtinterestrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtinterestrate.Name = "txtinterestrate";
            this.txtinterestrate.Size = new System.Drawing.Size(288, 32);
            this.txtinterestrate.TabIndex = 24;
            // 
            // lblposition
            // 
            this.lblposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblposition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Location = new System.Drawing.Point(256, 312);
            this.lblposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(70, 24);
            this.lblposition.TabIndex = 23;
            this.lblposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmovelast
            // 
            this.btnmovelast.Location = new System.Drawing.Point(382, 309);
            this.btnmovelast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmovelast.Name = "btnmovelast";
            this.btnmovelast.Size = new System.Drawing.Size(50, 28);
            this.btnmovelast.TabIndex = 22;
            this.btnmovelast.Text = "|>>";
            this.btnmovelast.UseVisualStyleBackColor = true;
            this.btnmovelast.Click += new System.EventHandler(this.btnmovelast_Click);
            // 
            // btnmovenext
            // 
            this.btnmovenext.Location = new System.Drawing.Point(328, 309);
            this.btnmovenext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmovenext.Name = "btnmovenext";
            this.btnmovenext.Size = new System.Drawing.Size(50, 28);
            this.btnmovenext.TabIndex = 21;
            this.btnmovenext.Text = ">>";
            this.btnmovenext.UseVisualStyleBackColor = true;
            this.btnmovenext.Click += new System.EventHandler(this.btnmovenext_Click);
            // 
            // btnmoveprevious
            // 
            this.btnmoveprevious.Location = new System.Drawing.Point(202, 308);
            this.btnmoveprevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmoveprevious.Name = "btnmoveprevious";
            this.btnmoveprevious.Size = new System.Drawing.Size(50, 28);
            this.btnmoveprevious.TabIndex = 20;
            this.btnmoveprevious.Text = "<<";
            this.btnmoveprevious.UseVisualStyleBackColor = true;
            this.btnmoveprevious.Click += new System.EventHandler(this.btnmoveprevious_Click);
            // 
            // btnmovefirst
            // 
            this.btnmovefirst.Location = new System.Drawing.Point(148, 308);
            this.btnmovefirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmovefirst.Name = "btnmovefirst";
            this.btnmovefirst.Size = new System.Drawing.Size(50, 28);
            this.btnmovefirst.TabIndex = 19;
            this.btnmovefirst.Text = "<<|";
            this.btnmovefirst.UseVisualStyleBackColor = true;
            this.btnmovefirst.Click += new System.EventHandler(this.btnmovefirst_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(448, 304);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 32);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "បិទ";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnviewloanlist
            // 
            this.btnviewloanlist.Location = new System.Drawing.Point(448, 206);
            this.btnviewloanlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnviewloanlist.Name = "btnviewloanlist";
            this.btnviewloanlist.Size = new System.Drawing.Size(106, 34);
            this.btnviewloanlist.TabIndex = 17;
            this.btnviewloanlist.Text = "បើកតារាង​កម្ចី";
            this.btnviewloanlist.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(448, 173);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(106, 30);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "កែប្រែ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(448, 140);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 30);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "លុប";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(448, 106);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 30);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "រក្សាទុក";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(448, 73);
            this.btnnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(106, 30);
            this.btnnew.TabIndex = 13;
            this.btnnew.Text = "កម្ចីថ្មី";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "រយៈពេលខ្ចីគិតជាឆ្នាំៈ";
            // 
            // dtpeffectivedate
            // 
            this.dtpeffectivedate.CustomFormat = "dd/MM/yyyy";
            this.dtpeffectivedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpeffectivedate.Location = new System.Drawing.Point(147, 264);
            this.dtpeffectivedate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpeffectivedate.Name = "dtpeffectivedate";
            this.dtpeffectivedate.Size = new System.Drawing.Size(288, 32);
            this.dtpeffectivedate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "អត្រាការប្រាក់គិតជាឆ្នាំៈ";
            // 
            // txtloanamount
            // 
            this.txtloanamount.Location = new System.Drawing.Point(147, 154);
            this.txtloanamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtloanamount.Name = "txtloanamount";
            this.txtloanamount.Size = new System.Drawing.Size(288, 32);
            this.txtloanamount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ទំហំកម្ចីៈ";
            // 
            // txtborrowername
            // 
            this.txtborrowername.Location = new System.Drawing.Point(147, 118);
            this.txtborrowername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtborrowername.Name = "txtborrowername";
            this.txtborrowername.Size = new System.Drawing.Size(288, 32);
            this.txtborrowername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ឈ្មោះអ្នកខ្ចីៈ";
            // 
            // txtloanid
            // 
            this.txtloanid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtloanid.Location = new System.Drawing.Point(147, 80);
            this.txtloanid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtloanid.Name = "txtloanid";
            this.txtloanid.ReadOnly = true;
            this.txtloanid.Size = new System.Drawing.Size(288, 32);
            this.txtloanid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "លេខកូដកម្ចីៈ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "ការគណនាប្រាក់កម្ចី";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hello,",
            "hii"});
            this.comboBox1.Location = new System.Drawing.Point(13, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 28;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(568, 354);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmmain";
            this.Text = "Amortization Calculator";
            this.Activated += new System.EventHandler(this.frmmain_Activated);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Button btnmovelast;
        private System.Windows.Forms.Button btnmovenext;
        private System.Windows.Forms.Button btnmoveprevious;
        private System.Windows.Forms.Button btnmovefirst;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnviewloanlist;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpeffectivedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtloanamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtborrowername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtloanid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinterestrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtloantenure;
        private System.Windows.Forms.Button btnreviewrepaymentschedule;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}