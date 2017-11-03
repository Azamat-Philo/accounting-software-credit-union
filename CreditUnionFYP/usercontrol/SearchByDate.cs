using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.usercontrol
{
    public partial class SearchByDate : UserControl
    {
        public SearchByDate()
        {
            InitializeComponent();
        }
        public DateTime dpFromValue
        {
            get
            {
                return dpFrom.Value;
            }
            set
            {
                dpFrom.Value = DateTime.Today;
            }
        }
        public DateTime dpToValue
        {
            get
            {
                return dpTo.Value;
            }
            set
            {
                dpTo.Value = DateTime.Today;
            }
        }

    }
}
