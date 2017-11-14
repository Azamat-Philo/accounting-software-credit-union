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
    public partial class TextBoxColorChange : UserControl
    {
        private string text;

        public string Text

        {
            get { return textBox.Text; }

            set { textBox.Text = value; }
        }

        TextBox textBox = new TextBox();

        public TextBoxColorChange()

        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(TextBoxColorChange_Paint);

            this.Resize += new EventHandler(TextBoxColorChange_Resize);

            textBox.Multiline = true;

            textBox.BorderStyle = BorderStyle.None;

            this.Controls.Add(textBox);
        }

        private void TextBoxColorChange_Resize(object sender, EventArgs e)

        {
            textBox.Size = new Size(this.Width - 3, this.Height - 2);

            textBox.Location = new Point(2, 1);
        }

        private void TextBoxColorChange_Paint(object sender, PaintEventArgs e)

        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
    }
}
