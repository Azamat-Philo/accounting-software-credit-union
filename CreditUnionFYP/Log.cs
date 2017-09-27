using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using CreditUnionFYP.classes;

namespace CreditUnionFYP
{
    public partial class Log : Form
    {

        public Log()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
            txtLogin.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd_Login();
        }


        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmd_Login();
            }
            
        }
        private void cmd_Login() {
            try
            {
                if ((!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtPwd.Text)) && (!string.IsNullOrWhiteSpace(txtLogin.Text) && !string.IsNullOrWhiteSpace(txtPwd.Text)))
                {
                    string pwd = txtPwd.Text.Trim().ToString();
                    string userName = txtLogin.Text.Trim().ToString();
                    DBClass.DBConnect();
                    string selectSt = "SELECT TOP 1 WHERE userName=" + userName + " and pwd=";
                    //SqlDataReader drUser = new SqlDataReader();
                    
                    this.Hide();
                    DashBoardMDI myDashBoard = new DashBoardMDI();
                    myDashBoard.Show();
                }
            }
            catch (Exception ex)
            {
                LogFile.LogData("Login connection error", ex.ToString(), 0);
            }
        }
    }
}
