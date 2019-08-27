namespace LIbrary_Management_System
{
    partial class Issue_book
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.StuDeptTextBox = new System.Windows.Forms.TextBox();
            this.StuNameTextBox = new System.Windows.Forms.TextBox();
            this.StuEmailTextBox = new System.Windows.Forms.TextBox();
            this.StuContTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.IssueButton = new System.Windows.Forms.Button();
            this.StuListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RemainDayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(41, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(126, 33);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(197, 40);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(190, 22);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.SearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyUp);
            // 
            // StuDeptTextBox
            // 
            this.StuDeptTextBox.Location = new System.Drawing.Point(675, 106);
            this.StuDeptTextBox.Name = "StuDeptTextBox";
            this.StuDeptTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuDeptTextBox.TabIndex = 2;
            // 
            // StuNameTextBox
            // 
            this.StuNameTextBox.Location = new System.Drawing.Point(675, 62);
            this.StuNameTextBox.Name = "StuNameTextBox";
            this.StuNameTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuNameTextBox.TabIndex = 2;
            // 
            // StuEmailTextBox
            // 
            this.StuEmailTextBox.Location = new System.Drawing.Point(675, 187);
            this.StuEmailTextBox.Name = "StuEmailTextBox";
            this.StuEmailTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuEmailTextBox.TabIndex = 2;
            // 
            // StuContTextBox
            // 
            this.StuContTextBox.Location = new System.Drawing.Point(675, 149);
            this.StuContTextBox.Name = "StuContTextBox";
            this.StuContTextBox.Size = new System.Drawing.Size(245, 22);
            this.StuContTextBox.TabIndex = 2;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(675, 270);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(245, 22);
            this.BookNameTextBox.TabIndex = 3;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.BookNameTextBox_TextChanged);
            this.BookNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookNameTextBox_KeyDown);
            this.BookNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BookNameTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Book issue date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book name";
            // 
            // IssueDateTimePicker
            // 
            this.IssueDateTimePicker.Location = new System.Drawing.Point(675, 228);
            this.IssueDateTimePicker.Name = "IssueDateTimePicker";
            this.IssueDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.IssueDateTimePicker.TabIndex = 4;
            this.IssueDateTimePicker.Value = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 16;
            this.BookListBox.Location = new System.Drawing.Point(676, 302);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(244, 68);
            this.BookListBox.TabIndex = 5;
            this.BookListBox.Visible = false;
            this.BookListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookListBox_MouseClick);
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            this.BookListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookListBox_KeyDown);
            // 
            // IssueButton
            // 
            this.IssueButton.Location = new System.Drawing.Point(376, 455);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(285, 42);
            this.IssueButton.TabIndex = 5;
            this.IssueButton.Text = "Issue";
            this.IssueButton.UseVisualStyleBackColor = true;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // StuListBox
            // 
            this.StuListBox.FormattingEnabled = true;
            this.StuListBox.ItemHeight = 16;
            this.StuListBox.Location = new System.Drawing.Point(197, 68);
            this.StuListBox.Name = "StuListBox";
            this.StuListBox.Size = new System.Drawing.Size(190, 84);
            this.StuListBox.TabIndex = 6;
            this.StuListBox.Visible = false;
            this.StuListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.StuListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "How many days you want to keep this book?";
            // 
            // RemainDayTextBox
            // 
            this.RemainDayTextBox.Location = new System.Drawing.Point(41, 337);
            this.RemainDayTextBox.Name = "RemainDayTextBox";
            this.RemainDayTextBox.Size = new System.Drawing.Size(245, 22);
            this.RemainDayTextBox.TabIndex = 7;
            // 
            // Issue_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 536);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemainDayTextBox);
            this.Controls.Add(this.StuListBox);
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
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Issue_book";
            this.Text = "Issue Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox StuDeptTextBox;
        private System.Windows.Forms.TextBox StuNameTextBox;
        private System.Windows.Forms.TextBox StuEmailTextBox;
        private System.Windows.Forms.TextBox StuContTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker IssueDateTimePicker;
        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.Button IssueButton;
        private System.Windows.Forms.ListBox StuListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RemainDayTextBox;
    }
}