namespace prelim_Ulgasan
{
    partial class ProfileForm
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            btnPreview = new Button();
            grpSummary = new GroupBox();
            lblSummary = new Label();
            btnClose = new Button();
            grpSummary.SuspendLayout();
            pnlHeader = new Panel();
            lblSection = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // lblTitle
            lblTitle.Location = new Point(26, 16);
            lblTitle.Size = new Size(550, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Student profile";
            lblTitle.TabIndex = 0;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            // lblName
            lblName.Location = new Point(30, 135);
            lblName.Size = new Size(110, 25);
            lblName.Name = "lblName";
            lblName.Text = "Full name";
            lblName.TabIndex = 1;

            // txtName
            txtName.Location = new Point(160, 133);
            txtName.Size = new Size(450, 27);
            txtName.Name = "txtName";
            txtName.Text = "";
            txtName.TabIndex = 2;
            txtName.MaxLength = 60;
            // lblCourse
            lblCourse.Location = new Point(30, 180);
            lblCourse.Size = new Size(110, 25);
            lblCourse.Name = "lblCourse";
            lblCourse.Text = "Course";
            lblCourse.TabIndex = 3;

            // cmbCourse
            cmbCourse.Location = new Point(160, 177);
            cmbCourse.Size = new Size(450, 27);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Text = "";
            cmbCourse.TabIndex = 4;
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.Items.AddRange(new object[] { "Computer Engineering", "Civil Engineering", "Electrical Engineering", "Mechanical Engineering" });
            cmbCourse.SelectedIndex = 0;
            // lblYear
            lblYear.Location = new Point(30, 225);
            lblYear.Size = new Size(110, 25);
            lblYear.Name = "lblYear";
            lblYear.Text = "Year level";
            lblYear.TabIndex = 5;

            // numYear
            numYear.Location = new Point(160, 222);
            numYear.Size = new Size(100, 25);
            numYear.Name = "numYear";
            numYear.Text = "";
            numYear.TabIndex = 6;
            numYear.Minimum = 1;
            numYear.Maximum = 5;
            numYear.Value = 1;
            // btnPreview
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.FlatAppearance.BorderSize = 1;
            btnPreview.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnPreview.BackColor = Color.FromArgb(48, 83, 120);
            btnPreview.ForeColor = Color.White;
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Location = new Point(160, 270);
            btnPreview.Size = new Size(140, 35);
            btnPreview.Name = "btnPreview";
            btnPreview.Text = "Show summary";
            btnPreview.TabIndex = 7;
            btnPreview.Click += btnPreview_Click;
            // grpSummary
            grpSummary.Controls.Add(lblSummary);
            grpSummary.Location = new Point(30, 325);
            grpSummary.Size = new Size(620, 125);
            grpSummary.BackColor = Color.White;
            grpSummary.Name = "grpSummary";
            grpSummary.Text = "Profile summary";
            grpSummary.TabIndex = 8;

            // lblSummary
            lblSummary.Location = new Point(18, 28);
            lblSummary.Size = new Size(520, 75);
            lblSummary.Name = "lblSummary";
            lblSummary.Text = "Your summary will appear here.";
            lblSummary.TabIndex = 9;

            // btnClose
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 1;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.FromArgb(40, 52, 68);
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(510, 506);
            btnClose.Size = new Size(140, 36);
            btnClose.Name = "btnClose";
            btnClose.Text = "Back to home";
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCourse);
            Controls.Add(cmbCourse);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(btnPreview);
            Controls.Add(grpSummary);

            Controls.Add(btnClose);

            pnlHeader.Name = "pnlHeader";
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(680, 106);
            pnlHeader.BackColor = Color.FromArgb(35, 59, 87);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSection);
            lblSection.Name = "lblSection";
            lblSection.Location = new Point(30, 68);
            lblSection.Size = new Size(600, 24);
            lblSection.Font = new Font("Segoe UI", 9F);
            lblSection.ForeColor = Color.FromArgb(181, 211, 235);
            lblSection.Text = "STUDENT DETAILS";
            Controls.Add(pnlHeader);
            pnlHeader.ResumeLayout(false);
            AutoScaleDimensions = new SizeF(7F, 17F);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(40, 52, 68);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(680, 560);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "ProfileForm";
            Text = "Student profile";
            grpSummary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Panel pnlHeader;
        private Label lblSection;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Label lblYear;
        private NumericUpDown numYear;
        private Button btnPreview;
        private GroupBox grpSummary;
        private Label lblSummary;
        private Button btnClose;
    }
}
