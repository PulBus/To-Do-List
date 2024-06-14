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
            doListMenu = new ContextMenuStrip(components);
            addTasksToolStripMenuItem = new ToolStripMenuItem();
            completedBtn = new Button();
            completedChk = new CheckBox();
            removedChk = new CheckBox();
            doListMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(113, 45);
            label1.TabIndex = 1;
            label1.Text = "To-Do";
            // 
            // addTasksBtn
            // 
            addTasksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addTasksBtn.Location = new Point(235, 198);
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
            removeTasksBtn.Location = new Point(235, 229);
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
            datePick.Location = new Point(10, 58);
            datePick.Margin = new Padding(3, 2, 3, 2);
            datePick.Name = "datePick";
            datePick.Size = new Size(219, 23);
            datePick.TabIndex = 5;
            datePick.ValueChanged += datePick_ValueChanged;
            // 
            // doList
            // 
            doList.ContextMenuStrip = doListMenu;
            doList.FormattingEnabled = true;
            doList.ItemHeight = 15;
            doList.Location = new Point(10, 82);
            doList.Margin = new Padding(3, 2, 3, 2);
            doList.Name = "doList";
            doList.Size = new Size(219, 199);
            doList.TabIndex = 6;
            // 
            // doListMenu
            // 
            doListMenu.ImageScalingSize = new Size(20, 20);
            doListMenu.Items.AddRange(new ToolStripItem[] { addTasksToolStripMenuItem });
            doListMenu.Name = "doListMenu";
            doListMenu.Size = new Size(127, 26);
            // 
            // addTasksToolStripMenuItem
            // 
            addTasksToolStripMenuItem.Name = "addTasksToolStripMenuItem";
            addTasksToolStripMenuItem.Size = new Size(126, 22);
            addTasksToolStripMenuItem.Text = "Add Tasks";
            addTasksToolStripMenuItem.Click += addTasksBtn_Click;
            // 
            // completedBtn
            // 
            completedBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            completedBtn.Location = new Point(234, 82);
            completedBtn.Margin = new Padding(3, 2, 3, 2);
            completedBtn.Name = "completedBtn";
            completedBtn.Size = new Size(164, 29);
            completedBtn.TabIndex = 7;
            completedBtn.Text = "Task Completed";
            completedBtn.UseVisualStyleBackColor = true;
            completedBtn.Click += completedBtn_Click;
            // 
            // completedChk
            // 
            completedChk.AutoSize = true;
            completedChk.Location = new Point(240, 116);
            completedChk.Margin = new Padding(3, 2, 3, 2);
            completedChk.Name = "completedChk";
            completedChk.Size = new Size(147, 19);
            completedChk.TabIndex = 8;
            completedChk.Text = "Show Completed Tasks";
            completedChk.UseVisualStyleBackColor = true;
            completedChk.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // removedChk
            // 
            removedChk.AutoSize = true;
            removedChk.Location = new Point(235, 262);
            removedChk.Margin = new Padding(3, 2, 3, 2);
            removedChk.Name = "removedChk";
            removedChk.Size = new Size(138, 19);
            removedChk.TabIndex = 9;
            removedChk.Text = "Show Removed Tasks";
            removedChk.UseVisualStyleBackColor = true;
            removedChk.CheckedChanged += removedChk_CheckedChanged;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 301);
            Controls.Add(removedChk);
            Controls.Add(completedChk);
            Controls.Add(completedBtn);
            Controls.Add(doList);
            Controls.Add(datePick);
            Controls.Add(removeTasksBtn);
            Controls.Add(addTasksBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDoList";
            Text = "Form1";
            doListMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addTasksBtn;
        private Button removeTasksBtn;
        private DateTimePicker datePick;
        private ListBox doList;
        private ContextMenuStrip doListMenu;
        private ToolStripMenuItem addTasksToolStripMenuItem;
        private Button completedBtn;
        private CheckBox completedChk;
        private CheckBox removedChk;
    }
}
