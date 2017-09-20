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
            DBClass.DBConnect();
            SqlCommand drCommand = null;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            drCommand = new SqlCommand("SELECT * FROM tblForm where active=1", DBClass.connection);
            da.SelectCommand = drCommand;
            da.Fill(ds);
            cbFormName.DataSource = ds.Tables[0];
            cbFormName.ValueMember = "formId";
            cbFormName.DisplayMember = "formName";
        }

       

        private void cbFormName_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbFormName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormName.SelectedIndex != 0)
            {
                DBClass.DBConnect();
                SqlCommand drCommand = null;
                DataTable dt = new DataTable();
                drCommand = new SqlCommand("SELECT * FROM tblPermission where formId=" + cbFormName.SelectedValue.ToString() + " and active=1 and uDelete=0", DBClass.connection);
                SqlDataAdapter da = new SqlDataAdapter(drCommand);
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chkPermission.Items.Add(dt.Rows[i]["permissionName"].ToString());

                }
            }
        }
    }
}
