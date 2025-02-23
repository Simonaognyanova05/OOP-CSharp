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
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
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
            this.lblFaces.Location = new System.Drawing.Point(13, 159);
            this.lblFaces.Name = "lblFaces";
            this.lblFaces.Size = new System.Drawing.Size(48, 20);
            this.lblFaces.TabIndex = 2;
            this.lblFaces.Text = "Лица";
            // 
            // lstFaces
            // 
            this.lstFaces.FormattingEnabled = true;
            this.lstFaces.ItemHeight = 20;
            this.lstFaces.Location = new System.Drawing.Point(17, 192);
            this.lstFaces.Name = "lstFaces";
            this.lstFaces.Size = new System.Drawing.Size(311, 124);
            this.lstFaces.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(101, 338);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 33);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(17, 119);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(311, 26);
            this.txtNumber.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 86);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(59, 20);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Номер";
            // 
            // frmFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 384);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnRemove);
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
    }
}

