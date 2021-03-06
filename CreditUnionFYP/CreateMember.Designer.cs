﻿namespace CreditUnionFYP
{
    partial class CreateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMember));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbPostCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbMaritalStatus = new System.Windows.Forms.Label();
            this.dpBod = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lbNic = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.btnGenerateAccount = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 414);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lbDistrict);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lbPostCode);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lbAddress);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbPostCode
            // 
            this.lbPostCode.AutoSize = true;
            this.lbPostCode.Location = new System.Drawing.Point(24, 96);
            this.lbPostCode.Name = "lbPostCode";
            this.lbPostCode.Size = new System.Drawing.Size(62, 13);
            this.lbPostCode.TabIndex = 3;
            this.lbPostCode.Text = "Post Code :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 52);
            this.textBox1.TabIndex = 2;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(24, 40);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 13);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Address :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoCheck = false;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(161, 28);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(107, 28);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(21, 64);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 3;
            this.lbFirstName.Text = "First Name";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(21, 30);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(42, 13);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Gender";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(21, 94);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(134, 20);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.MouseLeave += new System.EventHandler(this.txtFirstName_MouseLeave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.MouseLeave += new System.EventHandler(this.txtLastName_MouseLeave);
            // 
            // lbMaritalStatus
            // 
            this.lbMaritalStatus.AutoSize = true;
            this.lbMaritalStatus.Location = new System.Drawing.Point(21, 122);
            this.lbMaritalStatus.Name = "lbMaritalStatus";
            this.lbMaritalStatus.Size = new System.Drawing.Size(71, 13);
            this.lbMaritalStatus.TabIndex = 7;
            this.lbMaritalStatus.Text = "Marital Status";
            // 
            // dpBod
            // 
            this.dpBod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBod.Location = new System.Drawing.Point(107, 155);
            this.dpBod.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dpBod.Name = "dpBod";
            this.dpBod.Size = new System.Drawing.Size(94, 20);
            this.dpBod.TabIndex = 11;
            this.dpBod.MouseLeave += new System.EventHandler(this.dpBod_MouseLeave);
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(21, 155);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lbDateOfBirth.TabIndex = 10;
            this.lbDateOfBirth.Text = "Date of birth";
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cbMaritalStatus.Location = new System.Drawing.Point(107, 122);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(79, 21);
            this.cbMaritalStatus.TabIndex = 12;
            // 
            // lbNic
            // 
            this.lbNic.AutoSize = true;
            this.lbNic.Location = new System.Drawing.Point(21, 185);
            this.lbNic.Name = "lbNic";
            this.lbNic.Size = new System.Drawing.Size(25, 13);
            this.lbNic.TabIndex = 13;
            this.lbNic.Text = "NIC";
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(107, 185);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(154, 20);
            this.txtNic.TabIndex = 14;
            this.txtNic.MouseLeave += new System.EventHandler(this.txtNic_MouseLeave);
            // 
            // btnGenerateAccount
            // 
            this.btnGenerateAccount.Location = new System.Drawing.Point(374, 25);
            this.btnGenerateAccount.Name = "btnGenerateAccount";
            this.btnGenerateAccount.Size = new System.Drawing.Size(144, 23);
            this.btnGenerateAccount.TabIndex = 15;
            this.btnGenerateAccount.Text = "Generate Acc Number";
            this.btnGenerateAccount.UseVisualStyleBackColor = true;
            this.btnGenerateAccount.Click += new System.EventHandler(this.btnGenerateAccount_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(374, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 20);
            this.textBox4.TabIndex = 16;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(475, 90);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbAccountType.TabIndex = 17;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(374, 93);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(74, 13);
            this.lbAccountType.TabIndex = 18;
            this.lbAccountType.Text = "Account Type";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lbAccountType);
            this.grpDetails.Controls.Add(this.cbAccountType);
            this.grpDetails.Controls.Add(this.textBox4);
            this.grpDetails.Controls.Add(this.btnGenerateAccount);
            this.grpDetails.Controls.Add(this.txtNic);
            this.grpDetails.Controls.Add(this.lbNic);
            this.grpDetails.Controls.Add(this.cbMaritalStatus);
            this.grpDetails.Controls.Add(this.lbDateOfBirth);
            this.grpDetails.Controls.Add(this.dpBod);
            this.grpDetails.Controls.Add(this.lbMaritalStatus);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.lbLastName);
            this.grpDetails.Controls.Add(this.lbGender);
            this.grpDetails.Controls.Add(this.lbFirstName);
            this.grpDetails.Controls.Add(this.rbMale);
            this.grpDetails.Controls.Add(this.rbFemale);
            this.grpDetails.Location = new System.Drawing.Point(6, 6);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(641, 251);
            this.grpDetails.TabIndex = 5;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Personal Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Location = new System.Drawing.Point(24, 134);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(48, 13);
            this.lbDistrict.TabIndex = 5;
            this.lbDistrict.Text = "District : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // CreateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 496);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Member";
            this.Load += new System.EventHandler(this.CreateMember_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbPostCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnGenerateAccount;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label lbNic;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.DateTimePicker dpBod;
        private System.Windows.Forms.Label lbMaritalStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.TextBox textBox2;

    }
}