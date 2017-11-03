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
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
        }

        private void txtMaidenName_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
        }

        private void txtNic_Leave(object sender, EventArgs e)
        {
            this.EnableGenerateAcc();
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
            string[] row = { "1", txtBenFirstName.Text.ToString(), txtBenLastName.Text.ToString(), txtBenNic.Text.ToString(), txtCommentBeneficiary.Text.ToString() };
            dataGridView1.Rows.Add(row);
            txtBenFirstName.Text = ""; txtBenLastName.Text = ""; txtBenNic.Text = ""; txtCommentBeneficiary.Text = "";
            }
        }

        private void AddColumnsBeneficiary()
        {
            DataGridViewTextBoxColumn idColumn =
                new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;

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

            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(fnameToColumn);
            dataGridView1.Columns.Add(lnameToColumn);
            dataGridView1.Columns.Add(nicToColumn);
            dataGridView1.Columns.Add(commentToColumn);
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void btnMemberDocumentAdd_Click(object sender, EventArgs e)
        {
            List<Control> bn = new List<Control>();
            TextBox txtPath=new TextBox();
            txtPath.Text = uploadDialog2.txtPathValue;

            bn.Add(txtMemberDocumentCategory);
            bn.Add(txtPath);
            LogValidationManagement.Validation h = new LogValidationManagement.Validation();
            bool result = h.inputTextValidation(bn);
            if (result)
            {
                string[] row = { "1", txtMemberDocumentCategory.Text.ToString(), txtPath.Text.ToString()};
                dataGridView3.Rows.Add(row);
                txtMemberDocumentCategory.Text = ""; uploadDialog2.txtPathValue = ""; 
            }
        }

        private void AddColumnsMemberDocument()
        {
            DataGridViewTextBoxColumn idColumn =
                new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;

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

            dataGridView3.Columns.Add(idColumn);
            dataGridView3.Columns.Add(documentNameToColumn);
            dataGridView3.Columns.Add(pathToColumn);
            dataGridView3.Columns.Add(buttonColumn);
        }
    }
}
