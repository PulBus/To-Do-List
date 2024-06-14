namespace To_Do_List
{
    public partial class AddTasks : Form
    {
        DbManager manager;

        public AddTasks(DbManager taskManager)
        {
            InitializeComponent();
            manager = taskManager;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toAdd.Text))
            {
                manager.InsertTask(toAdd.Text, startDate.Value, dueDate.Value);
                toAdd.Clear();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}