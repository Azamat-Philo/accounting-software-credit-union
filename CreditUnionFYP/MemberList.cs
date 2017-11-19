using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using Member;

namespace CreditUnionFYP
{
    public partial class MemberList : Form
    {
        Entities db = new Entities();
        public MemberList()
        {
            InitializeComponent();
        }
        public class MemberLst {
            public string fname;
            public string nic;
            public string lname;
            public DateTime dob;
            public DateTime membersince;
            public int memberId;
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
           
        }

        private void MemberList_Load_1(object sender, EventArgs e)
        {
            var query = (from rc in db.tblMembers
                         select new MemberLst { fname = rc.firstName, nic = rc.nic, lname = rc.lastName, dob = rc.dateOfBirth, membersince = rc.memberSince ?? DateTime.Now, memberId = rc.memberId }).ToList();
            dgMemberList.Rows.Clear();
            dgMemberList.Refresh();
            foreach (var c in query)
            {
                string[] row = { c.lname, c.nic.ToString(), c.fname, c.nic,c.dob.ToShortDateString(), c.membersince.ToShortDateString(), c.memberId.ToString() };
                dgMemberList.Rows.Add(row);
            }

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var query = (from rc in db.tblMembers
                         where rc.lastName==txtLastName.Text.ToString()
                         select new MemberLst { fname = rc.firstName, nic = rc.nic, lname = rc.lastName, dob = rc.dateOfBirth, membersince = rc.memberSince ?? DateTime.Now, memberId = rc.memberId }).ToList();
            dgMemberList.Rows.Clear();
            dgMemberList.Refresh();
            foreach (var c in query)
            {
                string[] row = { c.lname, c.nic.ToString(), c.fname, c.nic, c.dob.ToShortDateString(), c.membersince.ToShortDateString(), c.memberId.ToString() };
                dgMemberList.Rows.Add(row);
            }
        }

        private void txtNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            var query = (from rc in db.tblMembers
                         where rc.nic==txtNic.Text.ToString()
                         select new MemberLst { fname = rc.firstName, nic = rc.nic, lname = rc.lastName, dob = rc.dateOfBirth, membersince = rc.memberSince ?? DateTime.Now , memberId = rc.memberId }).ToList();
            dgMemberList.Rows.Clear();
            dgMemberList.Refresh();
            foreach (var c in query)
            {
                string[] row = { c.lname, c.nic.ToString(), c.fname, c.nic, c.dob.ToShortDateString(), c.membersince.ToShortDateString(),c.memberId.ToString() };
                dgMemberList.Rows.Add(row);
            }
        }

        private void dgMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgMemberList.Columns["btnEdit"].Index)
            {
                int selectedrowindex = dgMemberList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgMemberList.Rows[selectedrowindex];
                Member.Member.memberId= Convert.ToInt32(selectedRow.Cells["memberId"].Value);
                EditMember frmEditMember = new EditMember();
                frmEditMember.Show();

            }
        }
    }
}
