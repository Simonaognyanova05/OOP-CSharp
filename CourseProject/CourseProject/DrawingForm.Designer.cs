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
            this.SuspendLayout();
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(717, 135);
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
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 585);
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
    }
}