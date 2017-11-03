namespace Common.usercontrol
{
    partial class SearchByDate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // dpFrom
            // 
            this.dpFrom.BackColor = System.Drawing.Color.SeaGreen;
            this.dpFrom.BorderRadius = 0;
            this.dpFrom.ForeColor = System.Drawing.Color.White;
            this.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpFrom.FormatCustom = null;
            this.dpFrom.Location = new System.Drawing.Point(3, 5);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(211, 36);
            this.dpFrom.TabIndex = 0;
            this.dpFrom.Value = new System.DateTime(2017, 10, 12, 23, 34, 5, 308);
            // 
            // dpTo
            // 
            this.dpTo.BackColor = System.Drawing.Color.SeaGreen;
            this.dpTo.BorderRadius = 0;
            this.dpTo.ForeColor = System.Drawing.Color.White;
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpTo.FormatCustom = null;
            this.dpTo.Location = new System.Drawing.Point(285, 5);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(219, 36);
            this.dpTo.TabIndex = 1;
            this.dpTo.Value = new System.DateTime(2017, 10, 12, 23, 34, 20, 817);
            // 
            // SearchByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.dpFrom);
            this.Name = "SearchByDate";
            this.Size = new System.Drawing.Size(507, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dpFrom;
        private Bunifu.Framework.UI.BunifuDatepicker dpTo;
    }
}
