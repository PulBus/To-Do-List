namespace To_Do_List
{
    partial class AddTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toAdd = new TextBox();
            label1 = new Label();
            enterBtn = new Button();
            closeBtn = new Button();
            startDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // toAdd
            // 
            toAdd.Font = new Font("Segoe UI", 12F);
            toAdd.Location = new Point(37, 109);
            toAdd.Margin = new Padding(3, 2, 3, 2);
            toAdd.Name = "toAdd";
            toAdd.Size = new Size(228, 29);
            toAdd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 1;
            label1.Text = "Task to add:";
            // 
            // enterBtn
            // 
            enterBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            enterBtn.Location = new Point(37, 139);
            enterBtn.Margin = new Padding(3, 2, 3, 2);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(82, 22);
            enterBtn.TabIndex = 2;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            closeBtn.Location = new Point(182, 139);
            closeBtn.Margin = new Padding(3, 2, 3, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(82, 22);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // startDate
            // 
            startDate.Location = new Point(84, 42);
            startDate.Name = "startDate";
            startDate.Size = new Size(200, 23);
            startDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 77);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Due Date:";
            // 
            // dueDate
            // 
            dueDate.Location = new Point(84, 71);
            dueDate.Name = "dueDate";
            dueDate.Size = new Size(200, 23);
            dueDate.TabIndex = 6;
            // 
            // AddTasksForm
            // 
            AcceptButton = enterBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeBtn;
            ClientSize = new Size(301, 187);
            Controls.Add(label3);
            Controls.Add(dueDate);
            Controls.Add(label2);
            Controls.Add(startDate);
            Controls.Add(closeBtn);
            Controls.Add(enterBtn);
            Controls.Add(label1);
            Controls.Add(toAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddTasksForm";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox toAdd;
        private Label label1;
        private Button enterBtn;
        private Button closeBtn;
        private DateTimePicker startDate;
        private Label label2;
        private Label label3;
        private DateTimePicker dueDate;
    }
}