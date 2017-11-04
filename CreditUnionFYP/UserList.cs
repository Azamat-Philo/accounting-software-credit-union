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
            dgUserList.DataSource = db.tblUsers.ToList();
        }
    }
}
