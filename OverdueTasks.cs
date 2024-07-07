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
    public partial class OverdueTasks : Form
    {
        DbManager dbManger;
        public OverdueTasks()
        {
            InitializeComponent();

            dbManger = new DbManager(overdueBox);
            dbManger.OverdueTasks();
        }
    }
}
