using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class RemovedTasks : Form
    {
        DbManager manager;
        public RemovedTasks()
        {
            InitializeComponent();

            manager = new DbManager(removedBox, datePicker, "Removed");
            manager.LoadData();
        }

        private void manipulBtn_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this task? " +
                    "\nTask will be permanently deleted and will not be recoverable.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) manager.DeleteTask();
            }
            else manager.RecoverTask();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked) manipulBtn.Text = "DELETE TASK";
            else manipulBtn.Text = "Recover Task";
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            manager.LoadData();
        }
    }
}
