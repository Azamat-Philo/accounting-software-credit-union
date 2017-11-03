using System;
using DataBase;
using System.Windows.Forms;

namespace Common
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            IMCCUDBEntities db = new IMCCUDBEntities();

            BindingSource da = new BindingSource();
            da.DataSource = (from em in db.tblUsers
                             select new { em.Title, em.EmployeeID }).ToList();
            dgUserList.DataSource = da;
            dgUserList.Refresh();

        }
    }
}
