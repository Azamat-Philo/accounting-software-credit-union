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
            this.AddColumns();
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
            try
            {
                s.Add(txtFirstName);
                s.Add(txtLastName);
                bool result = valCal2.inputTextValidation(s);
                if (result == true)
                {
                    fName = txtFirstName.Text.ToString();
                    lName = txtLastName.Text.ToString();
                    lName=lName.ToLower();
                    fName = fName.ToLower();
                    string[] lname = lName.Split(' ');
                    string[] fname = fName.Split(' ');
                    txtLogin.Text= fname[0].Substring(0,1)+ lname[0];
                    string a = ValidationClass.validChar;
                }
            }
            catch (Exception ex) {
                LogFile.LogData("Generate login for user", ex.ToString(), 0);
            }
           
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            bool result = valCal2.checkBoxListValidation(chkPermission);
            if (result == true) {
                this.AddPermissionToGridView();
            }
            else {
                MessageBox.Show("Please add a permission");
            }
        }
        private void AddColumns()
        {
            DataGridViewTextBoxColumn idColumn =
                new DataGridViewTextBoxColumn();
            idColumn.Name = "formId";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn assignedToColumn =
              new DataGridViewTextBoxColumn();
            assignedToColumn.Name = "Permission";
            assignedToColumn.DataPropertyName = "permissionName";
            assignedToColumn.ReadOnly = true;

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnMove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(assignedToColumn);
            dataGridView1.Columns.Add(buttonColumn);

            // Add a CellClick handler to handle clicks in the button column.
            dataGridView1.CellClick +=
                new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void AddPermissionToGridView() {
            try
            {
                SqlCommand drCommand = null;
                SqlDataReader reader = null;
               
                for (int i = 0; i < chkPermission.Items.Count; i++)
                {
                    if (chkPermission.GetItemChecked(i))
                    {
                        if (chkPermission.Items[i].GetType() == typeof(DataRowView))
                        {
                            DBClass.DBConnect();
                            string permissionId = ((DataRowView)chkPermission.Items[i])["permissionId"].ToString();
                            drCommand = new SqlCommand("SELECT f.formName, p.permissionName FROM tblPermission p INNER JOIN tblForm f ON p.formId = f.formId WHERE p.permissionId = " + Convert.ToInt32(permissionId), DBClass.connection);
                            reader = drCommand.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string[] row = { reader["formName"].ToString(), reader["permissionName"].ToString() };
                                dataGridView1.Rows.Add(row);
                            }
                            DBClass.DBClose();
                        }


                    }
                }
            }
            catch (Exception ex) {
                LogFile.LogData("AddPermissionToGridView Function error", ex.ToString(), 0);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
