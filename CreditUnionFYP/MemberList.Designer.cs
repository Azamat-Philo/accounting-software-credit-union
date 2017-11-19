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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberList));
            this.dgMemberList = new System.Windows.Forms.DataGridView();
            this.dbEntryStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNic = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMemberList
            // 
            this.dgMemberList.AllowUserToAddRows = false;
            this.dgMemberList.AllowUserToDeleteRows = false;
            this.dgMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.LastName,
            this.FirstName,
            this.NIC,
            this.Dob,
            this.MemberSince,
            this.memberId});
            this.dgMemberList.Location = new System.Drawing.Point(13, 147);
            this.dgMemberList.Name = "dgMemberList";
            this.dgMemberList.ReadOnly = true;
            this.dgMemberList.Size = new System.Drawing.Size(889, 372);
            this.dgMemberList.TabIndex = 2;
            this.dgMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemberList_CellClick);
            // 
            // dbEntryStart
            // 
            this.dbEntryStart.BackColor = System.Drawing.Color.SeaGreen;
            this.dbEntryStart.BorderRadius = 0;
            this.dbEntryStart.ForeColor = System.Drawing.Color.White;
            this.dbEntryStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dbEntryStart.FormatCustom = null;
            this.dbEntryStart.Location = new System.Drawing.Point(325, 35);
            this.dbEntryStart.Name = "dbEntryStart";
            this.dbEntryStart.Size = new System.Drawing.Size(208, 36);
            this.dbEntryStart.TabIndex = 3;
            this.dbEntryStart.Value = new System.DateTime(2017, 11, 19, 21, 57, 52, 946);
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(578, 35);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(198, 36);
            this.bunifuDatepicker2.TabIndex = 4;
            this.bunifuDatepicker2.Value = new System.DateTime(2017, 11, 19, 21, 58, 4, 178);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLastName.BorderThickness = 3;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.isPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(13, 13);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 44);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtNic
            // 
            this.txtNic.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNic.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNic.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNic.BorderThickness = 3;
            this.txtNic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNic.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNic.isPassword = false;
            this.txtNic.Location = new System.Drawing.Point(13, 78);
            this.txtNic.Margin = new System.Windows.Forms.Padding(4);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(265, 44);
            this.txtNic.TabIndex = 6;
            this.txtNic.Text = "NIC";
            this.txtNic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNic_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Action";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NIC
            // 
            this.NIC.HeaderText = "Nic";
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            this.NIC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NIC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dob
            // 
            this.Dob.HeaderText = "Date of birth";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            this.Dob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MemberSince
            // 
            this.MemberSince.HeaderText = "Member Since";
            this.MemberSince.Name = "MemberSince";
            this.MemberSince.ReadOnly = true;
            this.MemberSince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // memberId
            // 
            this.memberId.HeaderText = "Member Id";
            this.memberId.Name = "memberId";
            this.memberId.ReadOnly = true;
            this.memberId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.memberId.ToolTipText = "Member Id";
            this.memberId.Visible = true;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 531);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.dbEntryStart);
            this.Controls.Add(this.dgMemberList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member List";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MemberList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgMemberList;
        private Bunifu.Framework.UI.BunifuDatepicker dbEntryStart;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNic;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberSince;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberId;
    }
}