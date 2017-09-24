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
using System.Data.SqlClient;

namespace CreditUnionFYP
{
    public partial class frmAddUser : Form
    {
        private ValidationClass valCal2 = new ValidationClass();
        DBClass r = new DBClass();

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
            this.cbFormName.SelectedValueChanged -= new System.EventHandler(this.cbFormName_SelectedValueChanged);
            DBClass.DBConnect();
            SqlCommand drCommand = null;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable ds = new DataTable();
            drCommand = new SqlCommand("SELECT * FROM tblForm where active=1", DBClass.connection);
            da.SelectCommand = drCommand;
            da.Fill(ds);

            cbFormName.DataSource = ds;
            cbFormName.ValueMember = "formId";
            cbFormName.DisplayMember = "formName";
            this.cbFormName.SelectedValueChanged += new System.EventHandler(this.cbFormName_SelectedValueChanged);

        }

       

        private void cbFormName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFormName.SelectedIndex != -1) {
                DBClass.DBConnect();
                SqlCommand drCommand = null;
                drCommand = new SqlCommand("SELECT * FROM tblPermission where formId="+ cbFormName.SelectedValue + " and active=1 and uDelete=0", DBClass.connection);
                SqlDataAdapter da = new SqlDataAdapter(drCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                chkPermission.DataSource = ds.Tables[0];
                chkPermission.DisplayMember = "permissionName";
                chkPermission.ValueMember = "permissionId";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            List<object> s = new List<object>();
            string fName = null, lName = null;
            s.Add(txtFirstName);
            s.Add(txtLastName);
            bool result = valCal2.inputTextValidation(s);
            if (result == true){
                fName= txtFirstName.Text.ToString();
                lName = txtLastName.Text.ToString();
                lName.ToLower();
                string a = ValidationClass.validChar;
            }
           
        }
    }
}
