namespace CreditUnionFYP.usercontrol
{
    partial class UserSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearch));
            this.txtLastNameSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNicSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.BackColor = System.Drawing.Color.Silver;
            this.txtLastNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLastNameSearch.BackgroundImage")));
            this.txtLastNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtLastNameSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtLastNameSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtLastNameSearch.Icon")));
            this.txtLastNameSearch.Location = new System.Drawing.Point(12, 14);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(250, 42);
            this.txtLastNameSearch.TabIndex = 2;
            this.txtLastNameSearch.text = "Last Name";
            // 
            // txtNicSearch
            // 
            this.txtNicSearch.BackColor = System.Drawing.Color.Silver;
            this.txtNicSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNicSearch.BackgroundImage")));
            this.txtNicSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNicSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNicSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtNicSearch.Icon")));
            this.txtNicSearch.Location = new System.Drawing.Point(12, 72);
            this.txtNicSearch.Name = "txtNicSearch";
            this.txtNicSearch.Size = new System.Drawing.Size(250, 42);
            this.txtNicSearch.TabIndex = 3;
            this.txtNicSearch.text = "NIC";
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNicSearch);
            this.Controls.Add(this.txtLastNameSearch);
            this.Name = "UserSearch";
            this.Size = new System.Drawing.Size(278, 128);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtLastNameSearch;
        private Bunifu.Framework.UI.BunifuTextbox txtNicSearch;
    }
}
