namespace CreditUnionFYP.usercontrol
{
    partial class UploadDialog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowserFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowserFolder
            // 
            this.btnBrowserFolder.Location = new System.Drawing.Point(30, 19);
            this.btnBrowserFolder.Name = "btnBrowserFolder";
            this.btnBrowserFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserFolder.TabIndex = 0;
            this.btnBrowserFolder.Text = "Browse ";
            this.btnBrowserFolder.UseVisualStyleBackColor = true;
            this.btnBrowserFolder.Click += new System.EventHandler(this.btnBrowserFolder_Click);
            // 
            // txtPath
            // 
            this.txtPath.AcceptsReturn = true;
            this.txtPath.AcceptsTab = true;
            this.txtPath.Location = new System.Drawing.Point(125, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(209, 20);
            this.txtPath.TabIndex = 1;
            // 
            // UploadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowserFolder);
            this.Name = "UploadDialog";
            this.Size = new System.Drawing.Size(367, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowserFolder;
        private System.Windows.Forms.TextBox txtPath;
    }
}
