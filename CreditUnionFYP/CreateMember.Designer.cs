namespace Common
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
            this.grpEmployer = new System.Windows.Forms.GroupBox();
            this.plActive = new System.Windows.Forms.Panel();
            this.dpoEmployement = new System.Windows.Forms.DateTimePicker();
            this.lbEntryDate = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.lbCompany = new System.Windows.Forms.Label();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lbPostCode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.lbShare = new System.Windows.Forms.Label();
            this.chkPayEntryFee = new System.Windows.Forms.CheckBox();
            this.txtMaidenName = new System.Windows.Forms.TextBox();
            this.lbMaiden = new System.Windows.Forms.Label();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnGenerateAccount = new System.Windows.Forms.Button();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.lbNic = new System.Windows.Forms.Label();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.dpBod = new System.Windows.Forms.DateTimePicker();
            this.lbMaritalStatus = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpMemberDocument = new System.Windows.Forms.GroupBox();
            this.cbcategoryDoc = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnMemberDocumentAdd = new System.Windows.Forms.Button();
            this.dgMemberDoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBeneficiary = new System.Windows.Forms.GroupBox();
            this.dgBeneficiaryGrid = new System.Windows.Forms.DataGridView();
            this.btnAddBeneficiary = new System.Windows.Forms.Button();
            this.txtCommentBeneficiary = new System.Windows.Forms.TextBox();
            this.lbCommentBeneficiary = new System.Windows.Forms.Label();
            this.txtBenNic = new System.Windows.Forms.TextBox();
            this.lbBenNic = new System.Windows.Forms.Label();
            this.txtBenLastName = new System.Windows.Forms.TextBox();
            this.lbBenLastName = new System.Windows.Forms.Label();
            this.lbBenFirstName = new System.Windows.Forms.Label();
            this.txtBenFirstName = new System.Windows.Forms.TextBox();
            this.lbDocumentCategory = new System.Windows.Forms.Label();
            this.txtDocumentCategory = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uploadDialog1 = new Common.usercontrol.UploadDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEmployer.SuspendLayout();
            this.plActive.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpMemberDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberDoc)).BeginInit();
            this.grbBeneficiary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeneficiaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 514);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.grpEmployer);
            this.tabPage1.Controls.Add(this.grpAddress);
            this.tabPage1.Controls.Add(this.grpDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1 ";
            // 
            // grpEmployer
            // 
            this.grpEmployer.Controls.Add(this.plActive);
            this.grpEmployer.Controls.Add(this.rbInactive);
            this.grpEmployer.Controls.Add(this.rbActive);
            this.grpEmployer.Controls.Add(this.label1);
            this.grpEmployer.Enabled = false;
            this.grpEmployer.Location = new System.Drawing.Point(7, 360);
            this.grpEmployer.Name = "grpEmployer";
            this.grpEmployer.Size = new System.Drawing.Size(668, 122);
            this.grpEmployer.TabIndex = 7;
            this.grpEmployer.TabStop = false;
            this.grpEmployer.Text = "Employment Details";
            // 
            // plActive
            // 
            this.plActive.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.plActive.Controls.Add(this.dpoEmployement);
            this.plActive.Controls.Add(this.lbEntryDate);
            this.plActive.Controls.Add(this.cbCompany);
            this.plActive.Controls.Add(this.lbCompany);
            this.plActive.Location = new System.Drawing.Point(239, 19);
            this.plActive.Name = "plActive";
            this.plActive.Size = new System.Drawing.Size(423, 97);
            this.plActive.TabIndex = 3;
            // 
            // dpoEmployement
            // 
            this.dpoEmployement.Location = new System.Drawing.Point(115, 36);
            this.dpoEmployement.Name = "dpoEmployement";
            this.dpoEmployement.Size = new System.Drawing.Size(163, 22);
            this.dpoEmployement.TabIndex = 3;
            // 
            // lbEntryDate
            // 
            this.lbEntryDate.AutoSize = true;
            this.lbEntryDate.Location = new System.Drawing.Point(14, 42);
            this.lbEntryDate.Name = "lbEntryDate";
            this.lbEntryDate.Size = new System.Drawing.Size(62, 13);
            this.lbEntryDate.TabIndex = 2;
            this.lbEntryDate.Text = "Entry Date:";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(115, 8);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(163, 21);
            this.cbCompany.TabIndex = 1;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(14, 10);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(91, 13);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "Company Name:";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(160, 27);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 2;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            this.rbInactive.Click += new System.EventHandler(this.rbInactive_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(100, 27);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 1;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            this.rbActive.Click += new System.EventHandler(this.rbActive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.cbDistrict);
            this.grpAddress.Controls.Add(this.lbDistrict);
            this.grpAddress.Controls.Add(this.txtPostCode);
            this.grpAddress.Controls.Add(this.lbPostCode);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this.lbAddress);
            this.grpAddress.Enabled = false;
            this.grpAddress.Location = new System.Drawing.Point(7, 261);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(668, 92);
            this.grpAddress.TabIndex = 6;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // cbDistrict
            // 
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Items.AddRange(new object[] {
            "Agalega",
            "Black River",
            "Flacq",
            "Grand Port",
            "Moka",
            "Pamplemousses",
            "Plaines Wilhems",
            "Port Louis",
            "Rivière du Rempart",
            "Rodrigues",
            "Savannah"});
            this.cbDistrict.Location = new System.Drawing.Point(442, 50);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(188, 21);
            this.cbDistrict.TabIndex = 12;
            this.cbDistrict.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Location = new System.Drawing.Point(370, 50);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(53, 13);
            this.lbDistrict.TabIndex = 11;
            this.lbDistrict.Text = "District : ";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(442, 19);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(188, 22);
            this.txtPostCode.TabIndex = 10;
            this.txtPostCode.Leave += new System.EventHandler(this.txtPostCode_Leave);
            // 
            // lbPostCode
            // 
            this.lbPostCode.AutoSize = true;
            this.lbPostCode.Location = new System.Drawing.Point(370, 22);
            this.lbPostCode.Name = "lbPostCode";
            this.lbPostCode.Size = new System.Drawing.Size(66, 13);
            this.lbPostCode.TabIndex = 9;
            this.lbPostCode.Text = "Post Code :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 19);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 52);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(20, 37);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(54, 13);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Address :";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtShares);
            this.grpDetails.Controls.Add(this.lbShare);
            this.grpDetails.Controls.Add(this.chkPayEntryFee);
            this.grpDetails.Controls.Add(this.txtMaidenName);
            this.grpDetails.Controls.Add(this.lbMaiden);
            this.grpDetails.Controls.Add(this.lbAccountType);
            this.grpDetails.Controls.Add(this.cbAccountType);
            this.grpDetails.Controls.Add(this.txtAccountNumber);
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
            this.grpDetails.Size = new System.Drawing.Size(669, 249);
            this.grpDetails.TabIndex = 5;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Personal Details";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(426, 155);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(100, 22);
            this.txtShares.TabIndex = 24;
            this.txtShares.Text = "200";
            this.txtShares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShares_KeyPress);
            this.txtShares.Leave += new System.EventHandler(this.txtShares_Leave);
            // 
            // lbShare
            // 
            this.lbShare.AutoSize = true;
            this.lbShare.Location = new System.Drawing.Point(377, 158);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(42, 13);
            this.lbShare.TabIndex = 23;
            this.lbShare.Text = "Shares:";
            // 
            // chkPayEntryFee
            // 
            this.chkPayEntryFee.AutoSize = true;
            this.chkPayEntryFee.Location = new System.Drawing.Point(377, 126);
            this.chkPayEntryFee.Name = "chkPayEntryFee";
            this.chkPayEntryFee.Size = new System.Drawing.Size(93, 17);
            this.chkPayEntryFee.TabIndex = 22;
            this.chkPayEntryFee.Text = "Pay Entry Fee";
            this.chkPayEntryFee.UseVisualStyleBackColor = true;
            // 
            // txtMaidenName
            // 
            this.txtMaidenName.Location = new System.Drawing.Point(107, 122);
            this.txtMaidenName.Name = "txtMaidenName";
            this.txtMaidenName.Size = new System.Drawing.Size(134, 22);
            this.txtMaidenName.TabIndex = 20;
            this.txtMaidenName.Leave += new System.EventHandler(this.txtMaidenName_Leave);
            // 
            // lbMaiden
            // 
            this.lbMaiden.AutoSize = true;
            this.lbMaiden.Location = new System.Drawing.Point(21, 126);
            this.lbMaiden.Name = "lbMaiden";
            this.lbMaiden.Size = new System.Drawing.Size(81, 13);
            this.lbMaiden.TabIndex = 19;
            this.lbMaiden.Text = "Maiden Name:";
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(374, 93);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(77, 13);
            this.lbAccountType.TabIndex = 18;
            this.lbAccountType.Text = "Account Type:";
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(475, 90);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbAccountType.TabIndex = 17;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(374, 57);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(222, 22);
            this.txtAccountNumber.TabIndex = 16;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            this.txtAccountNumber.Leave += new System.EventHandler(this.txtAccountNumber_Leave);
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
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(107, 216);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(154, 22);
            this.txtNic.TabIndex = 14;
            this.txtNic.Leave += new System.EventHandler(this.txtNic_Leave);
            // 
            // lbNic
            // 
            this.lbNic.AutoSize = true;
            this.lbNic.Location = new System.Drawing.Point(21, 216);
            this.lbNic.Name = "lbNic";
            this.lbNic.Size = new System.Drawing.Size(27, 13);
            this.lbNic.TabIndex = 13;
            this.lbNic.Text = "NIC:";
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cbMaritalStatus.Location = new System.Drawing.Point(107, 151);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(79, 21);
            this.cbMaritalStatus.TabIndex = 12;
            this.cbMaritalStatus.SelectedValueChanged += new System.EventHandler(this.cbMaritalStatus_SelectedValueChanged);
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(21, 186);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(75, 13);
            this.lbDateOfBirth.TabIndex = 10;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // dpBod
            // 
            this.dpBod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBod.Location = new System.Drawing.Point(107, 186);
            this.dpBod.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dpBod.Name = "dpBod";
            this.dpBod.Size = new System.Drawing.Size(94, 22);
            this.dpBod.TabIndex = 11;
            this.dpBod.Leave += new System.EventHandler(this.dpBod_Leave);
            // 
            // lbMaritalStatus
            // 
            this.lbMaritalStatus.AutoSize = true;
            this.lbMaritalStatus.Location = new System.Drawing.Point(21, 153);
            this.lbMaritalStatus.Name = "lbMaritalStatus";
            this.lbMaritalStatus.Size = new System.Drawing.Size(80, 13);
            this.lbMaritalStatus.TabIndex = 7;
            this.lbMaritalStatus.Text = "Marital Status:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 22);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(134, 22);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(21, 94);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(63, 13);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(21, 30);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(46, 13);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Gender:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(21, 64);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(64, 13);
            this.lbFirstName.TabIndex = 3;
            this.lbFirstName.Text = "First Name:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(107, 28);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 17);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoCheck = false;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(161, 28);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 17);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.grpMemberDocument);
            this.tabPage2.Controls.Add(this.grbBeneficiary);
            this.tabPage2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2 ";
            // 
            // grpMemberDocument
            // 
            this.grpMemberDocument.Controls.Add(this.cbcategoryDoc);
            this.grpMemberDocument.Controls.Add(this.uploadDialog1);
            this.grpMemberDocument.Controls.Add(this.btnMemberDocumentAdd);
            this.grpMemberDocument.Controls.Add(this.dgMemberDoc);
            this.grpMemberDocument.Controls.Add(this.label2);
            this.grpMemberDocument.Enabled = false;
            this.grpMemberDocument.Location = new System.Drawing.Point(7, 282);
            this.grpMemberDocument.Name = "grpMemberDocument";
            this.grpMemberDocument.Size = new System.Drawing.Size(648, 200);
            this.grpMemberDocument.TabIndex = 2;
            this.grpMemberDocument.TabStop = false;
            this.grpMemberDocument.Text = "Member Document";
            // 
            // cbcategoryDoc
            // 
            this.cbcategoryDoc.BackColor = System.Drawing.Color.Transparent;
            this.cbcategoryDoc.BorderRadius = 3;
            this.cbcategoryDoc.DisabledColor = System.Drawing.Color.Gray;
            this.cbcategoryDoc.ForeColor = System.Drawing.Color.Black;
            this.cbcategoryDoc.Items = new string[] {
        "Birth Certificate",
        "Nic",
        "Death Certificate",
        "CEB Bill",
        "Telecom Bill",
        "CWA Bill",
        "Bank Statement"};
            this.cbcategoryDoc.Location = new System.Drawing.Point(92, 37);
            this.cbcategoryDoc.Name = "cbcategoryDoc";
            this.cbcategoryDoc.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbcategoryDoc.onHoverColor = System.Drawing.Color.LightSteelBlue;
            this.cbcategoryDoc.selectedIndex = -1;
            this.cbcategoryDoc.Size = new System.Drawing.Size(136, 23);
            this.cbcategoryDoc.TabIndex = 6;
            // 
            // btnMemberDocumentAdd
            // 
            this.btnMemberDocumentAdd.Location = new System.Drawing.Point(245, 37);
            this.btnMemberDocumentAdd.Name = "btnMemberDocumentAdd";
            this.btnMemberDocumentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMemberDocumentAdd.TabIndex = 4;
            this.btnMemberDocumentAdd.Text = "Add";
            this.btnMemberDocumentAdd.UseVisualStyleBackColor = true;
            this.btnMemberDocumentAdd.Click += new System.EventHandler(this.btnMemberDocumentAdd_Click);
            // 
            // dgMemberDoc
            // 
            this.dgMemberDoc.AllowUserToAddRows = false;
            this.dgMemberDoc.AllowUserToDeleteRows = false;
            this.dgMemberDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberDoc.Location = new System.Drawing.Point(6, 80);
            this.dgMemberDoc.Name = "dgMemberDoc";
            this.dgMemberDoc.ReadOnly = true;
            this.dgMemberDoc.Size = new System.Drawing.Size(637, 114);
            this.dgMemberDoc.TabIndex = 3;
            this.dgMemberDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemberDoc_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name:";
            // 
            // grbBeneficiary
            // 
            this.grbBeneficiary.Controls.Add(this.dgBeneficiaryGrid);
            this.grbBeneficiary.Controls.Add(this.btnAddBeneficiary);
            this.grbBeneficiary.Controls.Add(this.txtCommentBeneficiary);
            this.grbBeneficiary.Controls.Add(this.lbCommentBeneficiary);
            this.grbBeneficiary.Controls.Add(this.txtBenNic);
            this.grbBeneficiary.Controls.Add(this.lbBenNic);
            this.grbBeneficiary.Controls.Add(this.txtBenLastName);
            this.grbBeneficiary.Controls.Add(this.lbBenLastName);
            this.grbBeneficiary.Controls.Add(this.lbBenFirstName);
            this.grbBeneficiary.Controls.Add(this.txtBenFirstName);
            this.grbBeneficiary.Enabled = false;
            this.grbBeneficiary.Location = new System.Drawing.Point(6, 6);
            this.grbBeneficiary.Name = "grbBeneficiary";
            this.grbBeneficiary.Size = new System.Drawing.Size(649, 270);
            this.grbBeneficiary.TabIndex = 0;
            this.grbBeneficiary.TabStop = false;
            this.grbBeneficiary.Text = "Beneficiary Details";
            // 
            // dgBeneficiaryGrid
            // 
            this.dgBeneficiaryGrid.AllowUserToAddRows = false;
            this.dgBeneficiaryGrid.AllowUserToDeleteRows = false;
            this.dgBeneficiaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBeneficiaryGrid.Location = new System.Drawing.Point(29, 146);
            this.dgBeneficiaryGrid.Name = "dgBeneficiaryGrid";
            this.dgBeneficiaryGrid.ReadOnly = true;
            this.dgBeneficiaryGrid.Size = new System.Drawing.Size(601, 118);
            this.dgBeneficiaryGrid.TabIndex = 10;
            this.dgBeneficiaryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBeneficiaryGrid_CellClick);
            // 
            // btnAddBeneficiary
            // 
            this.btnAddBeneficiary.Location = new System.Drawing.Point(32, 116);
            this.btnAddBeneficiary.Name = "btnAddBeneficiary";
            this.btnAddBeneficiary.Size = new System.Drawing.Size(75, 23);
            this.btnAddBeneficiary.TabIndex = 9;
            this.btnAddBeneficiary.Text = "Add";
            this.btnAddBeneficiary.UseVisualStyleBackColor = true;
            this.btnAddBeneficiary.Click += new System.EventHandler(this.btnAddBeneficiary_Click);
            // 
            // txtCommentBeneficiary
            // 
            this.txtCommentBeneficiary.Location = new System.Drawing.Point(366, 27);
            this.txtCommentBeneficiary.Multiline = true;
            this.txtCommentBeneficiary.Name = "txtCommentBeneficiary";
            this.txtCommentBeneficiary.Size = new System.Drawing.Size(239, 78);
            this.txtCommentBeneficiary.TabIndex = 8;
            // 
            // lbCommentBeneficiary
            // 
            this.lbCommentBeneficiary.AutoSize = true;
            this.lbCommentBeneficiary.Location = new System.Drawing.Point(286, 57);
            this.lbCommentBeneficiary.Name = "lbCommentBeneficiary";
            this.lbCommentBeneficiary.Size = new System.Drawing.Size(61, 13);
            this.lbCommentBeneficiary.TabIndex = 7;
            this.lbCommentBeneficiary.Text = "Comments:";
            // 
            // txtBenNic
            // 
            this.txtBenNic.Location = new System.Drawing.Point(106, 85);
            this.txtBenNic.Name = "txtBenNic";
            this.txtBenNic.Size = new System.Drawing.Size(155, 22);
            this.txtBenNic.TabIndex = 6;
            // 
            // lbBenNic
            // 
            this.lbBenNic.AutoSize = true;
            this.lbBenNic.Location = new System.Drawing.Point(25, 88);
            this.lbBenNic.Name = "lbBenNic";
            this.lbBenNic.Size = new System.Drawing.Size(27, 13);
            this.lbBenNic.TabIndex = 5;
            this.lbBenNic.Text = "NIC:";
            // 
            // txtBenLastName
            // 
            this.txtBenLastName.Location = new System.Drawing.Point(106, 57);
            this.txtBenLastName.Name = "txtBenLastName";
            this.txtBenLastName.Size = new System.Drawing.Size(155, 22);
            this.txtBenLastName.TabIndex = 3;
            // 
            // lbBenLastName
            // 
            this.lbBenLastName.AutoSize = true;
            this.lbBenLastName.Location = new System.Drawing.Point(25, 60);
            this.lbBenLastName.Name = "lbBenLastName";
            this.lbBenLastName.Size = new System.Drawing.Size(61, 13);
            this.lbBenLastName.TabIndex = 2;
            this.lbBenLastName.Text = "Last Name:";
            // 
            // lbBenFirstName
            // 
            this.lbBenFirstName.AutoSize = true;
            this.lbBenFirstName.Location = new System.Drawing.Point(26, 30);
            this.lbBenFirstName.Name = "lbBenFirstName";
            this.lbBenFirstName.Size = new System.Drawing.Size(61, 13);
            this.lbBenFirstName.TabIndex = 1;
            this.lbBenFirstName.Text = "First Name:";
            // 
            // txtBenFirstName
            // 
            this.txtBenFirstName.Location = new System.Drawing.Point(106, 27);
            this.txtBenFirstName.Name = "txtBenFirstName";
            this.txtBenFirstName.Size = new System.Drawing.Size(155, 22);
            this.txtBenFirstName.TabIndex = 0;
            // 
            // lbDocumentCategory
            // 
            this.lbDocumentCategory.AutoSize = true;
            this.lbDocumentCategory.Location = new System.Drawing.Point(28, 47);
            this.lbDocumentCategory.Name = "lbDocumentCategory";
            this.lbDocumentCategory.Size = new System.Drawing.Size(35, 13);
            this.lbDocumentCategory.TabIndex = 5;
            this.lbDocumentCategory.Text = "label2";
            // 
            // txtDocumentCategory
            // 
            this.txtDocumentCategory.Location = new System.Drawing.Point(83, 42);
            this.txtDocumentCategory.Name = "txtDocumentCategory";
            this.txtDocumentCategory.Size = new System.Drawing.Size(130, 20);
            this.txtDocumentCategory.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(219, 42);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Add";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 52);
            this.textBox1.TabIndex = 8;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreateMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateMember.BorderRadius = 0;
            this.btnCreateMember.ButtonText = "Create";
            this.btnCreateMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateMember.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreateMember.Iconimage")));
            this.btnCreateMember.Iconimage_right = null;
            this.btnCreateMember.Iconimage_right_Selected = null;
            this.btnCreateMember.Iconimage_Selected = null;
            this.btnCreateMember.IconMarginLeft = 0;
            this.btnCreateMember.IconMarginRight = 0;
            this.btnCreateMember.IconRightVisible = true;
            this.btnCreateMember.IconRightZoom = 0D;
            this.btnCreateMember.IconVisible = true;
            this.btnCreateMember.IconZoom = 90D;
            this.btnCreateMember.IsTab = false;
            this.btnCreateMember.Location = new System.Drawing.Point(543, 532);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreateMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCreateMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreateMember.selected = false;
            this.btnCreateMember.Size = new System.Drawing.Size(157, 48);
            this.btnCreateMember.TabIndex = 6;
            this.btnCreateMember.Text = "Create";
            this.btnCreateMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateMember.Textcolor = System.Drawing.Color.White;
            this.btnCreateMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            // 
            // Nic
            // 
            this.Nic.HeaderText = "Nic";
            this.Nic.Name = "Nic";
            this.Nic.ReadOnly = true;
            this.Nic.Visible = false;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.HeaderText = "Action";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ReadOnly = true;
            this.btnRemove.Text = "Remove";
            this.btnRemove.ToolTipText = "Remove";
            this.btnRemove.Visible = false;
            // 
            // uploadDialog1
            // 
            this.uploadDialog1.Location = new System.Drawing.Point(315, 19);
            this.uploadDialog1.Name = "uploadDialog1";
            this.uploadDialog1.Size = new System.Drawing.Size(327, 56);
            this.uploadDialog1.TabIndex = 5;
            this.uploadDialog1.txtPathValue = "";
            // 
            // CreateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 585);
            this.Controls.Add(this.btnCreateMember);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Member";
            this.Load += new System.EventHandler(this.CreateMember_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEmployer.ResumeLayout(false);
            this.grpEmployer.PerformLayout();
            this.plActive.ResumeLayout(false);
            this.plActive.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpMemberDocument.ResumeLayout(false);
            this.grpMemberDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberDoc)).EndInit();
            this.grbBeneficiary.ResumeLayout(false);
            this.grbBeneficiary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeneficiaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.TextBox txtAccountNumber;
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
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtMaidenName;
        private System.Windows.Forms.Label lbMaiden;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lbPostCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.GroupBox grpEmployer;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plActive;
        private System.Windows.Forms.DateTimePicker dpoEmployement;
        private System.Windows.Forms.Label lbEntryDate;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbBeneficiary;
        private System.Windows.Forms.TextBox txtBenLastName;
        private System.Windows.Forms.Label lbBenLastName;
        private System.Windows.Forms.Label lbBenFirstName;
        private System.Windows.Forms.TextBox txtBenFirstName;
        private System.Windows.Forms.TextBox txtBenNic;
        private System.Windows.Forms.Label lbBenNic;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.Label lbShare;
        private System.Windows.Forms.CheckBox chkPayEntryFee;
        private System.Windows.Forms.GroupBox grpMemberDocument;
        private System.Windows.Forms.TextBox txtDocumentCategory;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAddBeneficiary;
        private System.Windows.Forms.TextBox txtCommentBeneficiary;
        private System.Windows.Forms.Label lbCommentBeneficiary;
        private System.Windows.Forms.Label lbDocumentCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMemberDocumentAdd;
        private System.Windows.Forms.DataGridView dgMemberDoc;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
        private System.Windows.Forms.DataGridView dgBeneficiaryGrid;
        private usercontrol.UploadDialog uploadDialog1;
        private Bunifu.Framework.UI.BunifuDropdown cbcategoryDoc;
    }
}