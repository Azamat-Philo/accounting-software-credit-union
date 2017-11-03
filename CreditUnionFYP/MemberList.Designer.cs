namespace Common
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberList));
            this.MemberSince = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Dob = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LastName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NIC = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchByDate1 = new Common.usercontrol.SearchByDate();
            this.userSearch1 = new Common.usercontrol.UserSearch();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberSince
            // 
            this.MemberSince.HeaderText = "Member Since";
            this.MemberSince.Name = "MemberSince";
            this.MemberSince.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.HeaderText = "Date of birth";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NIC
            // 
            this.NIC.HeaderText = "Nic";
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            this.NIC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Action";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.NIC,
            this.LastName,
            this.FirstName,
            this.Dob,
            this.MemberSince});
            this.dataGridView1.Location = new System.Drawing.Point(13, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 318);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // searchByDate1
            // 
            this.searchByDate1.dpFromValue = new System.DateTime(2017, 10, 13, 0, 0, 0, 0);
            this.searchByDate1.dpToValue = new System.DateTime(2017, 10, 13, 0, 0, 0, 0);
            this.searchByDate1.Location = new System.Drawing.Point(310, 23);
            this.searchByDate1.Name = "searchByDate1";
            this.searchByDate1.Size = new System.Drawing.Size(507, 46);
            this.searchByDate1.TabIndex = 1;
            this.searchByDate1.UseWaitCursor = true;
            // 
            // userSearch1
            // 
            this.userSearch1.Location = new System.Drawing.Point(1, 12);
            this.userSearch1.Name = "userSearch1";
            this.userSearch1.Size = new System.Drawing.Size(278, 128);
            this.userSearch1.TabIndex = 0;
            this.userSearch1.txtLastNameSearchValue = "";
            this.userSearch1.txtNicSearchValue = "";
            this.userSearch1.UseWaitCursor = true;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchByDate1);
            this.Controls.Add(this.userSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member List";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private usercontrol.UserSearch userSearch1;
        private usercontrol.SearchByDate searchByDate1;
        private System.Windows.Forms.DataGridViewLinkColumn MemberSince;
        private System.Windows.Forms.DataGridViewLinkColumn Dob;
        private System.Windows.Forms.DataGridViewLinkColumn FirstName;
        private System.Windows.Forms.DataGridViewLinkColumn LastName;
        private System.Windows.Forms.DataGridViewLinkColumn NIC;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}