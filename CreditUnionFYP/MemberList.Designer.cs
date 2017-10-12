namespace CreditUnionFYP
{
    partial class MemberList
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
            this.userSearch1 = new CreditUnionFYP.usercontrol.UserSearch();
            this.searchByDate1 = new CreditUnionFYP.usercontrol.SearchByDate();
            this.SuspendLayout();
            // 
            // userSearch1
            // 
            this.userSearch1.Location = new System.Drawing.Point(1, 12);
            this.userSearch1.Name = "userSearch1";
            this.userSearch1.Size = new System.Drawing.Size(278, 128);
            this.userSearch1.TabIndex = 0;
            this.userSearch1.txtLastNameSearchValue = "";
            this.userSearch1.txtNicSearchValue = "";
            // 
            // searchByDate1
            // 
            this.searchByDate1.dpFromValue = new System.DateTime(2017, 10, 12, 23, 34, 5, 308);
            this.searchByDate1.dpToValue = new System.DateTime(2017, 10, 12, 23, 34, 20, 817);
            this.searchByDate1.Location = new System.Drawing.Point(310, 23);
            this.searchByDate1.Name = "searchByDate1";
            this.searchByDate1.Size = new System.Drawing.Size(507, 46);
            this.searchByDate1.TabIndex = 1;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 410);
            this.Controls.Add(this.searchByDate1);
            this.Controls.Add(this.userSearch1);
            this.Name = "MemberList";
            this.Text = "Member List";
            this.ResumeLayout(false);

        }

        #endregion

        private usercontrol.UserSearch userSearch1;
        private usercontrol.SearchByDate searchByDate1;
    }
}