namespace LIbrary_Management_System
{
    partial class BookStore
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
            this.BookInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookInfoDataGridView
            // 
            this.BookInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookInfoDataGridView.Location = new System.Drawing.Point(276, 29);
            this.BookInfoDataGridView.Name = "BookInfoDataGridView";
            this.BookInfoDataGridView.RowTemplate.Height = 24;
            this.BookInfoDataGridView.Size = new System.Drawing.Size(745, 224);
            this.BookInfoDataGridView.TabIndex = 0;
            this.BookInfoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookInfoDataGridView_CellClick);
            // 
            // StudentInfoDataGridView
            // 
            this.StudentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfoDataGridView.Location = new System.Drawing.Point(276, 279);
            this.StudentInfoDataGridView.Name = "StudentInfoDataGridView";
            this.StudentInfoDataGridView.RowTemplate.Height = 24;
            this.StudentInfoDataGridView.Size = new System.Drawing.Size(745, 224);
            this.StudentInfoDataGridView.TabIndex = 0;
            this.StudentInfoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentInfoDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 139);
            this.panel1.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 30);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(8, 47);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(174, 22);
            this.SearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book name";
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentInfoDataGridView);
            this.Controls.Add(this.BookInfoDataGridView);
            this.Name = "BookStore";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.BookStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookInfoDataGridView;
        private System.Windows.Forms.DataGridView StudentInfoDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
    }
}