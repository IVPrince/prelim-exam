namespace prelim_Ulgasan
{
    partial class GradesForm
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
            lblScore1 = new Label();
            txtScore1 = new TextBox();
            lblScore2 = new Label();
            txtScore2 = new TextBox();
            lblScore3 = new Label();
            txtScore3 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lblInfo = new Label();
            btnClose = new Button();
            pnlHeader = new Panel();
            lblSection = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // lblTitle
            lblTitle.Location = new Point(26, 16);
            lblTitle.Size = new Size(570, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Grade calculator";
            lblTitle.TabIndex = 0;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            // lblNote
            lblNote.Location = new Point(30, 123);
            lblNote.Size = new Size(570, 32);
            lblNote.Name = "lblNote";
            lblNote.Text = "Enter three scores from 0 to 100. All scores have equal weight.";
            lblNote.TabIndex = 1;

            // lblScore1
            lblScore1.Location = new Point(30, 180);
            lblScore1.Size = new Size(100, 25);
            lblScore1.Name = "lblScore1";
            lblScore1.Text = "Score 1";
            lblScore1.TabIndex = 2;

            // txtScore1
            txtScore1.Location = new Point(160, 177);
            txtScore1.Size = new Size(180, 25);
            txtScore1.Name = "txtScore1";
            txtScore1.Text = "";
            txtScore1.TabIndex = 3;

            // lblScore2
            lblScore2.Location = new Point(30, 225);
            lblScore2.Size = new Size(100, 25);
            lblScore2.Name = "lblScore2";
            lblScore2.Text = "Score 2";
            lblScore2.TabIndex = 4;

            // txtScore2
            txtScore2.Location = new Point(160, 222);
            txtScore2.Size = new Size(180, 25);
            txtScore2.Name = "txtScore2";
            txtScore2.Text = "";
            txtScore2.TabIndex = 5;

            // lblScore3
            lblScore3.Location = new Point(30, 270);
            lblScore3.Size = new Size(100, 25);
            lblScore3.Name = "lblScore3";
            lblScore3.Text = "Score 3";
            lblScore3.TabIndex = 6;

            // txtScore3
            txtScore3.Location = new Point(160, 267);
            txtScore3.Size = new Size(180, 25);
            txtScore3.Name = "txtScore3";
            txtScore3.Text = "";
            txtScore3.TabIndex = 7;

            // btnCalculate
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 1;
            btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnCalculate.BackColor = Color.FromArgb(48, 83, 120);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.Location = new Point(160, 312);
            btnCalculate.Size = new Size(125, 36);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Calculate";
            btnCalculate.TabIndex = 8;
            btnCalculate.Click += btnCalculate_Click;
            // btnClear
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(190, 202, 215);
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.FromArgb(40, 52, 68);
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(300, 312);
            btnClear.Size = new Size(100, 36);
            btnClear.Name = "btnClear";
            btnClear.Text = "Clear";
            btnClear.TabIndex = 9;
            btnClear.Click += btnClear_Click;
            // lblResult
            lblResult.Location = new Point(30, 375);
            lblResult.Size = new Size(620, 52);
            lblResult.BackColor = Color.FromArgb(224, 234, 243);
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            lblResult.Name = "lblResult";
            lblResult.Text = "Average: --";
            lblResult.TabIndex = 10;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            // lblInfo
            lblInfo.Location = new Point(30, 440);
            lblInfo.Size = new Size(620, 40);
            lblInfo.Name = "lblInfo";
            lblInfo.Text = "Practice calculator only; no official grade conversion is applied.";
            lblInfo.TabIndex = 11;

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
            btnClose.TabIndex = 12;
            btnClose.Click += btnClose_Click;

            Controls.Add(lblNote);
            Controls.Add(lblScore1);
            Controls.Add(txtScore1);
            Controls.Add(lblScore2);
            Controls.Add(txtScore2);
            Controls.Add(lblScore3);
            Controls.Add(txtScore3);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(lblInfo);
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
            lblSection.Text = "ACADEMIC TOOLS";
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
            Name = "GradesForm";
            Text = "Grade calculator";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Panel pnlHeader;
        private Label lblSection;
        private Label lblTitle;
        private Label lblNote;
        private Label lblScore1;
        private TextBox txtScore1;
        private Label lblScore2;
        private TextBox txtScore2;
        private Label lblScore3;
        private TextBox txtScore3;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
        private Label lblInfo;
        private Button btnClose;
    }
}
