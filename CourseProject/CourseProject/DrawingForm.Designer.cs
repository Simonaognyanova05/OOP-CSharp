namespace CourseProject
{
    partial class DrawingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(717, 89);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(213, 53);
            this.btnFillColor.TabIndex = 0;
            this.btnFillColor.Text = "btnFillColor";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Location = new System.Drawing.Point(717, 30);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(213, 53);
            this.btnBorderColor.TabIndex = 1;
            this.btnBorderColor.Text = "btnBorderColor";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(717, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Rectangle",
            "Square",
            "Circle",
            "Triangle"});
            this.comboBoxShapes.Location = new System.Drawing.Point(730, 242);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(285, 28);
            this.comboBoxShapes.TabIndex = 3;
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 585);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.btnFillColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawingForm";
            this.Text = "DrawingForm";
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxShapes;
    }
}