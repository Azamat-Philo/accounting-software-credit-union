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
    public partial class UploadDialog : UserControl
    {
        public UploadDialog()
        {
            InitializeComponent();
        }

        private void btnBrowserFolder_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.CheckPathExists) {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
