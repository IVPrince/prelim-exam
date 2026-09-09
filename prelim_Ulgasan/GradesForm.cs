namespace prelim_Ulgasan
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal score1, score2, score3;
            if (!decimal.TryParse(txtScore1.Text, out score1)
                || !decimal.TryParse(txtScore2.Text, out score2)
                || !decimal.TryParse(txtScore3.Text, out score3))
            {
                lblResult.Text = "Average: --";
                MessageBox.Show("Please enter a valid number for each score.", "Invalid score");
                return;
            }
            if (score1 < 0 || score1 > 100 || score2 < 0 || score2 > 100 || score3 < 0 || score3 > 100)
            {
                lblResult.Text = "Average: --";
                MessageBox.Show("Scores must be between 0 and 100.", "Invalid score");
                return;
            }
            decimal average = (score1 + score2 + score3) / 3;
            lblResult.Text = "Average: " + average.ToString("0.00") + " / 100";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblResult.Text = "Average: --";
            txtScore1.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
