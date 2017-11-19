namespace CreditUnionFYP
{
    partial class DashBoardMDI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.actualdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.systemAdministratorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfMembersToolStripMenuItem,
            this.createMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.membersToolStripMenuItem.Text = "&Members";
            // 
            // listOfMembersToolStripMenuItem
            // 
            this.listOfMembersToolStripMenuItem.Name = "listOfMembersToolStripMenuItem";
            this.listOfMembersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listOfMembersToolStripMenuItem.Text = "&List of members";
            this.listOfMembersToolStripMenuItem.Click += new System.EventHandler(this.listOfMembersToolStripMenuItem_Click);
            // 
            // createMemberToolStripMenuItem
            // 
            this.createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            this.createMemberToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.createMemberToolStripMenuItem.Text = "&Create member";
            this.createMemberToolStripMenuItem.Click += new System.EventHandler(this.createMemberToolStripMenuItem_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfLoansToolStripMenuItem,
            this.typeOfLoansToolStripMenuItem});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // listOfLoansToolStripMenuItem
            // 
            this.listOfLoansToolStripMenuItem.Name = "listOfLoansToolStripMenuItem";
            this.listOfLoansToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listOfLoansToolStripMenuItem.Text = "List of loans";
            // 
            // typeOfLoansToolStripMenuItem
            // 
            this.typeOfLoansToolStripMenuItem.Name = "typeOfLoansToolStripMenuItem";
            this.typeOfLoansToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.typeOfLoansToolStripMenuItem.Text = "Type of loans";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLoanToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.adminToolStripMenuItem.Text = "Administration";
            // 
            // addLoanToolStripMenuItem
            // 
            this.addLoanToolStripMenuItem.Name = "addLoanToolStripMenuItem";
            this.addLoanToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addLoanToolStripMenuItem.Text = "List of loan type";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shareLimitToolStripMenuItem,
            this.accountTypeToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // shareLimitToolStripMenuItem
            // 
            this.shareLimitToolStripMenuItem.Name = "shareLimitToolStripMenuItem";
            this.shareLimitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shareLimitToolStripMenuItem.Text = "Share limit";
            // 
            // accountTypeToolStripMenuItem
            // 
            this.accountTypeToolStripMenuItem.Name = "accountTypeToolStripMenuItem";
            this.accountTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountTypeToolStripMenuItem.Text = "Account Type";
            this.accountTypeToolStripMenuItem.Click += new System.EventHandler(this.accountTypeToolStripMenuItem_Click);
            // 
            // systemAdministratorToolStripMenuItem
            // 
            this.systemAdministratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.createUserToolStripMenuItem1});
            this.systemAdministratorToolStripMenuItem.Name = "systemAdministratorToolStripMenuItem";
            this.systemAdministratorToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.systemAdministratorToolStripMenuItem.Text = "System Administrator";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createUserToolStripMenuItem.Text = "User List";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem1
            // 
            this.createUserToolStripMenuItem1.Name = "createUserToolStripMenuItem1";
            this.createUserToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createUserToolStripMenuItem1.Text = "Create User";
            this.createUserToolStripMenuItem1.Click += new System.EventHandler(this.createUserToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualdate,
            this.clock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // actualdate
            // 
            this.actualdate.LinkColor = System.Drawing.Color.Black;
            this.actualdate.Name = "actualdate";
            this.actualdate.Size = new System.Drawing.Size(118, 17);
            this.actualdate.Text = "toolStripStatusLabel1";
            this.actualdate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.actualdate.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // clock
            // 
            this.clock.LinkColor = System.Drawing.Color.Black;
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(118, 17);
            this.clock.Text = "toolStripStatusLabel1";
            this.clock.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // DashBoardMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1110, 495);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DashBoardMDI";
            this.Text = "DashBoardMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoardMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOfLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel actualdate;
        private System.Windows.Forms.ToolStripStatusLabel clock;
    }
}



