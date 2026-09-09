namespace prelim_Ulgasan
{
    public partial class PlannerForm : Form
    {
        public PlannerForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (task == "")
            {
                MessageBox.Show("Please enter a task first.", "Missing task");
                txtTask.Focus();
                return;
            }
            lstTasks.Items.Add(task);
            txtTask.Clear();
            txtTask.Focus();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Select the task you want to remove.", "No task selected");
            }
            else
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
