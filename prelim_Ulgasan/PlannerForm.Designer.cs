namespace prelim_Ulgasan
{
    partial class PlannerForm
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
            lblNote = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new CheckedListBox();
            btnRemove = new Button();
            lblSession = new Label();
            btnClose = new Button();
            pnlHeader = new Panel();
            lblSection = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // lblTitle
            lblTitle.Location = new Point(26, 16);
            lblTitle.Size = new Size(560, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Study planner";
            lblTitle.TabIndex = 0;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            // lblNote
            lblNote.Location = new Point(30, 123);
            lblNote.Size = new Size(560, 25);
            lblNote.Name = "lblNote";
            lblNote.Text = "Add tasks, then tick the ones you have completed.";
            lblNote.TabIndex = 1;

            // txtTask
            txtTask.Location = new Point(30, 168);
            txtTask.Size = new Size(470, 27);
            txtTask.Name = "txtTask";
            txtTask.Text = "";
            txtTask.TabIndex = 2;
            txtTask.MaxLength = 90;
            // btnAdd
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnAdd.BackColor = Color.FromArgb(48, 83, 120);
            btnAdd.ForeColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(520, 163);
            btnAdd.Size = new Size(130, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Text = "Add task";
            btnAdd.TabIndex = 3;
            btnAdd.Click += btnAdd_Click;
            // lstTasks
            lstTasks.Location = new Point(30, 223);
            lstTasks.Size = new Size(620, 195);
            lstTasks.Name = "lstTasks";
            lstTasks.Text = "";
            lstTasks.TabIndex = 4;
            lstTasks.CheckOnClick = true;
            lstTasks.HorizontalScrollbar = true;
            // btnRemove
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 1;
            btnRemove.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnRemove.BackColor = Color.White;
            btnRemove.ForeColor = Color.FromArgb(40, 52, 68);
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Location = new Point(30, 434);
            btnRemove.Size = new Size(145, 35);
            btnRemove.Name = "btnRemove";
            btnRemove.Text = "Remove selected";
            btnRemove.TabIndex = 5;
            btnRemove.Click += btnRemove_Click;
            // lblSession
            lblSession.Location = new Point(30, 484);
            lblSession.Size = new Size(420, 50);
            lblSession.Name = "lblSession";
            lblSession.Text = "Tasks are kept only while this window is open.";
            lblSession.TabIndex = 6;

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
            btnClose.TabIndex = 7;
            btnClose.Click += btnClose_Click;

            Controls.Add(lblNote);
            Controls.Add(txtTask);
            Controls.Add(btnAdd);
            Controls.Add(lstTasks);
            Controls.Add(btnRemove);
            Controls.Add(lblSession);
            Controls.Add(btnClose);
            AcceptButton = btnAdd;
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
            lblSection.Text = "PERSONAL ORGANIZER";
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
            Name = "PlannerForm";
            Text = "Study planner";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Panel pnlHeader;
        private Label lblSection;
        private Label lblTitle;
        private Label lblNote;
        private TextBox txtTask;
        private Button btnAdd;
        private CheckedListBox lstTasks;
        private Button btnRemove;
        private Label lblSession;
        private Button btnClose;
    }
}
