namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        private DbManager dbManager;
        private AddTasks addTasks;
        private CompletedTasks completedTask;
        private RemovedTasks removedTask;
        private OverdueTasks overdueTask;

        public ToDoList()
        {
            InitializeComponent();

            dbManager = new DbManager(doList, datePick, "To-Do");
            dbManager.LoadData();
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            dbManager.LoadData();
        }

        private void addTasksBtn_Click(object sender, EventArgs e)
        {
            addTasks = new AddTasks(dbManager);
            openForm(addTasks);
        }

        private void removeTasksBtn_Click(object sender, EventArgs e)
        {
            var selectedTask = doList.SelectedItem;

            if (selectedTask != null)
            {
                dbManager.RemoveTask();
                dbManager.LoadData();
            }
            else MessageBox.Show("No task to remove was selected. \nTry again.", "Error");
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            var selectedTask = doList.SelectedItem;
            if (selectedTask != null)
            {
                dbManager.CompleteTask();
                dbManager.LoadData();
            }
            else MessageBox.Show("No task to complete was selected. \nTry again.", "Error");
        }

        private void showCompletedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            completedTask = new CompletedTasks();
            openForm(completedTask);
        }

        private void showRemovedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            removedTask = new RemovedTasks();
            openForm(removedTask);
        }

        private void openForm(Form open)
        {
            this.Hide();
            open.ShowDialog();
            this.Show();
        }

        private void showOverdueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            overdueTask = new OverdueTasks();
            openForm(overdueTask);
        }
    }
}