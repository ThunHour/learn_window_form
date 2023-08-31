namespace WindowsFormsAppEmployeeMgnt
{
    partial class frmAddmodifyemployee
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
            this.btnsave = new System.Windows.Forms.Button();
            this.txtNIDpassport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnbrowse);
            this.panel1.Controls.Add(this.picphoto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtNIDpassport);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpdob);
            this.panel1.Controls.Add(this.cbogender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtemployeename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtemployeeid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 807);
            this.panel1.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(588, 738);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(162, 57);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtNIDpassport
            // 
            this.txtNIDpassport.Location = new System.Drawing.Point(295, 455);
            this.txtNIDpassport.Name = "txtNIDpassport";
            this.txtNIDpassport.Size = new System.Drawing.Size(456, 62);
            this.txtNIDpassport.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 54);
            this.label6.TabIndex = 7;
            this.label6.Text = "លេខអត្តសញ្ញាណបន័ៈ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 54);
            this.label5.TabIndex = 6;
            this.label5.Text = "ថ្ងៃខែឆ្នាំកំណើតៈ";
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "dd/MM/yyyy";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(262, 369);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(488, 62);
            this.dtpdob.TabIndex = 5;
            // 
            // cbogender
            // 
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbogender.Location = new System.Drawing.Point(261, 287);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(490, 62);
            this.cbogender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "ភេទ:";
            // 
            // txtemployeename
            // 
            this.txtemployeename.Location = new System.Drawing.Point(261, 205);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(490, 62);
            this.txtemployeename.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "ឈ្មោះ:";
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Location = new System.Drawing.Point(262, 123);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(489, 62);
            this.txtemployeeid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "អត្តលេខបុគ្កលិក:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 113);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "បញ្ចូល ឬលុបបុគ្គលិក";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 54);
            this.label7.TabIndex = 10;
            this.label7.Text = "រូបថតៈ";
            // 
            // picphoto
            // 
            this.picphoto.Location = new System.Drawing.Point(124, 561);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(195, 234);
            this.picphoto.TabIndex = 11;
            this.picphoto.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(346, 562);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(257, 70);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "ជ្រើសរើសរូបភាព";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // frmAddmodifyemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(763, 807);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddmodifyemployee";
            this.Text = "Adding or Modifying Employee";
            this.Load += new System.EventHandler(this.frmAddmodifyemployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox txtNIDpassport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.Button btnbrowse;
    }
}