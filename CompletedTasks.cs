namespace To_Do_List
{
    public partial class CompletedTasks : Form
    {
        DbManager manager;
        public CompletedTasks()
        {
            InitializeComponent();

            manager = new DbManager(completedBox, datePicker, "Completed");
            manager.LoadData();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var selectedTask = completedBox.SelectedItem;

            if (selectedTask != null) manager.RemoveTask();
            else MessageBox.Show("No task to remove was selected. \nTry again.", "Error");
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            manager.LoadData();
        }
    }
}
