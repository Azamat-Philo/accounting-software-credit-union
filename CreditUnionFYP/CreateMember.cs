using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DataBase;
using System.IO;

namespace CreditUnionFYP
{
    public partial class CreateMember : Form
    {
        public Entities db = new Entities();
        public CreateMember()
        {
            InitializeComponent();
        }


        public enum MaritalStatus {

            Single=0,
            Married=1,

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class Beneficiary
        {
            public string fname;
            public string lname;
            public string nic;
        }
        public List<Beneficiary> gridBeneficiary = new List<Beneficiary>();

        private void btnGenerateAccount_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            txtAccountNumber.Text = "IMCCU-" + generator.Next(0, 1000000).ToString("D6");
        }

        private void EnableGenerateAcc() {
            try
            {
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                DateTime dob = Convert.ToDateTime(dpBod.Text);
                string mStatus = cbMaritalStatus.Text;
                string nic = txtNic.Text;

                if (fName != String.Empty && lName != String.Empty && mStatus != String.Empty && nic != String.Empty)
                {
                    if (LogValidationManagement.Validation.dateValidation(dob))
                    {
                        btnGenerateAccount.Enabled = true;
                    }
                    else
                    {
                        btnGenerateAccount.Enabled = false;
                    }
                }
                else
                {
                    btnGenerateAccount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData(MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
        }

        private void CheckValid(int gender) {
            if (gender.Equals(1))
            {
                rbMale.Checked = true; rbFemale.Checked = false;
            }
            else {
                rbFemale.Checked = true;
                rbMale.Checked = false;
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            this.CheckValid(1);
            cbMaritalStatus_SelectedValueChanged(sender,e);
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            this.CheckValid(2);
            cbMaritalStatus_SelectedValueChanged(sender, e);
        }

        private void CreateMember_Load(object sender, EventArgs e)
        {
            btnGenerateAccount.Enabled = false;
            cbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            rbMale.Checked = true;
            txtMaidenName.Visible = false;lbMaiden.Visible = false;
            lbMaritalStatus.Location = new Point(21, 122);
            cbMaritalStatus.Location = new Point(106, 122);
            lbDateOfBirth.Location = new Point(21, 153);
            dpBod.Location = new Point(107, 153);
            DateTime minDate=DateTime.Today;
            dpBod.MinDate = minDate.AddYears(-90);
            dpBod.MaxDate = DateTime.Today;
            dpoEmployement.MinDate = minDate.AddYears(-90);
            dpoEmployement.MaxDate = DateTime.Today;
            lbNic.Location = new Point(21, 186);
            txtNic.Location = new Point(107, 186);
            grpDetails.Height = 218;
            rbActive.Checked = true;
            grbBeneficiary.Enabled = false;

            this.AddColumnsBeneficiary();
            this.AddColumnsMemberDocument();
            cbCompany.DataSource = db.tblEmployers.ToList();
            cbCompany.ValueMember = "employerId";
            cbCompany.DisplayMember = "employerName";
            cbAccountType.DataSource = db.tblAccountTypes.ToList();
            cbAccountType.ValueMember = "accountTypeId";
            cbAccountType.DisplayMember = "accountTypeName";
            cbMaritalStatus.DataSource = Enum.GetNames(typeof(MaritalStatus));


        }

        private void cbMaritalStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked==true && cbMaritalStatus.SelectedItem != null && cbMaritalStatus.SelectedItem.ToString() == "Married")
            {
                txtMaidenName.Visible = true; lbMaiden.Visible = true;
                lbMaiden.Location = new Point(21, 126);
                txtMaidenName.Location = new Point(106,122);
                lbMaritalStatus.Location = new Point(21, 153);
                cbMaritalStatus.Location = new Point(107, 153);
                lbDateOfBirth.Location = new Point(21, 186);
                dpBod.Location = new Point(107, 186);
                lbNic.Location = new Point(21, 216);
                txtNic.Location = new Point(107, 216);
                grpDetails.Height = 249;
            }
            else {
                txtMaidenName.Visible = false; lbMaiden.Visible = false;
                lbMaritalStatus.Location = new Point(21, 122); 
                cbMaritalStatus.Location = new Point(106, 122); 
                lbDateOfBirth.Location = new Point(21, 153); 
                dpBod.Location = new Point(107, 153); 
                lbNic.Location = new Point(21, 186);
                txtNic.Location = new Point(107, 186);
                grpDetails.Height = 218;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
            this.EnabledPanel1();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
            this.EnabledPanel1();
        }

        private void txtMaidenName_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
            this.EnabledPanel1();
        }

        private void txtNic_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
            txtNic.Text.ToUpper();
            this.EnabledPanel1();
        }

        private void dpBod_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
        }

        private void rbActive_Click(object sender, EventArgs e)
        {
            if (rbActive.Checked)
            {
                plActive.Visible = true;
            }
            else {
                plActive.Visible = false;
            }
        }

        private void rbInactive_Click(object sender, EventArgs e)
        {
            if (!rbActive.Checked)
            {
                plActive.Visible = false;
            }
            else
            {
                plActive.Visible = true;
            }
        }

        private void btnAddBeneficiary_Click(object sender, EventArgs e)
        {
            List<Control> bn = new List<Control>();

            bn.Add(txtBenFirstName);
            bn.Add(txtBenLastName);
            bn.Add(txtBenNic);
            bn.Add(txtCommentBeneficiary);
            LogValidationManagement.Validation h = new LogValidationManagement.Validation();
            bool result = h.inputTextValidation(bn);
            if (result){ 
            string[] row = { txtBenFirstName.Text.ToString(), txtBenLastName.Text.ToString(), txtBenNic.Text.ToString(), txtCommentBeneficiary.Text.ToString() };
                bool res = gridBeneficiary.Exists(item => item.fname == txtBenFirstName.Text.ToString() && item.lname == txtBenLastName.Text.ToString() && item.nic == txtBenNic.Text.ToString());
                if (!res)
                {
                    dgBeneficiaryGrid.Rows.Add(row);
                    Beneficiary val = new Beneficiary();
                    val.fname = txtBenFirstName.Text.ToString();
                    val.lname = txtBenLastName.Text.ToString();
                    val.nic = txtBenNic.Text.ToString();
                    gridBeneficiary.Add(val);
                    txtBenFirstName.Text = ""; txtBenLastName.Text = ""; txtBenNic.Text = ""; txtCommentBeneficiary.Text = "";
                }
                else {
                    MessageBox.Show("Already added beneficiary");   
                }
                
            }
            this.EnabledPanel4();
        }

        private void AddColumnsBeneficiary()
        {

            DataGridViewTextBoxColumn fnameToColumn =
              new DataGridViewTextBoxColumn();
            fnameToColumn.Name = "FirstName";
            fnameToColumn.DataPropertyName = "fname";
            fnameToColumn.ReadOnly = true;

            DataGridViewTextBoxColumn lnameToColumn =
             new DataGridViewTextBoxColumn();
            lnameToColumn.Name = "LastName";
            lnameToColumn.DataPropertyName = "lname";
            lnameToColumn.ReadOnly = true;

            DataGridViewTextBoxColumn nicToColumn =
             new DataGridViewTextBoxColumn();
            nicToColumn.Name = "NIC";
            nicToColumn.DataPropertyName = "nic";
            nicToColumn.ReadOnly = true;

            DataGridViewTextBoxColumn commentToColumn =
             new DataGridViewTextBoxColumn();
            commentToColumn.Name = "Comment";
            commentToColumn.DataPropertyName = "comment";
            commentToColumn.ReadOnly = true;

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnRemove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;


            dgBeneficiaryGrid.Columns.Add(lnameToColumn);
            dgBeneficiaryGrid.Columns.Add(fnameToColumn);
            dgBeneficiaryGrid.Columns.Add(nicToColumn);
            dgBeneficiaryGrid.Columns.Add(commentToColumn);
            dgBeneficiaryGrid.Columns.Add(buttonColumn);
        }

        private void btnMemberDocumentAdd_Click(object sender, EventArgs e)
        {
            List<Control> bn = new List<Control>();
            TextBox txtPath=new TextBox();
            txtPath.Text = uploadDialog1.txtPathValue;

            bn.Add(cbcategoryDoc);
            bn.Add(txtPath);
            LogValidationManagement.Validation h = new LogValidationManagement.Validation();
            bool result = h.inputTextValidation(bn);
            if (result)
            {
                string[] row = { cbcategoryDoc.selectedValue.ToString(), txtPath.Text.ToString() };
                dgMemberDoc.Rows.Add(row);
                uploadDialog1.txtPathValue = "";
            }
            else {
               
            }
        }

        private void AddColumnsMemberDocument()
        {
            DataGridViewTextBoxColumn documentNameToColumn =
              new DataGridViewTextBoxColumn();
            documentNameToColumn.Name = "DocumentName";
            documentNameToColumn.DataPropertyName = "docName";
            documentNameToColumn.ReadOnly = true;

            DataGridViewTextBoxColumn pathToColumn =
             new DataGridViewTextBoxColumn();
            pathToColumn.Name = "Path";
            pathToColumn.DataPropertyName = "path";
            pathToColumn.ReadOnly = true;

           

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnRemove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;

            dgMemberDoc.Columns.Add(documentNameToColumn);
            dgMemberDoc.Columns.Add(pathToColumn);
            dgMemberDoc.Columns.Add(buttonColumn);
        }
        private void EnabledPanel1() {
            List<Control> r = new List<Control>();

            r.Add(txtFirstName);
            r.Add(txtLastName);
            r.Add(txtNic);
            r.Add(cbMaritalStatus);
            if (rbFemale.Checked == true) {
                r.Add(txtMaidenName);
            }
            r.Add(txtAccountNumber);
            r.Add(txtShares);
            LogValidationManagement.Validation h = new LogValidationManagement.Validation();
            bool result = h.inputTextValidation(r);
            grpAddress.Enabled = result==true ? true : false;
            if(result ==false) SetBorderError(r);
        }

        public void SetBorderError(List<Control> g) {
            foreach (Control t in g)
            {
                t.ForeColor = Color.LightPink;
            }
        }

        private void EnabledPanel2()
        {
            List<Control> r = new List<Control>();

            r.Add(txtAddress);
            r.Add(txtPostCode);
            r.Add(cbDistrict);
            LogValidationManagement.Validation h = new LogValidationManagement.Validation();
            bool result = h.inputTextValidation(r);
            grpEmployer.Enabled = result == true ? true : false;
        }
        private void EnabledPanel3()
        {
            List<RadioButton> r = new List<RadioButton>();

            r.Add(rbActive);
            r.Add(rbInactive);
            bool result = LogValidationManagement.Validation.rbButtonCheck(r);
            grbBeneficiary.Enabled = result == true ? true : false;
        }

        private void EnabledPanel4()
        {
            DataGridViewRow tr = new DataGridViewRow();
            if (dgBeneficiaryGrid.Rows.Count > 0)
            { 
                grpMemberDocument.Enabled = true;
            }
            else {
                grpMemberDocument.Enabled = false;
            }
           
        }

        private void txtAccountNumber_Leave(object sender, EventArgs e)
        {
            this.EnabledPanel1();
        }

        private void txtShares_Leave(object sender, EventArgs e)
        {
            this.EnabledPanel1();
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            this.EnabledPanel2();
        }

        private void txtPostCode_Leave(object sender, EventArgs e)
        {
            this.EnabledPanel2();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            this.EnabledPanel2();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            this.EnabledPanel3();
        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            this.EnabledPanel3();
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            Entities db = new Entities();
            var result = (from p in db.tblAccounts
                          where p.accountRef == txtAccountNumber.Text.ToString()
                          select p);
            if (result.Count() > 0) {
                MessageBox.Show("Already in use. A new number will generate.");
                btnGenerateAccount_Click(sender, e);
            }
        }

        private void dgBeneficiaryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgBeneficiaryGrid.Columns["btnRemove"].Index)
            {

                int selectedrowindex = dgBeneficiaryGrid.SelectedCells[0].RowIndex;

                dgBeneficiaryGrid.Rows.RemoveAt(selectedrowindex);
                gridBeneficiary.RemoveAt(selectedrowindex);
            }
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            int t = 0;
            Entities db = new Entities();
            tblMember m = new tblMember();
            if (rbFemale.Checked)
            {
                m.gender = 1;
            }
            else { m.gender = 2; }
            m.firstName = txtFirstName.Text.ToString();
            m.lastName = txtLastName.Text.ToString();
            m.maidenName = txtMaidenName.Text.ToString();
            m.maritalStatus = Convert.ToByte(cbMaritalStatus.SelectedValue);
            m.dateOfBirth = Convert.ToDateTime(dpBod.Text);
            m.nic = txtNic.Text.ToString();
            m.paidEntry = chkPayEntryFee.Checked ? true : false;
            m.createdDate = DateTime.Now;
            m.entryDate = DateTime.Now;
            if (rbActive.Checked)
            {m.activePopulation = true;}
            else { m.activePopulation = false;}
            db.tblMembers.Add(m);
            db.SaveChanges();
            t = m.memberId;

            tblMemberAddress maddress = new tblMemberAddress();

            maddress.memberId = t;
            maddress.postCode = txtPostCode.Text.ToString();
            maddress.district = cbDistrict.SelectedText.ToString();
            maddress.active = true;
            maddress.dateCreated = DateTime.Now;

            db.tblMemberAddresses.Add(maddress);
            db.SaveChanges();

            foreach (DataGridViewRow row in dgBeneficiaryGrid.Rows)
            {
                string fname = Convert.ToString(row.Cells["FirstName"].Value);
                string lname = Convert.ToString(row.Cells["LastName"].Value);
                string nic = Convert.ToString(row.Cells["NIC"].Value);
                string comment = Convert.ToString(row.Cells["Comment"].Value);
                tblBeneficiary mBeneficiary = new tblBeneficiary();
                mBeneficiary.firstName = fname;
                mBeneficiary.lastName = lname;
                mBeneficiary.nic = nic;
                mBeneficiary.comments = comment;
                mBeneficiary.memberId = t;
                db.tblBeneficiaries.Add(mBeneficiary);
                db.SaveChanges();
            }

            foreach (DataGridViewRow row in dgMemberDoc.Rows)
            {
                string docName = Convert.ToString(row.Cells["DocumentName"].Value);
                string path = Convert.ToString(row.Cells["Path"].Value);
                tblMemberDoc mDoc = new tblMemberDoc();
                mDoc.documentCategory = docName;
                mDoc.memberDocument = StoreFileInDB(path);
                mDoc.addedDate = DateTime.Now;
                mDoc.memberId = t;
                db.tblMemberDocs.Add(mDoc);
                db.SaveChanges();
            }

            tblAccount acc = new tblAccount();

            acc.accountRef = txtAccountNumber.Text;
            acc.amount = Convert.ToInt32(txtShares.Text);
            acc.accountTypeId = Convert.ToInt32(cbAccountType.SelectedValue);
            acc.dateAccountOpened = DateTime.Now;
            db.tblAccounts.Add(acc);
            db.SaveChanges();
            int accId = acc.accountId;

            tblAccountMember accmem = new tblAccountMember();
            accmem.accountId = accId;
            accmem.memberId = t;
            db.tblAccountMembers.Add(accmem);
            db.SaveChanges();

            MessageBox.Show("Member created successfully");

            MemberList frmMember = new MemberList();
            this.Close();
            frmMember.Show();




        }

        public Byte[] StoreFileInDB(string path) {
            // Read the file and convert it to Byte Array
            string filename = Path.GetFileName(path);
            string ext = Path.GetExtension(filename);
            string contenttype = String.Empty;
            Byte[] bytes=null;

            //Set the contenttype based on File Extension
            switch (ext)
            {
                case ".doc":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".docx":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".xls":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".xlsx":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".jpg":
                    contenttype = "image/jpg";
                    break;
                case ".png":
                    contenttype = "image/png";
                    break;
                case ".gif":
                    contenttype = "image/gif";
                    break;
                case ".pdf":
                    contenttype = "application/pdf";
                    break;
            }
            if (contenttype != String.Empty)
            {
                /*Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                br.ReadBytes((Int32)fs.Length);*/
                bytes = File.ReadAllBytes(path);   
            }

            return bytes;
        }

        private void txtShares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            else {
                txtShares.ForeColor = Color.LightPink;
            }
        }

        private void dgMemberDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMemberDoc.Columns["btnRemove"].Index)
            {

                int selectedrowindex = dgMemberDoc.SelectedCells[0].RowIndex;

                dgMemberDoc.Rows.RemoveAt(selectedrowindex);
            }
        }
    }
}
