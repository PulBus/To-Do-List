namespace To_Do_List
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            addTasksBtn = new Button();
            removeTasksBtn = new Button();
            datePick = new DateTimePicker();
            doList = new ListBox();
            doListContext = new ContextMenuStrip(components);
            addTasksToolStripMenuItem = new ToolStripMenuItem();
            removeTaskToolStripMenuItem = new ToolStripMenuItem();
            completeTaskToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            showRemovedToolStripMenuItem = new ToolStripMenuItem();
            showCompletedToolStripMenuItem = new ToolStripMenuItem();
            showOverdueToolStripMenuItem = new ToolStripMenuItem();
            completedBtn = new Button();
            doListStrip = new MenuStrip();
            addTasksToolStripMenuItem1 = new ToolStripMenuItem();
            showCompletedToolStripMenuItem1 = new ToolStripMenuItem();
            showRemovedToolStripMenuItem1 = new ToolStripMenuItem();
            showOverdueToolStripMenuItem1 = new ToolStripMenuItem();
            overdueLbl = new Label();
            doListContext.SuspendLayout();
            doListStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 45);
            label1.TabIndex = 1;
            label1.Text = "To-Do";
            // 
            // addTasksBtn
            // 
            addTasksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addTasksBtn.Location = new Point(237, 252);
            addTasksBtn.Margin = new Padding(3, 2, 3, 2);
            addTasksBtn.Name = "addTasksBtn";
            addTasksBtn.Size = new Size(164, 29);
            addTasksBtn.TabIndex = 3;
            addTasksBtn.Text = "Add Tasks";
            addTasksBtn.UseVisualStyleBackColor = true;
            addTasksBtn.Click += addTasksBtn_Click;
            // 
            // removeTasksBtn
            // 
            removeTasksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            removeTasksBtn.Location = new Point(237, 283);
            removeTasksBtn.Margin = new Padding(3, 2, 3, 2);
            removeTasksBtn.Name = "removeTasksBtn";
            removeTasksBtn.RightToLeft = RightToLeft.No;
            removeTasksBtn.Size = new Size(164, 29);
            removeTasksBtn.TabIndex = 4;
            removeTasksBtn.Text = "Remove Task";
            removeTasksBtn.UseVisualStyleBackColor = true;
            removeTasksBtn.Click += removeTasksBtn_Click;
            // 
            // datePick
            // 
            datePick.Location = new Point(12, 89);
            datePick.Margin = new Padding(3, 2, 3, 2);
            datePick.Name = "datePick";
            datePick.Size = new Size(219, 23);
            datePick.TabIndex = 5;
            datePick.ValueChanged += datePick_ValueChanged;
            // 
            // doList
            // 
            doList.ContextMenuStrip = doListContext;
            doList.FormattingEnabled = true;
            doList.ItemHeight = 15;
            doList.Location = new Point(12, 113);
            doList.Margin = new Padding(3, 2, 3, 2);
            doList.Name = "doList";
            doList.Size = new Size(219, 199);
            doList.TabIndex = 6;
            // 
            // doListContext
            // 
            doListContext.ImageScalingSize = new Size(20, 20);
            doListContext.Items.AddRange(new ToolStripItem[] { addTasksToolStripMenuItem, removeTaskToolStripMenuItem, completeTaskToolStripMenuItem, toolStripMenuItem1, showRemovedToolStripMenuItem, showCompletedToolStripMenuItem, showOverdueToolStripMenuItem });
            doListContext.Name = "doListMenu";
            doListContext.Size = new Size(166, 142);
            // 
            // addTasksToolStripMenuItem
            // 
            addTasksToolStripMenuItem.Name = "addTasksToolStripMenuItem";
            addTasksToolStripMenuItem.Size = new Size(165, 22);
            addTasksToolStripMenuItem.Text = "Add Tasks";
            addTasksToolStripMenuItem.Click += addTasksBtn_Click;
            // 
            // removeTaskToolStripMenuItem
            // 
            removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            removeTaskToolStripMenuItem.Size = new Size(165, 22);
            removeTaskToolStripMenuItem.Text = "Remove Task";
            removeTaskToolStripMenuItem.Click += removeTasksBtn_Click;
            // 
            // completeTaskToolStripMenuItem
            // 
            completeTaskToolStripMenuItem.Name = "completeTaskToolStripMenuItem";
            completeTaskToolStripMenuItem.Size = new Size(165, 22);
            completeTaskToolStripMenuItem.Text = "Complete Task";
            completeTaskToolStripMenuItem.Click += completedBtn_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(162, 6);
            // 
            // showRemovedToolStripMenuItem
            // 
            showRemovedToolStripMenuItem.Name = "showRemovedToolStripMenuItem";
            showRemovedToolStripMenuItem.Size = new Size(165, 22);
            showRemovedToolStripMenuItem.Text = "Show Completed";
            showRemovedToolStripMenuItem.Click += showCompletedToolStripMenuItem1_Click;
            // 
            // showCompletedToolStripMenuItem
            // 
            showCompletedToolStripMenuItem.Name = "showCompletedToolStripMenuItem";
            showCompletedToolStripMenuItem.Size = new Size(165, 22);
            showCompletedToolStripMenuItem.Text = "Show Removed";
            showCompletedToolStripMenuItem.Click += showRemovedToolStripMenuItem1_Click;
            // 
            // showOverdueToolStripMenuItem
            // 
            showOverdueToolStripMenuItem.Name = "showOverdueToolStripMenuItem";
            showOverdueToolStripMenuItem.Size = new Size(165, 22);
            showOverdueToolStripMenuItem.Text = "Show Overdue";
            showOverdueToolStripMenuItem.Click += showOverdueToolStripMenuItem1_Click;
            // 
            // completedBtn
            // 
            completedBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            completedBtn.Location = new Point(236, 113);
            completedBtn.Margin = new Padding(3, 2, 3, 2);
            completedBtn.Name = "completedBtn";
            completedBtn.Size = new Size(164, 29);
            completedBtn.TabIndex = 7;
            completedBtn.Text = "Task Completed";
            completedBtn.UseVisualStyleBackColor = true;
            completedBtn.Click += completedBtn_Click;
            // 
            // doListStrip
            // 
            doListStrip.Items.AddRange(new ToolStripItem[] { addTasksToolStripMenuItem1, showCompletedToolStripMenuItem1, showRemovedToolStripMenuItem1, showOverdueToolStripMenuItem1 });
            doListStrip.Location = new Point(0, 0);
            doListStrip.Name = "doListStrip";
            doListStrip.Size = new Size(409, 24);
            doListStrip.TabIndex = 10;
            doListStrip.Text = "menuStrip1";
            // 
            // addTasksToolStripMenuItem1
            // 
            addTasksToolStripMenuItem1.Name = "addTasksToolStripMenuItem1";
            addTasksToolStripMenuItem1.Size = new Size(70, 20);
            addTasksToolStripMenuItem1.Text = "Add tasks";
            addTasksToolStripMenuItem1.Click += addTasksBtn_Click;
            // 
            // showCompletedToolStripMenuItem1
            // 
            showCompletedToolStripMenuItem1.Name = "showCompletedToolStripMenuItem1";
            showCompletedToolStripMenuItem1.Size = new Size(110, 20);
            showCompletedToolStripMenuItem1.Text = "Show Completed";
            showCompletedToolStripMenuItem1.Click += showCompletedToolStripMenuItem1_Click;
            // 
            // showRemovedToolStripMenuItem1
            // 
            showRemovedToolStripMenuItem1.Name = "showRemovedToolStripMenuItem1";
            showRemovedToolStripMenuItem1.Size = new Size(101, 20);
            showRemovedToolStripMenuItem1.Text = "Show Removed";
            showRemovedToolStripMenuItem1.Click += showRemovedToolStripMenuItem1_Click;
            // 
            // showOverdueToolStripMenuItem1
            // 
            showOverdueToolStripMenuItem1.Name = "showOverdueToolStripMenuItem1";
            showOverdueToolStripMenuItem1.Size = new Size(96, 20);
            showOverdueToolStripMenuItem1.Text = "Show Overdue";
            showOverdueToolStripMenuItem1.Click += showOverdueToolStripMenuItem1_Click;
            // 
            // overdueLbl
            // 
            overdueLbl.AutoSize = true;
            overdueLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            overdueLbl.Location = new Point(12, 314);
            overdueLbl.Name = "overdueLbl";
            overdueLbl.Size = new Size(91, 15);
            overdueLbl.TabIndex = 12;
            overdueLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 342);
            ContextMenuStrip = doListContext;
            Controls.Add(overdueLbl);
            Controls.Add(doListStrip);
            Controls.Add(completedBtn);
            Controls.Add(doList);
            Controls.Add(datePick);
            Controls.Add(removeTasksBtn);
            Controls.Add(addTasksBtn);
            Controls.Add(label1);
            MainMenuStrip = doListStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDoList";
            Text = "To-Do List";
            doListContext.ResumeLayout(false);
            doListStrip.ResumeLayout(false);
            doListStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addTasksBtn;
        private Button removeTasksBtn;
        private DateTimePicker datePick;
        private ListBox doList;
        private ContextMenuStrip doListContext;
        private ToolStripMenuItem addTasksToolStripMenuItem;
        private Button completedBtn;
        private ToolStripMenuItem removeTaskToolStripMenuItem;
        private ToolStripMenuItem completeTaskToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem showRemovedToolStripMenuItem;
        private ToolStripMenuItem showCompletedToolStripMenuItem;
        private MenuStrip doListStrip;
        private ToolStripMenuItem showCompletedToolStripMenuItem1;
        private ToolStripMenuItem showRemovedToolStripMenuItem1;
        private ToolStripMenuItem addTasksToolStripMenuItem1;
        private ToolStripMenuItem showOverdueToolStripMenuItem;
        private ToolStripMenuItem showOverdueToolStripMenuItem1;
        private Label overdueLbl;
    }
}
