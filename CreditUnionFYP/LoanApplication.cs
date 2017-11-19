using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditUnionFYP
{
    public partial class LoanApplication : Form
    {
        public LoanApplication()
        {
            InitializeComponent();
        }

        private void LoanApplication_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSureties_Click(object sender, EventArgs e)
        {
           string nic = Interaction.InputBox("Add a surety ID", "NIC");
            /*Interaction.
            MessageBox.Show("Do you want to exit ?", "Exit ?", MessageBoxButtons.YesNo);*/
        }
    }
}
