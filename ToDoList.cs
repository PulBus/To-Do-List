namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        private DbManager dbManager;
        private AddTasks addTasks;
        private CompletedTasks completedTask;
        private RemovedTasks removedTask;
        public ToDoList()
        {
            InitializeComponent();

            dbManager = new DbManager(doList, datePick, "To-Do");
            dbManager.LoadData();

            addTasks = new AddTasks(dbManager);
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            dbManager.LoadData();
        }

        private void addTasksBtn_Click(object sender, EventArgs e)
        {
            addTasks.ShowDialog();
        }

        private void removeTasksBtn_Click(object sender, EventArgs e)
        {
            if (!removedChk.Checked)
            {
                var selectedTask = doList.SelectedItem;

                if (selectedTask != null) dbManager.RemoveTask();
                else MessageBox.Show("No task to remove was selected. \nTry again.", "Error");
            }
            else
            {
                removedTask = new RemovedTasks();
                removedTask.ShowDialog();
            }
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            if (!completedChk.Checked)
            {
                var selectedTask = doList.SelectedItem;
                if (selectedTask != null)
                {
                    dbManager.CompleteTask();
                    dbManager.LoadData();
                }
                else MessageBox.Show("No task to complete was selected. \nTry again.", "Error");
            }
            else 
            {
                completedTask = new CompletedTasks();
                completedTask.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (completedChk.Checked) completedBtn.Text = "Show Completed";
            else completedBtn.Text = "Task Completed";
        }

        private void removedChk_CheckedChanged(object sender, EventArgs e)
        {
            if (removedChk.Checked) removeTasksBtn.Text = "Show Removed";
            else removeTasksBtn.Text = "Remove Task";
        }
    }
}