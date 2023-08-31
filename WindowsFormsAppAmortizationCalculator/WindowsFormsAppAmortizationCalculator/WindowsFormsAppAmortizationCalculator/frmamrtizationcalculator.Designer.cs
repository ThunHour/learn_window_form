namespace WindowsFormsAppAmortizationCalculator
{
    partial class frmamrtizationcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmamrtizationcalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewRepaymentSchedule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloantenure = new System.Windows.Forms.TextBox();
            this.txtinterestrate = new System.Windows.Forms.TextBox();
            this.lblposition = new System.Windows.Forms.Label();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnViewLoanList = new System.Windows.Forms.Button();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeOfInteresrBtn = new System.Windows.Forms.Timer(this.components);
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewRepaymentSchedule);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtloantenure);
            this.panel1.Controls.Add(this.txtinterestrate);
            this.panel1.Controls.Add(this.lblposition);
            this.panel1.Controls.Add(this.btnMoveLast);
            this.panel1.Controls.Add(this.btnMoveNext);
            this.panel1.Controls.Add(this.btnMovePrevious);
            this.panel1.Controls.Add(this.btnMoveFirst);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnViewLoanList);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnNew);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 533);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnViewRepaymentSchedule
            // 
            this.btnViewRepaymentSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRepaymentSchedule.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRepaymentSchedule.Location = new System.Drawing.Point(701, 351);
            this.btnViewRepaymentSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRepaymentSchedule.Name = "btnViewRepaymentSchedule";
            this.btnViewRepaymentSchedule.Size = new System.Drawing.Size(113, 71);
            this.btnViewRepaymentSchedule.TabIndex = 27;
            this.btnViewRepaymentSchedule.Text = "តារាងការសង   ត្រលប់";
            this.btnViewRepaymentSchedule.UseVisualStyleBackColor = true;
            this.btnViewRepaymentSchedule.Click += new System.EventHandler(this.btnreviewrepaymentschedule_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 376);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "សុពលភាពពីថ្ងៃ";
            // 
            // txtloantenure
            // 
            this.txtloantenure.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloantenure.Location = new System.Drawing.Point(191, 318);
            this.txtloantenure.Margin = new System.Windows.Forms.Padding(2);
            this.txtloantenure.Name = "txtloantenure";
            this.txtloantenure.Size = new System.Drawing.Size(475, 38);
            this.txtloantenure.TabIndex = 25;
            this.txtloantenure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtloantenure_KeyPress);
            // 
            // txtinterestrate
            // 
            this.txtinterestrate.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinterestrate.Location = new System.Drawing.Point(190, 258);
            this.txtinterestrate.Margin = new System.Windows.Forms.Padding(2);
            this.txtinterestrate.Name = "txtinterestrate";
            this.txtinterestrate.Size = new System.Drawing.Size(475, 38);
            this.txtinterestrate.TabIndex = 24;
            this.txtinterestrate.Enter += new System.EventHandler(this.txtinterestrate_Enter);
            this.txtinterestrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinterestrate_KeyPress);
            this.txtinterestrate.Leave += new System.EventHandler(this.txtinterestrate_Leave);
            // 
            // lblposition
            // 
            this.lblposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblposition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.Location = new System.Drawing.Point(385, 439);
            this.lblposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(84, 37);
            this.lblposition.TabIndex = 23;
            this.lblposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLast.Location = new System.Drawing.Point(479, 438);
            this.btnMoveLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(82, 38);
            this.btnMoveLast.TabIndex = 22;
            this.btnMoveLast.Text = "|>>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnmovelast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNext.Location = new System.Drawing.Point(576, 438);
            this.btnMoveNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(85, 38);
            this.btnMoveNext.TabIndex = 21;
            this.btnMoveNext.Text = ">>";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnmovenext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePrevious.Location = new System.Drawing.Point(283, 437);
            this.btnMovePrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(93, 41);
            this.btnMovePrevious.TabIndex = 20;
            this.btnMovePrevious.Text = "<<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnmoveprevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFirst.Location = new System.Drawing.Point(185, 437);
            this.btnMoveFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(91, 41);
            this.btnMoveFirst.TabIndex = 19;
            this.btnMoveFirst.Text = "<<|";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnmovefirst_Click);
            // 
            // btnViewLoanList
            // 
            this.btnViewLoanList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewLoanList.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoanList.Location = new System.Drawing.Point(701, 299);
            this.btnViewLoanList.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLoanList.Name = "btnViewLoanList";
            this.btnViewLoanList.Size = new System.Drawing.Size(106, 38);
            this.btnViewLoanList.TabIndex = 17;
            this.btnViewLoanList.Text = "បើកតារាង​កម្ចី";
            this.btnViewLoanList.UseVisualStyleBackColor = true;
            this.btnViewLoanList.Click += new System.EventHandler(this.btnviewloanlist_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "រយៈពេលខ្ចីគិតជាឆ្នាំៈ";
            // 
            // dtpeffectivedate
            // 
            this.dtpeffectivedate.CustomFormat = "dd/MM/yyyy";
            this.dtpeffectivedate.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpeffectivedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpeffectivedate.Location = new System.Drawing.Point(191, 373);
            this.dtpeffectivedate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpeffectivedate.Name = "dtpeffectivedate";
            this.dtpeffectivedate.Size = new System.Drawing.Size(475, 38);
            this.dtpeffectivedate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "អត្រាការប្រាក់គិតជាឆ្នាំៈ";
            // 
            // txtloanamount
            // 
            this.txtloanamount.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloanamount.Location = new System.Drawing.Point(191, 197);
            this.txtloanamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtloanamount.Name = "txtloanamount";
            this.txtloanamount.Size = new System.Drawing.Size(475, 38);
            this.txtloanamount.TabIndex = 6;
            this.txtloanamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtloanamount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ទំហំកម្ចីៈ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtborrowername
            // 
            this.txtborrowername.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtborrowername.Location = new System.Drawing.Point(191, 141);
            this.txtborrowername.Margin = new System.Windows.Forms.Padding(2);
            this.txtborrowername.Name = "txtborrowername";
            this.txtborrowername.Size = new System.Drawing.Size(475, 38);
            this.txtborrowername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "ឈ្មោះអ្នកខ្ចីៈ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtloanid
            // 
            this.txtloanid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtloanid.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloanid.Location = new System.Drawing.Point(191, 84);
            this.txtloanid.Margin = new System.Windows.Forms.Padding(2);
            this.txtloanid.Name = "txtloanid";
            this.txtloanid.ReadOnly = true;
            this.txtloanid.Size = new System.Drawing.Size(475, 38);
            this.txtloanid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "លេខកូដកម្ចីៈ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 69);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "ការគណនាប្រាក់កម្ចី";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeOfInteresrBtn
            // 
            this.timeOfInteresrBtn.Tick += new System.EventHandler(this.timeOfInteresrBtn_Tick);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.close1;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(701, 444);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 38);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "បិទ";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.update1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(701, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 38);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = " កែប្រែ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(701, 196);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.save1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(701, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 38);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "     រក្សាទុក";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::WindowsFormsAppAmortizationCalculator.Properties.Resources.new1;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(701, 84);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 38);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "កម្ចីថ្មី";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // frmamrtizationcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(875, 533);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmamrtizationcalculator";
            this.Text = "Amortization Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmamrtizationcalculator_FormClosed);
            this.Load += new System.EventHandler(this.frmamrtizationcalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnViewLoanList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
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
        private System.Windows.Forms.Button btnViewRepaymentSchedule;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timeOfInteresrBtn;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.Button btnclose;
    }
}