using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace Common
{
    public partial class frmAddUser : Form
    {
        public class AddUserGrid
        {
            public string formName;
            public string permissionName;
        }
        public List<AddUserGrid> gridPermission = new List<AddUserGrid>();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Control> r = new List<Control>();

                r.Add(txtFirstName);
                r.Add(txtLastName);
                r.Add(txtLogin);
                r.Add(txtPwd);
                LogValidationManagement.Validation h = new LogValidationManagement.Validation();
                bool result = h.inputTextValidation(r);

                if (result == true)
                {
                    User user = new User();
                    user.fName = txtFirstName.Text.Trim().ToString();
                    user.lName = txtLastName.Text.Trim().ToString();
                    user.userName = txtLogin.Text.Trim().ToString();
                    user.uDelete = false;
                    user.active = chkActive.Checked == true ? true : false;
                    user.pwd = txtPwd.Text.Trim().ToString();
                    
                    int i = user.CreateUser(user);
                    user.AddPermission(dataGridView1, i);
                    if (!i.Equals(0)) {
                        MessageBox.Show("The user was created with success");
                        UserList ur = new UserList();
                        ur.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex) {
                LogValidationManagement.LogFile.LogData(MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.cbFormName.SelectedValueChanged -= new System.EventHandler(this.cbFormName_SelectedValueChanged);
            DataBase.DBClass.DBConnect();
            SqlCommand drCommand = null;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable ds = new DataTable();
            drCommand = new SqlCommand("SELECT * FROM tblForm where active=1", DataBase.DBClass.connection);
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
                DataBase.DBClass.DBConnect();
                SqlCommand drCommand = null;
                drCommand = new SqlCommand("SELECT * FROM tblPermission where formId="+ cbFormName.SelectedValue + " and active=1 and uDelete=0", DataBase.DBClass.connection);
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
            List<Control> s = new List<Control>();
            string fName = null, lName = null;
            try
            {
                s.Add(txtFirstName);
                s.Add(txtLastName);
                LogValidationManagement.Validation h = new LogValidationManagement.Validation();
                bool result = h.inputTextValidation(s);
                if (result == true)
                {
                    fName = txtFirstName.Text.ToString();
                    lName = txtLastName.Text.ToString();
                    lName=lName.ToLower();
                    fName = fName.ToLower();
                    string[] lname = lName.Split(' ');
                    string[] fname = fName.Split(' ');
                    txtLogin.Text= fname[0].Substring(0,1)+ lname[0];
                    string a = LogValidationManagement.Validation.validChar;
                }
            }
            catch (Exception ex) {
                LogValidationManagement.LogFile.LogData(MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
           
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            bool result = LogValidationManagement.Validation.checkBoxListValidation(chkPermission);
            if (result == true) {
              
                this.AddPermissionToGridView();
            }
            else {
                MessageBox.Show("Please add a permission");
            }
        }
        private void AddColumns()
        {

            DataGridViewTextBoxColumn formName =
                new DataGridViewTextBoxColumn();
            formName.Name = "formName";
            formName.DataPropertyName = "formname";
            formName.ReadOnly = true;

            DataGridViewTextBoxColumn permissionid =
              new DataGridViewTextBoxColumn();
            permissionid.Name = "PermissionId";
            permissionid.DataPropertyName = "permissionId";
            permissionid.ReadOnly = true;

            DataGridViewTextBoxColumn permission =
              new DataGridViewTextBoxColumn();
            permission.Name = "Permission";
            permission.DataPropertyName = "permissionName";
            permission.ReadOnly = true;

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnRemove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(formName);
            dataGridView1.Columns.Add(permissionid);
            dataGridView1.Columns.Add(permission);
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
                            DataBase.DBClass.DBConnect();
                            string permissionId = ((DataRowView)chkPermission.Items[i])["permissionId"].ToString();
                            drCommand = new SqlCommand("SELECT f.formName,p.permissionId, p.permissionName FROM tblPermission p INNER JOIN tblForm f ON p.formId = f.formId WHERE p.permissionId = " + Convert.ToInt32(permissionId), DataBase.DBClass.connection);
                            reader = drCommand.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                bool res = gridPermission.Exists(item => item.formName == reader["formName"].ToString() && item.permissionName == reader["permissionName"].ToString());
                                if (res == false)
                                {
                                    string[] row = { reader["formName"].ToString(), reader["permissionId"].ToString(), reader["permissionName"].ToString() };
                                    dataGridView1.Rows.Add(row);
                                    AddUserGrid val = new AddUserGrid();
                                    val.formName = reader["formName"].ToString();
                                    val.permissionName = reader["permissionName"].ToString();
                                    gridPermission.Add(val);
                                }
                                else {
                                    MessageBox.Show("Already added permission");
                                }
                            }
                           DataBase.DBClass.DBClose();
                        }


                    }
                }
            }
            catch (Exception ex) {
                LogValidationManagement.LogFile.LogData(MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnRemove"].Index)
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                dataGridView1.Rows.RemoveAt(selectedrowindex);
                gridPermission.RemoveAt(selectedrowindex);
            }
        }


        
    }
}
