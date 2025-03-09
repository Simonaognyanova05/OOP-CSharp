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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(50, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(165, 25);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Enter shape type:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(37, 189);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(178, 25);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Enter a value for A:";
            this.lblA.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(37, 235);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(177, 25);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Enter a value for B:";
            this.lblB.Visible = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(232, 103);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(287, 26);
            this.txtType.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(232, 188);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(287, 26);
            this.txtA.TabIndex = 4;
            this.txtA.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(232, 234);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(287, 26);
            this.txtB.TabIndex = 5;
            this.txtB.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(396, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add figure";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFigures
            // 
            this.lblFigures.AutoSize = true;
            this.lblFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigures.Location = new System.Drawing.Point(549, 92);
            this.lblFigures.Name = "lblFigures";
            this.lblFigures.Size = new System.Drawing.Size(544, 25);
            this.lblFigures.TabIndex = 7;
            this.lblFigures.Text = "Select a shape to calculate the face, draw it, or erase it.";
            this.lblFigures.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstFigures
            // 
            this.lstFigures.FormattingEnabled = true;
            this.lstFigures.ItemHeight = 20;
            this.lstFigures.Location = new System.Drawing.Point(564, 135);
            this.lstFigures.Name = "lstFigures";
            this.lstFigures.Size = new System.Drawing.Size(539, 184);
            this.lstFigures.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(625, 334);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(478, 26);
            this.txtArea.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(559, 332);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 25);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Area:";
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcArea.Location = new System.Drawing.Point(731, 374);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(210, 41);
            this.btnCalcArea.TabIndex = 13;
            this.btnCalcArea.Text = "Calculate Area";
            this.btnCalcArea.UseVisualStyleBackColor = false;
            this.btnCalcArea.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Info;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(317, 135);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(202, 45);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check your figure";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.Info;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(564, 374);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(161, 41);
            this.btnDraw.TabIndex = 15;
            this.btnDraw.Text = "Draw figure";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(232, 342);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(287, 26);
            this.txtY.TabIndex = 20;
            this.txtY.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(232, 286);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(287, 26);
            this.txtX.TabIndex = 19;
            this.txtX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(20, 343);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(194, 25);
            this.lblY.TabIndex = 18;
            this.lblY.Text = "Enter a coordinate Y:";
            this.lblY.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(20, 287);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(195, 25);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "Enter a coordinate X:";
            this.lblX.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(947, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 41);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete figure";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(478, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 32);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Graphical figures";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 457);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDelete);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
    }
}

