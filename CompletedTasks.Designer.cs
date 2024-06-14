namespace To_Do_List
{
    partial class CompletedTasks
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
            label1 = new Label();
            completedBox = new ListBox();
            removeBtn = new Button();
            datePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Completed";
            // 
            // completedBox
            // 
            completedBox.FormattingEnabled = true;
            completedBox.ItemHeight = 15;
            completedBox.Location = new Point(10, 70);
            completedBox.Margin = new Padding(3, 2, 3, 2);
            completedBox.Name = "completedBox";
            completedBox.Size = new Size(175, 184);
            completedBox.TabIndex = 1;
            // 
            // removeBtn
            // 
            removeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            removeBtn.Location = new Point(190, 224);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(116, 29);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove Task";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(10, 45);
            datePicker.Margin = new Padding(3, 2, 3, 2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(175, 23);
            datePicker.TabIndex = 3;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // CompletedTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 264);
            Controls.Add(datePicker);
            Controls.Add(removeBtn);
            Controls.Add(completedBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CompletedTasks";
            Text = "Completed Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox completedBox;
        private Button removeBtn;
        private DateTimePicker datePicker;
    }
}