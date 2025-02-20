namespace ContactsList___WFA
{
    partial class ContactsList
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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 25;
            this.lstContacts.Items.AddRange(new object[] {
            "--- Menu ---",
            "1. Add Contact",
            "2. Search Contact",
            "3. Delete Contact",
            "4. Display All Contacts",
            "5. Exit"});
            this.lstContacts.Location = new System.Drawing.Point(318, 121);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(289, 179);
            this.lstContacts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone book";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(370, 79);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(111, 26);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Services:";
            this.lblService.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a service:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 26);
            this.textBox1.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 250);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(267, 26);
            this.txtResult.TabIndex = 6;
            this.txtResult.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(7, 208);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(203, 26);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Choose a service:";
            this.lblResult.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(165, 153);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 38);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(165, 282);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(114, 38);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Submit";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Visible = false;
            // 
            // ContactsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstContacts);
            this.Name = "ContactsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsList";
            this.Load += new System.EventHandler(this.ContactsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnResult;
    }
}

