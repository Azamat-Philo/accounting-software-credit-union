using System;
using DataBase;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    public partial class UserList : Form
    {
        public IMCCUDBEntities db = new IMCCUDBEntities();
      
        public UserList()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmEditUser f = new frmEditUser();
            f.Show();
            this.Hide();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            var query = (from c in db.tblUsers
                         where c.uDelete == false
                         select c);

            dgUserList.DataSource = query.ToList();
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.HeaderText = "";
            EditButtonColumn.Name = "Edit";
            EditButtonColumn.Text = "Edit";
            EditButtonColumn.Width = 50;
            DeleteButtonColumn.HeaderText = "";
            DeleteButtonColumn.Width = 50;
            DeleteButtonColumn.Name = "Delete";
            DeleteButtonColumn.Text = "Delete";


            EditButtonColumn.UseColumnTextForButtonValue = true;
            DeleteButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndexEdit = 8; int columnIndexDelete = 9;

            if (dgUserList.Columns["Edit"] == null && dgUserList.Columns["Delete"] == null)
            {
                dgUserList.Columns.Insert(columnIndexEdit, EditButtonColumn);
                dgUserList.Columns.Insert(columnIndexDelete, DeleteButtonColumn);
            }
        }

        private void dgUserList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgUserList.Columns["Edit"].Index )
            {
                int selectedrowindex = dgUserList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgUserList.Rows[selectedrowindex];
                User.userIdEdit = Convert.ToInt32(selectedRow.Cells["userIdDataGridViewTextBoxColumn"].Value);
                frmEditUser frmEdit = new frmEditUser();
                frmEdit.Show();
                
            }
            if (e.ColumnIndex == dgUserList.Columns["Delete"].Index) {
                int selectedrowindex = dgUserList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgUserList.Rows[selectedrowindex];
                User.userIdEdit = Convert.ToInt32(selectedRow.Cells["userIdDataGridViewTextBoxColumn"].Value);
            }
            this.Hide();
        }
    }
}
