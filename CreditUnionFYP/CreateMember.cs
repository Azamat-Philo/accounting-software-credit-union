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

        private void txtNic_MouseLeave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
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
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            CheckValid(2);
        }

        private void CreateMember_Load(object sender, EventArgs e)
        {
            btnGenerateAccount.Enabled = false;
            cbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            rbMale.Checked = true;
        }

        private void txtFirstName_MouseLeave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }

        private void txtLastName_MouseLeave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }

        private void dpBod_MouseLeave(object sender, EventArgs e)
        {
            EnableGenerateAcc();
        }
    }
}
