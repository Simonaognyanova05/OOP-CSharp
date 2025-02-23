namespace Classes
{
    partial class frmFaces
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
            this.lblFace = new System.Windows.Forms.Label();
            this.txtFaces = new System.Windows.Forms.TextBox();
            this.lblFaces = new System.Windows.Forms.Label();
            this.lstFaces = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(13, 16);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(48, 20);
            this.lblFace.TabIndex = 0;
            this.lblFace.Text = "Лице";
            // 
            // txtFaces
            // 
            this.txtFaces.Location = new System.Drawing.Point(17, 49);
            this.txtFaces.Name = "txtFaces";
            this.txtFaces.Size = new System.Drawing.Size(311, 26);
            this.txtFaces.TabIndex = 1;
            // 
            // lblFaces
            // 
            this.lblFaces.AutoSize = true;
            this.lblFaces.Location = new System.Drawing.Point(14, 89);
            this.lblFaces.Name = "lblFaces";
            this.lblFaces.Size = new System.Drawing.Size(48, 20);
            this.lblFaces.TabIndex = 2;
            this.lblFaces.Text = "Лица";
            // 
            // lstFaces
            // 
            this.lstFaces.FormattingEnabled = true;
            this.lstFaces.ItemHeight = 20;
            this.lstFaces.Location = new System.Drawing.Point(18, 122);
            this.lstFaces.Name = "lstFaces";
            this.lstFaces.Size = new System.Drawing.Size(311, 124);
            this.lstFaces.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 319);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstFaces);
            this.Controls.Add(this.lblFaces);
            this.Controls.Add(this.txtFaces);
            this.Controls.Add(this.lblFace);
            this.Name = "frmFaces";
            this.Text = "Лица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.TextBox txtFaces;
        private System.Windows.Forms.Label lblFaces;
        private System.Windows.Forms.ListBox lstFaces;
        private System.Windows.Forms.Button btnAdd;
    }
}

