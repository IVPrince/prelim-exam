namespace prelim_Ulgasan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuPages = new ToolStripMenuItem();
            mnuProfile = new ToolStripMenuItem();
            mnuGrades = new ToolStripMenuItem();
            mnuPlanner = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            lblTitle = new Label();
            lblIntro = new Label();
            grpPages = new GroupBox();
            btnProfile = new Button();
            btnGrades = new Button();
            btnPlanner = new Button();
            lblProfile = new Label();
            lblGrades = new Label();
            lblPlanner = new Label();
            lblTip = new Label();
            lblCourse = new Label();
            ctxHome = new ContextMenuStrip(components);
            ctxProfile = new ToolStripMenuItem();
            ctxGrades = new ToolStripMenuItem();
            ctxPlanner = new ToolStripMenuItem();
            pnlHeader = new Panel();
            lblSection = new Label();
            menuMain.SuspendLayout();
            grpPages.SuspendLayout();
            ctxHome.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuPages, mnuAbout });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(680, 24);
            menuMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(93, 22);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuPages
            // 
            mnuPages.DropDownItems.AddRange(new ToolStripItem[] { mnuProfile, mnuGrades, mnuPlanner });
            mnuPages.Name = "mnuPages";
            mnuPages.Size = new Size(50, 20);
            mnuPages.Text = "Pages";
            // 
            // mnuProfile
            // 
            mnuProfile.Name = "mnuProfile";
            mnuProfile.Size = new Size(160, 22);
            mnuProfile.Text = "Student profile";
            mnuProfile.Click += btnProfile_Click;
            // 
            // mnuGrades
            // 
            mnuGrades.Name = "mnuGrades";
            mnuGrades.Size = new Size(160, 22);
            mnuGrades.Text = "Grade calculator";
            mnuGrades.Click += btnGrades_Click;
            // 
            // mnuPlanner
            // 
            mnuPlanner.Name = "mnuPlanner";
            mnuPlanner.Size = new Size(160, 22);
            mnuPlanner.Text = "Study planner";
            mnuPlanner.Click += btnPlanner_Click;
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(52, 20);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 48);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Student Hub";
            // 
            // lblIntro
            // 
            lblIntro.Location = new Point(30, 159);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(560, 26);
            lblIntro.TabIndex = 9;
            lblIntro.Text = "Welcome back. What would you like to work on?";
            // 
            // grpPages
            // 
            grpPages.BackColor = Color.White;
            grpPages.Controls.Add(btnProfile);
            grpPages.Controls.Add(btnGrades);
            grpPages.Controls.Add(btnPlanner);
            grpPages.Controls.Add(lblProfile);
            grpPages.Controls.Add(lblGrades);
            grpPages.Controls.Add(lblPlanner);
            grpPages.Location = new Point(30, 205);
            grpPages.Name = "grpPages";
            grpPages.Size = new Size(620, 220);
            grpPages.TabIndex = 10;
            grpPages.TabStop = false;
            grpPages.Text = "Explore your tools";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(48, 83, 120);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(20, 42);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(180, 78);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "Student profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.FromArgb(48, 83, 120);
            btnGrades.Cursor = Cursors.Hand;
            btnGrades.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGrades.ForeColor = Color.White;
            btnGrades.Location = new Point(220, 42);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(180, 78);
            btnGrades.TabIndex = 12;
            btnGrades.Text = "Grade calculator";
            btnGrades.UseVisualStyleBackColor = false;
            btnGrades.Click += btnGrades_Click;
            // 
            // btnPlanner
            // 
            btnPlanner.BackColor = Color.FromArgb(48, 83, 120);
            btnPlanner.Cursor = Cursors.Hand;
            btnPlanner.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnPlanner.FlatStyle = FlatStyle.Flat;
            btnPlanner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPlanner.ForeColor = Color.White;
            btnPlanner.Location = new Point(420, 42);
            btnPlanner.Name = "btnPlanner";
            btnPlanner.Size = new Size(180, 78);
            btnPlanner.TabIndex = 13;
            btnPlanner.Text = "Study planner";
            btnPlanner.UseVisualStyleBackColor = false;
            btnPlanner.Click += btnPlanner_Click;
            // 
            // lblProfile
            // 
            lblProfile.ForeColor = Color.FromArgb(86, 101, 117);
            lblProfile.Location = new Point(20, 137);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(180, 56);
            lblProfile.TabIndex = 14;
            lblProfile.Text = "Review your name, course\nand year level.";
            lblProfile.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGrades
            // 
            lblGrades.ForeColor = Color.FromArgb(86, 101, 117);
            lblGrades.Location = new Point(220, 137);
            lblGrades.Name = "lblGrades";
            lblGrades.Size = new Size(180, 56);
            lblGrades.TabIndex = 15;
            lblGrades.Text = "Find the average of\nthree assessment scores.";
            lblGrades.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlanner
            // 
            lblPlanner.ForeColor = Color.FromArgb(86, 101, 117);
            lblPlanner.Location = new Point(420, 137);
            lblPlanner.Name = "lblPlanner";
            lblPlanner.Size = new Size(180, 56);
            lblPlanner.TabIndex = 16;
            lblPlanner.Text = "Keep your study tasks\nin one place.";
            lblPlanner.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTip
            // 
            lblTip.Location = new Point(30, 451);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(620, 38);
            lblTip.TabIndex = 17;
            lblTip.Text = "Tip: You can also use the Pages menu or right-click this page.";
            // 
            // lblCourse
            // 
            lblCourse.ForeColor = Color.FromArgb(86, 101, 117);
            lblCourse.Location = new Point(30, 520);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(570, 25);
            lblCourse.TabIndex = 18;
            lblCourse.Text = "CPE262  |  Prelim Exam  |  Ulgasan";
            // 
            // ctxHome
            // 
            ctxHome.Items.AddRange(new ToolStripItem[] { ctxProfile, ctxGrades, ctxPlanner });
            ctxHome.Name = "ctxHome";
            ctxHome.Size = new Size(161, 70);
            // 
            // ctxProfile
            // 
            ctxProfile.Name = "ctxProfile";
            ctxProfile.Size = new Size(160, 22);
            ctxProfile.Text = "Student profile";
            ctxProfile.Click += btnProfile_Click;
            // 
            // ctxGrades
            // 
            ctxGrades.Name = "ctxGrades";
            ctxGrades.Size = new Size(160, 22);
            ctxGrades.Text = "Grade calculator";
            ctxGrades.Click += btnGrades_Click;
            // 
            // ctxPlanner
            // 
            ctxPlanner.Name = "ctxPlanner";
            ctxPlanner.Size = new Size(160, 22);
            ctxPlanner.Text = "Study planner";
            ctxPlanner.Click += btnPlanner_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(35, 59, 87);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSection);
            pnlHeader.Location = new Point(0, 28);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(680, 106);
            pnlHeader.TabIndex = 1;
            // 
            // lblSection
            // 
            lblSection.Font = new Font("Segoe UI", 9F);
            lblSection.ForeColor = Color.FromArgb(181, 211, 235);
            lblSection.Location = new Point(30, 68);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(600, 24);
            lblSection.TabIndex = 9;
            lblSection.Text = "YOUR CAMPUS COMPANION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(680, 560);
            ContextMenuStrip = ctxHome;
            Controls.Add(pnlHeader);
            Controls.Add(menuMain);
            Controls.Add(lblIntro);
            Controls.Add(grpPages);
            Controls.Add(lblTip);
            Controls.Add(lblCourse);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(40, 52, 68);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuMain;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Hub";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            grpPages.ResumeLayout(false);
            ctxHome.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private ContextMenuStrip ctxHome;
        private ToolStripMenuItem ctxProfile;
        private ToolStripMenuItem ctxGrades;
        private ToolStripMenuItem ctxPlanner;
        private MenuStrip menuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuPages;
        private ToolStripMenuItem mnuProfile;
        private ToolStripMenuItem mnuGrades;
        private ToolStripMenuItem mnuPlanner;
        private ToolStripMenuItem mnuAbout;
        private Panel pnlHeader;
        private Label lblSection;
        private Label lblTitle;
        private Label lblIntro;
        private GroupBox grpPages;
        private Button btnProfile;
        private Button btnGrades;
        private Button btnPlanner;
        private Label lblProfile;
        private Label lblGrades;
        private Label lblPlanner;
        private Label lblTip;
        private Label lblCourse;
    }
}
