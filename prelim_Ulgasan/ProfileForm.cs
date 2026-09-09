namespace prelim_Ulgasan
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.", "Missing name");
                txtName.Focus();
                return;
            }
            lblSummary.Text = "Name: " + txtName.Text.Trim()
                + "\nCourse: " + cmbCourse.Text
                + "\nYear level: " + numYear.Value;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
