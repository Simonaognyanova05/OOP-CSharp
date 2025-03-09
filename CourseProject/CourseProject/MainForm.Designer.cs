namespace CourseProject
{
    partial class MainForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFigures = new System.Windows.Forms.Label();
            this.lstFigures = new System.Windows.Forms.ListBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type of figure:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(106, 164);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 20);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            this.lblA.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(106, 219);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            this.lblB.Visible = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(145, 35);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(202, 26);
            this.txtType.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(145, 164);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(202, 26);
            this.txtA.TabIndex = 4;
            this.txtA.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(145, 206);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(202, 26);
            this.txtB.TabIndex = 5;
            this.txtB.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add figure";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFigures
            // 
            this.lblFigures.AutoSize = true;
            this.lblFigures.Location = new System.Drawing.Point(383, 35);
            this.lblFigures.Name = "lblFigures";
            this.lblFigures.Size = new System.Drawing.Size(66, 20);
            this.lblFigures.TabIndex = 7;
            this.lblFigures.Text = "Figures:";
            this.lblFigures.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstFigures
            // 
            this.lstFigures.FormattingEnabled = true;
            this.lstFigures.ItemHeight = 20;
            this.lstFigures.Location = new System.Drawing.Point(455, 35);
            this.lstFigures.Name = "lstFigures";
            this.lstFigures.Size = new System.Drawing.Size(257, 184);
            this.lstFigures.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(455, 238);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(257, 26);
            this.txtArea.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(402, 238);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Area:";
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(589, 286);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(123, 41);
            this.btnCalcArea.TabIndex = 13;
            this.btnCalcArea.Text = "Calc Area";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(215, 67);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(132, 63);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check your figure";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(460, 286);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(123, 41);
            this.btnDraw.TabIndex = 15;
            this.btnDraw.Text = "Draw figure";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(145, 304);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(202, 26);
            this.txtY.TabIndex = 20;
            this.txtY.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(145, 262);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(202, 26);
            this.txtX.TabIndex = 19;
            this.txtX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(106, 310);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(24, 20);
            this.lblY.TabIndex = 18;
            this.lblY.Text = "Y:";
            this.lblY.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(106, 262);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 20);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "X:";
            this.lblX.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lstFigures);
            this.Controls.Add(this.lblFigures);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblType);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFigures;
        private System.Windows.Forms.ListBox lstFigures;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
    }
}

