namespace LIbrary_Management_System
{
    partial class IssueLog
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
            this.IssueLogDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IssueLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueLogDataGridView
            // 
            this.IssueLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueLogDataGridView.Location = new System.Drawing.Point(38, 223);
            this.IssueLogDataGridView.Name = "IssueLogDataGridView";
            this.IssueLogDataGridView.RowTemplate.Height = 24;
            this.IssueLogDataGridView.Size = new System.Drawing.Size(1323, 401);
            this.IssueLogDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "New Book Issued",
            "Book Returned"});
            this.FilterComboBox.Location = new System.Drawing.Point(119, 34);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(200, 24);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.FilterComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterComboBox_KeyDown);
            this.FilterComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // IssueLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 673);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssueLogDataGridView);
            this.Name = "IssueLog";
            this.Text = "Issue Logs";
            this.Load += new System.EventHandler(this.IssueLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssueLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IssueLogDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterComboBox;
    }
}