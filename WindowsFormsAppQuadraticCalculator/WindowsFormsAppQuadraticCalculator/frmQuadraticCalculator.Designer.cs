
namespace WindowsFormsAppQuadraticCalculator
{
    partial class frmQuadraticCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtConstant_C = new System.Windows.Forms.TextBox();
            this.txtCoefficientOfX_B = new System.Windows.Forms.TextBox();
            this.txtCoefficientOfXSquare_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Constant_C = new System.Windows.Forms.Label();
            this.CoefficientOfX_B = new System.Windows.Forms.Label();
            this.CoefficientOfXSquare_A = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SimpleQuadraticCalculator = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtX2);
            this.panel1.Controls.Add(this.txtX1);
            this.panel1.Controls.Add(this.txtConstant_C);
            this.panel1.Controls.Add(this.txtCoefficientOfX_B);
            this.panel1.Controls.Add(this.txtCoefficientOfXSquare_A);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Constant_C);
            this.panel1.Controls.Add(this.CoefficientOfX_B);
            this.panel1.Controls.Add(this.CoefficientOfXSquare_A);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 336);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Formula of Quadratic :  aX² + bX + c = 0";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(240, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(348, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 30);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtX2
            // 
            this.txtX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtX2.Location = new System.Drawing.Point(205, 237);
            this.txtX2.Name = "txtX2";
            this.txtX2.ReadOnly = true;
            this.txtX2.Size = new System.Drawing.Size(253, 20);
            this.txtX2.TabIndex = 7;
            this.txtX2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtX1
            // 
            this.txtX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtX1.Location = new System.Drawing.Point(205, 208);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(253, 20);
            this.txtX1.TabIndex = 6;
            this.txtX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtConstant_C
            // 
            this.txtConstant_C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConstant_C.Location = new System.Drawing.Point(119, 167);
            this.txtConstant_C.Name = "txtConstant_C";
            this.txtConstant_C.Size = new System.Drawing.Size(339, 20);
            this.txtConstant_C.TabIndex = 2;
            this.txtConstant_C.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCoefficientOfX_B
            // 
            this.txtCoefficientOfX_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoefficientOfX_B.Location = new System.Drawing.Point(119, 136);
            this.txtCoefficientOfX_B.Name = "txtCoefficientOfX_B";
            this.txtCoefficientOfX_B.Size = new System.Drawing.Size(339, 20);
            this.txtCoefficientOfX_B.TabIndex = 1;
            this.txtCoefficientOfX_B.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCoefficientOfXSquare_A
            // 
            this.txtCoefficientOfXSquare_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoefficientOfXSquare_A.Location = new System.Drawing.Point(119, 106);
            this.txtCoefficientOfXSquare_A.Name = "txtCoefficientOfXSquare_A";
            this.txtCoefficientOfXSquare_A.Size = new System.Drawing.Size(339, 20);
            this.txtCoefficientOfXSquare_A.TabIndex = 0;
            this.txtCoefficientOfXSquare_A.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Value Of First Root X2  :";
            this.label1.Click += new System.EventHandler(this.txtCoefficientOfXSquare_A_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "The Value Of First Root X1  :";
            this.label4.Click += new System.EventHandler(this.txtCoefficientOfXSquare_A_Click);
            // 
            // Constant_C
            // 
            this.Constant_C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Constant_C.AutoSize = true;
            this.Constant_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Constant_C.Location = new System.Drawing.Point(80, 167);
            this.Constant_C.Name = "Constant_C";
            this.Constant_C.Size = new System.Drawing.Size(32, 18);
            this.Constant_C.TabIndex = 1;
            this.Constant_C.Text = "c  :";
            this.Constant_C.Click += new System.EventHandler(this.txtCoefficientOfXSquare_A_Click);
            // 
            // CoefficientOfX_B
            // 
            this.CoefficientOfX_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoefficientOfX_B.AutoSize = true;
            this.CoefficientOfX_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoefficientOfX_B.Location = new System.Drawing.Point(80, 137);
            this.CoefficientOfX_B.Name = "CoefficientOfX_B";
            this.CoefficientOfX_B.Size = new System.Drawing.Size(32, 18);
            this.CoefficientOfX_B.TabIndex = 1;
            this.CoefficientOfX_B.Text = "b  :";
            this.CoefficientOfX_B.Click += new System.EventHandler(this.txtCoefficientOfXSquare_A_Click);
            // 
            // CoefficientOfXSquare_A
            // 
            this.CoefficientOfXSquare_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoefficientOfXSquare_A.AutoSize = true;
            this.CoefficientOfXSquare_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoefficientOfXSquare_A.Location = new System.Drawing.Point(80, 107);
            this.CoefficientOfXSquare_A.Name = "CoefficientOfXSquare_A";
            this.CoefficientOfXSquare_A.Size = new System.Drawing.Size(32, 18);
            this.CoefficientOfXSquare_A.TabIndex = 1;
            this.CoefficientOfXSquare_A.Text = "a  :";
            this.CoefficientOfXSquare_A.Click += new System.EventHandler(this.txtCoefficientOfXSquare_A_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.SimpleQuadraticCalculator);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 57);
            this.panel2.TabIndex = 0;
            // 
            // SimpleQuadraticCalculator
            // 
            this.SimpleQuadraticCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleQuadraticCalculator.AutoSize = true;
            this.SimpleQuadraticCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleQuadraticCalculator.Location = new System.Drawing.Point(37, 13);
            this.SimpleQuadraticCalculator.Name = "SimpleQuadraticCalculator";
            this.SimpleQuadraticCalculator.Size = new System.Drawing.Size(378, 31);
            this.SimpleQuadraticCalculator.TabIndex = 0;
            this.SimpleQuadraticCalculator.Text = "Simple Quadratic Calculator";
            this.SimpleQuadraticCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // frmQuadraticCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(495, 338);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuadraticCalculator";
            this.Text = "Form Quadratic Calculator";
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
        private System.Windows.Forms.TextBox txtCoefficientOfXSquare_A;
        private System.Windows.Forms.Label CoefficientOfXSquare_A;
        private System.Windows.Forms.Label SimpleQuadraticCalculator;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtConstant_C;
        private System.Windows.Forms.TextBox txtCoefficientOfX_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Constant_C;
        private System.Windows.Forms.Label CoefficientOfX_B;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ErrorProvider errorPro;
    }
}

