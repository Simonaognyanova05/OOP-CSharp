namespace DrawFigures
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
            this.cmbShapeType = new System.Windows.Forms.ComboBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtDimension1 = new System.Windows.Forms.TextBox();
            this.txtDimension2 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbShapeType
            // 
            this.cmbShapeType.FormattingEnabled = true;
            this.cmbShapeType.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Circle",
            "Triangle"});
            this.cmbShapeType.Location = new System.Drawing.Point(42, 44);
            this.cmbShapeType.Name = "cmbShapeType";
            this.cmbShapeType.Size = new System.Drawing.Size(241, 28);
            this.cmbShapeType.TabIndex = 0;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(42, 103);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(241, 26);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(42, 158);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(241, 26);
            this.txtY.TabIndex = 2;
            this.txtY.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDimension1
            // 
            this.txtDimension1.Location = new System.Drawing.Point(42, 204);
            this.txtDimension1.Name = "txtDimension1";
            this.txtDimension1.Size = new System.Drawing.Size(241, 26);
            this.txtDimension1.TabIndex = 3;
            // 
            // txtDimension2
            // 
            this.txtDimension2.Location = new System.Drawing.Point(42, 257);
            this.txtDimension2.Name = "txtDimension2";
            this.txtDimension2.Size = new System.Drawing.Size(241, 26);
            this.txtDimension2.TabIndex = 4;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(134, 315);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(148, 29);
            this.btnDraw.TabIndex = 5;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtDimension2);
            this.Controls.Add(this.txtDimension1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.cmbShapeType);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShapeType;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtDimension1;
        private System.Windows.Forms.TextBox txtDimension2;
        private System.Windows.Forms.Button btnDraw;
    }
}

