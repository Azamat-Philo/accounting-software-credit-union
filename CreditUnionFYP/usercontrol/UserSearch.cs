using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditUnionFYP.usercontrol
{
    public partial class UserSearch : UserControl
    {
        public UserSearch()
        {
            InitializeComponent();
        }

        public string txtNicSearchValue
        {
            get
            {
                return txtNicSearch.Text;
            }
            set
            {
                txtNicSearch.Text = "";
            }
        }
        public string txtLastNameSearchValue
        {
            get
            {
                return txtLastNameSearch.Text;
            }
            set
            {
                txtLastNameSearch.Text = "";
            }
        }

        private void txtLastNameSearch_Click(object sender, EventArgs e)
        {
            txtLastNameSearch.Text = "";
        }

        private void txtNicSearch_Click(object sender, EventArgs e)
        {
            txtNicSearch.text = "";
        }
    }
}
