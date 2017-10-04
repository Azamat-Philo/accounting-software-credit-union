using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditUnionFYP.classes;

namespace CreditUnionFYP
{
    public partial class CreateMember : Form
    {
        private ValidationClass valCal = new ValidationClass();
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
                    if (valCal.dateValidation(dob))
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
                LogFile.LogData("", ex.ToString(), 0);
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
            CheckValid(1);
            cbMaritalStatus_SelectedValueChanged(sender,e);
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            CheckValid(2);
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
        }

        private void cbMaritalStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked==true && cbMaritalStatus.SelectedItem.ToString()=="Married")
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
            EnableGenerateAcc();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }

        private void txtMaidenName_Leave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }

        private void txtNic_Leave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }

        private void dpBod_Leave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }
    }
}
