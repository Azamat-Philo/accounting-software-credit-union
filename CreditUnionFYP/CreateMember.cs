using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class CreateMember : Form
    {
        public CreateMember()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                LogValidationManagement.LogFile.LogData("", ex.ToString(), 0);
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
            dpoEmployement.MaxDate = DateTime.Today;
            lbNic.Location = new Point(21, 186);
            txtNic.Location = new Point(107, 186);
            grpDetails.Height = 218;
            rbActive.Checked = true;

            this.AddColumnsBeneficiary();
            this.AddColumnsMemberDocument();
            //bunifuGauge1.Value = 20;
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
                dgBeneficiaryGrid.Rows.Add(row);
            txtBenFirstName.Text = ""; txtBenLastName.Text = ""; txtBenNic.Text = ""; txtCommentBeneficiary.Text = "";
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
            buttonColumn.Name = "btnMove";
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
                string[] row = { cbcategoryDoc.Text.ToString(), txtPath.Text.ToString() };
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
            buttonColumn.Name = "btnMove";
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
            r.Add(comboBox1);
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

        }
    }
}
