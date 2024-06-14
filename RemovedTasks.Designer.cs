namespace To_Do_List
{
    partial class RemovedTasks
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
            datePicker = new DateTimePicker();
            manipulBtn = new Button();
            removedBox = new ListBox();
            label1 = new Label();
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(12, 46);
            datePicker.Margin = new Padding(3, 2, 3, 2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(175, 23);
            datePicker.TabIndex = 7;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // manipulBtn
            // 
            manipulBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            manipulBtn.Location = new Point(193, 204);
            manipulBtn.Margin = new Padding(3, 2, 3, 2);
            manipulBtn.Name = "manipulBtn";
            manipulBtn.Size = new Size(116, 27);
            manipulBtn.TabIndex = 6;
            manipulBtn.Text = "Recover Task";
            manipulBtn.UseVisualStyleBackColor = true;
            manipulBtn.Click += manipulBtn_Click;
            // 
            // removedBox
            // 
            removedBox.FormattingEnabled = true;
            removedBox.ItemHeight = 15;
            removedBox.Location = new Point(12, 71);
            removedBox.Margin = new Padding(3, 2, 3, 2);
            removedBox.Name = "removedBox";
            removedBox.Size = new Size(175, 184);
            removedBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 4;
            label1.Text = "Removed";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox.Location = new Point(193, 233);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(98, 19);
            checkBox.TabIndex = 8;
            checkBox.Text = "DELETE TASK";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // RemovedTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 264);
            Controls.Add(checkBox);
            Controls.Add(datePicker);
            Controls.Add(manipulBtn);
            Controls.Add(removedBox);
            Controls.Add(label1);
            Name = "RemovedTasks";
            Text = "Removed Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePicker;
        private Button manipulBtn;
        private ListBox removedBox;
        private Label label1;
        private CheckBox checkBox;
    }
}