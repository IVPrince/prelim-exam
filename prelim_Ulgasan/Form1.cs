namespace prelim_Ulgasan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            using (ProfileForm page = new ProfileForm())
            {
                // Keep only the selected page visible.
                Hide();
                try
                {
                    page.ShowDialog(this);
                }
                finally
                {
                    Show();
                    Activate();
                }
            }
        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            using (GradesForm page = new GradesForm())
            {
                // Keep only the selected page visible.
                Hide();
                try
                {
                    page.ShowDialog(this);
                }
                finally
                {
                    Show();
                    Activate();
                }
            }
        }
        private void btnPlanner_Click(object sender, EventArgs e)
        {
            using (PlannerForm page = new PlannerForm())
            {
                // Keep only the selected page visible.
                Hide();
                try
                {
                    page.ShowDialog(this);
                }
                finally
                {
                    Show();
                    Activate();
                }
            }
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Hub\nCPE262 - Prelim Activity\nProfile, grades, and study planning.", "About");
        }

    }
}

