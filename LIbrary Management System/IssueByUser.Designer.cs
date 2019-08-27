namespace LIbrary_Management_System
{
    partial class IssueByUser
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
            this.label7 = new System.Windows.Forms.Label();
            this.RemainDayTextBox = new System.Windows.Forms.TextBox();
            this.IssueButton = new System.Windows.Forms.Button();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.StuContTextBox = new System.Windows.Forms.TextBox();
            this.StuEmailTextBox = new System.Windows.Forms.TextBox();
            this.StuNameTextBox = new System.Windows.Forms.TextBox();
            this.StuDeptTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "How many days you want to keep this book?";
            // 
            // RemainDayTextBox
            // 
            this.RemainDayTextBox.Location = new System.Drawing.Point(121, 405);
            this.RemainDayTextBox.Name = "RemainDayTextBox";
            this.RemainDayTextBox.Size = new System.Drawing.Size(245, 22);
            this.RemainDayTextBox.TabIndex = 1;
            // 
            // IssueButton
            // 
            this.IssueButton.Location = new System.Drawing.Point(159, 491);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(285, 42);
            this.IssueButton.TabIndex = 2;
            this.IssueButton.Text = "Issue";
            this.IssueButton.UseVisualStyleBackColor = true;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 16;
            this.BookListBox.Location = new System.Drawing.Point(283, 278);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(244, 68);
            this.BookListBox.TabIndex = 23;
            this.BookListBox.Visible = false;
            this.BookListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookListBox_MouseClick);
            this.BookListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookListBox_KeyDown);
            // 
            // IssueDateTimePicker
            // 
            this.IssueDateTimePicker.Location = new System.Drawing.Point(282, 204);
            this.IssueDateTimePicker.Name = "IssueDateTimePicker";
            this.IssueDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.IssueDateTimePicker.TabIndex = 22;
            this.IssueDateTimePicker.Value = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Book name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Book issue date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Student department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Student Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student name";
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(282, 246);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(245, 22);
            this.BookNameTextBox.TabIndex = 19;
            this.BookNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookNameTextBox_KeyDown);
            this.BookNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BookNameTextBox_KeyUp);
            // 
            // StuContTextBox
            // 
            this.StuContTextBox.Location = new System.Drawing.Point(282, 125);
            this.StuContTextBox.Name = "StuContTextBox";
            this.StuContTextBox.ReadOnly = true;
            this.StuContTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuContTextBox.TabIndex = 14;
            // 
            // StuEmailTextBox
            // 
            this.StuEmailTextBox.Location = new System.Drawing.Point(282, 163);
            this.StuEmailTextBox.Name = "StuEmailTextBox";
            this.StuEmailTextBox.ReadOnly = true;
            this.StuEmailTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuEmailTextBox.TabIndex = 13;
            // 
            // StuNameTextBox
            // 
            this.StuNameTextBox.Location = new System.Drawing.Point(282, 38);
            this.StuNameTextBox.Name = "StuNameTextBox";
            this.StuNameTextBox.ReadOnly = true;
            this.StuNameTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuNameTextBox.TabIndex = 12;
            // 
            // StuDeptTextBox
            // 
            this.StuDeptTextBox.Location = new System.Drawing.Point(282, 82);
            this.StuDeptTextBox.Name = "StuDeptTextBox";
            this.StuDeptTextBox.ReadOnly = true;
            this.StuDeptTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuDeptTextBox.TabIndex = 11;
            // 
            // IssueByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 568);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemainDayTextBox);
            this.Controls.Add(this.IssueButton);
            this.Controls.Add(this.BookListBox);
            this.Controls.Add(this.IssueDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.StuContTextBox);
            this.Controls.Add(this.StuEmailTextBox);
            this.Controls.Add(this.StuNameTextBox);
            this.Controls.Add(this.StuDeptTextBox);
            this.Name = "IssueByUser";
            this.Text = "IssueByUser";
            this.Load += new System.EventHandler(this.IssueByUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RemainDayTextBox;
        private System.Windows.Forms.Button IssueButton;
        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.DateTimePicker IssueDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox StuContTextBox;
        private System.Windows.Forms.TextBox StuEmailTextBox;
        private System.Windows.Forms.TextBox StuNameTextBox;
        private System.Windows.Forms.TextBox StuDeptTextBox;
    }
}