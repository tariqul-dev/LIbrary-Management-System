namespace LIbrary_Management_System
{
    partial class StudentLog
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
            this.StudentLogDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLogDataGridView
            // 
            this.StudentLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentLogDataGridView.Location = new System.Drawing.Point(21, 134);
            this.StudentLogDataGridView.Name = "StudentLogDataGridView";
            this.StudentLogDataGridView.RowTemplate.Height = 24;
            this.StudentLogDataGridView.Size = new System.Drawing.Size(1393, 428);
            this.StudentLogDataGridView.TabIndex = 1;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Inserted Record",
            "Updated Record",
            "Deleted Record"});
            this.FilterComboBox.Location = new System.Drawing.Point(111, 43);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(200, 24);
            this.FilterComboBox.TabIndex = 6;
            this.FilterComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterComboBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter:";
            // 
            // StudentLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 606);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentLogDataGridView);
            this.Name = "StudentLog";
            this.Text = "Student Logs";
            this.Load += new System.EventHandler(this.StudentLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentLogDataGridView;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label1;
    }
}