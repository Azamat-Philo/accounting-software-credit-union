using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditUnionFYP.classes;
using System.Windows.Forms;

namespace CreditUnionFYP
{
    public partial class frmAddUser : Form
    {
        private ValidationClass valCal2 = new ValidationClass();

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            List<object> r = new List<object>();

            r.Add(txtFirstName);
            r.Add(txtLastName);
            r.Add(txtLogin);
            r.Add(txtPwd);
            bool result = valCal2.inputTextValidation(r);
            MessageBox.Show(result.ToString());
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
