namespace To_Do_List
{
    partial class OverdueTasks
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
            overdueBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // overdueBox
            // 
            overdueBox.FormattingEnabled = true;
            overdueBox.ItemHeight = 15;
            overdueBox.Location = new Point(12, 43);
            overdueBox.Margin = new Padding(3, 2, 3, 2);
            overdueBox.Name = "overdueBox";
            overdueBox.SelectionMode = SelectionMode.None;
            overdueBox.Size = new Size(363, 184);
            overdueBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 10;
            label1.Text = "Overdue";
            // 
            // OverdueTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 243);
            Controls.Add(label1);
            Controls.Add(overdueBox);
            Name = "OverdueTasks";
            Text = "Overdue Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox overdueBox;
        private Label label1;
    }
}