namespace CreditUnionFYP
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAddPermission = new System.Windows.Forms.GroupBox();
            this.lbPermission = new System.Windows.Forms.Label();
            this.chkPermission = new System.Windows.Forms.CheckedListBox();
            this.lbForm = new System.Windows.Forms.Label();
            this.cbFormName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPermissionList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAddPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(341, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(26, 103);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(33, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(112, 100);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(151, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(26, 126);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(112, 126);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(151, 20);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(29, 159);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(26, 48);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(112, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(26, 74);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 9;
            this.lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(520, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // gbAddPermission
            // 
            this.gbAddPermission.Controls.Add(this.lbPermission);
            this.gbAddPermission.Controls.Add(this.chkPermission);
            this.gbAddPermission.Controls.Add(this.lbForm);
            this.gbAddPermission.Controls.Add(this.cbFormName);
            this.gbAddPermission.Controls.Add(this.button1);
            this.gbAddPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddPermission.Location = new System.Drawing.Point(296, 46);
            this.gbAddPermission.Name = "gbAddPermission";
            this.gbAddPermission.Size = new System.Drawing.Size(236, 167);
            this.gbAddPermission.TabIndex = 13;
            this.gbAddPermission.TabStop = false;
            this.gbAddPermission.Text = "Add Permission";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Location = new System.Drawing.Point(6, 57);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(67, 13);
            this.lbPermission.TabIndex = 7;
            this.lbPermission.Text = "Permission";
            // 
            // chkPermission
            // 
            this.chkPermission.FormattingEnabled = true;
            this.chkPermission.Location = new System.Drawing.Point(82, 53);
            this.chkPermission.Name = "chkPermission";
            this.chkPermission.Size = new System.Drawing.Size(128, 79);
            this.chkPermission.TabIndex = 6;
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Location = new System.Drawing.Point(6, 23);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(70, 13);
            this.lbForm.TabIndex = 5;
            this.lbForm.Text = "Form Name";
            // 
            // cbFormName
            // 
            this.cbFormName.FormattingEnabled = true;
            this.cbFormName.Location = new System.Drawing.Point(82, 20);
            this.cbFormName.Name = "cbFormName";
            this.cbFormName.Size = new System.Drawing.Size(130, 21);
            this.cbFormName.TabIndex = 4;
            this.cbFormName.SelectedIndexChanged += new System.EventHandler(this.cbFormName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Form Permission";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbPermissionList
            // 
            this.lbPermissionList.AutoSize = true;
            this.lbPermissionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermissionList.Location = new System.Drawing.Point(12, 224);
            this.lbPermissionList.Name = "lbPermissionList";
            this.lbPermissionList.Size = new System.Drawing.Size(111, 13);
            this.lbPermissionList.TabIndex = 14;
            this.lbPermissionList.Text = "List of permissions";
            // 
            // frmAddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(544, 441);
            this.Controls.Add(this.lbPermissionList);
            this.Controls.Add(this.gbAddPermission);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAddPermission.ResumeLayout(false);
            this.gbAddPermission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbAddPermission;
        private System.Windows.Forms.ComboBox cbFormName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPermissionList;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.CheckedListBox chkPermission;
        private System.Windows.Forms.Label lbForm;
    }
}