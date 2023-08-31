namespace WindowsFormsAppEmployeeManagementSystem
{
    partial class EmployeeDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PichPhoto = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PichPhoto)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblNID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbldob);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblempname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblempid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PichPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Khmer OS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(252, 124);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 22);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Action";
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.Location = new System.Drawing.Point(206, 106);
            this.lblNID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(34, 22);
            this.lblNID.TabIndex = 10;
            this.lblNID.Text = "1234";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "NID/Passport:";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(212, 80);
            this.lbldob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(66, 22);
            this.lbldob.TabIndex = 8;
            this.lbldob.Text = "02-03-1987";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "ថ្ងៃខែឆ្នាំកំណើតៈ";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(188, 60);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(33, 22);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Male";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "ភេទៈ";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(188, 36);
            this.lblempname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(68, 22);
            this.lblempname.TabIndex = 4;
            this.lblempname.Text = "Laing Moam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ឈ្មោះ:";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(188, 10);
            this.lblempid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(54, 22);
            this.lblempid.TabIndex = 2;
            this.lblempid.Text = "EMPXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "អត្តលេខៈ";
            // 
            // PichPhoto
            // 
            this.PichPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PichPhoto.Location = new System.Drawing.Point(10, 10);
            this.PichPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.PichPhoto.Name = "PichPhoto";
            this.PichPhoto.Size = new System.Drawing.Size(112, 124);
            this.PichPhoto.TabIndex = 0;
            this.PichPhoto.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 74);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EmployeeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDisplay";
            this.Size = new System.Drawing.Size(299, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PichPhoto)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PichPhoto;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
