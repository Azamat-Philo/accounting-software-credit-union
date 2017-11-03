namespace Common
{
    partial class AccountType
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
            this.dgAccountType = new System.Windows.Forms.DataGridView();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSaveAccountType = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAccountType
            // 
            this.dgAccountType.AllowUserToAddRows = false;
            this.dgAccountType.AllowUserToDeleteRows = false;
            this.dgAccountType.AllowUserToOrderColumns = true;
            this.dgAccountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountType.Location = new System.Drawing.Point(12, 247);
            this.dgAccountType.Name = "dgAccountType";
            this.dgAccountType.Size = new System.Drawing.Size(333, 83);
            this.dgAccountType.TabIndex = 0;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(12, 26);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(114, 13);
            this.lbAccountType.TabIndex = 1;
            this.lbAccountType.Text = "Account Type Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(12, 78);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(69, 13);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 56);
            this.textBox2.TabIndex = 4;
            // 
            // btnSaveAccountType
            // 
            this.btnSaveAccountType.Location = new System.Drawing.Point(243, 160);
            this.btnSaveAccountType.Name = "btnSaveAccountType";
            this.btnSaveAccountType.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAccountType.TabIndex = 5;
            this.btnSaveAccountType.Text = "Save";
            this.btnSaveAccountType.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(132, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // AccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 365);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAccountType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.dgAccountType);
            this.Name = "AccountType";
            this.Text = "Account Type";
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccountType;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSaveAccountType;
        private System.Windows.Forms.Button btnReset;
    }
}