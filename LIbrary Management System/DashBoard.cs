using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LIbrary_Management_System
{
    public partial class DashBoard : Form
    {
        public DashBoard(string sid)
        {
            InitializeComponent();
            StuID = sid;
        }

        string StuID;
        void BookIssueStudent()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Issue_book where StuID = '" + StuID + "';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                CheckDataGridView.DataSource = BS;
                sda.Update(dt);

                TotalBookLabel.Text = (CheckDataGridView.Rows.Count - 1).ToString();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        


        private void DashBoard_Load(object sender, EventArgs e)
        {
            BookIssueStudent();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {

                InfoPanel.Visible = true;
                con.Open();
                SqlCommand dcmd = new SqlCommand("select * from Student_table where StuID = '" + StuID + "'; ", con);
                SqlDataReader MyReader = dcmd.ExecuteReader();
                if (MyReader.Read())
                {
                    IDLabel.Text = MyReader[0].ToString();
                    NameLabel.Text = MyReader[1].ToString();
                    DeptLabel.Text = MyReader[7].ToString();
                    ContactLabel.Text = MyReader[5].ToString();
                    EmailLabel.Text = MyReader[6].ToString();
                }

                con.Close();


                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + StuID + "'; ", con);
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                if (Reader.HasRows)
                {
                    byte[] image = (byte[])Reader[8];

                    if (image == null)
                    {
                        StuPictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream MS = new MemoryStream(image);
                        StuPictureBox.Image = Image.FromStream(MS);
                    }
                }
                else
                {
                    MessageBox.Show("Not available....");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        int RemainDay;
        string GetDate = "";

        private void CheckDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MSGTextBox.Visible = false;
            DataGridViewRow row = this.CheckDataGridView.Rows[e.RowIndex];

            BookIDLabel.Text = row.Cells[5].FormattedValue.ToString();
            BookNameLabel.Text = row.Cells[6].FormattedValue.ToString();
            IssueDateLabel.Text = row.Cells[7].FormattedValue.ToString();
            GetDate = row.Cells[7].FormattedValue.ToString();
            RemainDay = Convert.ToInt16(row.Cells[9].FormattedValue.ToString());

            DateTime IssueDate = Convert.ToDateTime(GetDate);
            DateTime CurrentDate = DateTime.Now;
            TimeSpan ts = CurrentDate - IssueDate;
            int day = Convert.ToInt16(ts.TotalDays);
            if (day >= RemainDay - 1)
            {
                MSGTextBox.Visible = true;
                int LateDay = RemainDay - day;
                if (LateDay < 0)
                {
                    MSGTextBox.Text = "Book return fail in time. Return this book as soon as possible with 10 tk per day as late fee. So, if you return \r\n'" + BookNameLabel.Text + "'\r\nthis book today, you have to pay " + (-1 * LateDay) * 10 + " tk for " + (-1 * LateDay) + " days late\r\nThank you";
                }
                else
                {
                    MSGTextBox.Text = "You have " + (RemainDay - day).ToString() + " days to return \r\n'" + BookNameLabel.Text + "'\r\nThank you";
                }
            }
        }

        private void ReturrnButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            
            try
            {
                string BookReturnDate = "";
                DateTime IssueDate = Convert.ToDateTime(IssueDateLabel.Text);
                DateTime ReturnDate = ReturnDateTimePicker.Value;
                TimeSpan ts = ReturnDate - IssueDate;
                int day = Convert.ToInt16(ts.TotalDays);

                if (day >= 0)
                {
                    con.Open();
                    SqlCommand ckcmd = new SqlCommand("select * from Issue_book where StuID = '" + IDLabel.Text + "' and BookID = '" + BookIDLabel.Text + "'", con);
                    SqlDataReader reader = ckcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        BookReturnDate = reader[8].ToString();
                    }
                    con.Close();


                    if (BookReturnDate == "")
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("update Issue_book set BookReturnDate = '" + ReturnDateTimePicker.Value.ToString() + "' where BookID = '" + BookIDLabel.Text + "' and StuID = '" + IDLabel.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        SqlCommand dcmd = new SqlCommand("delete from Issue_book where BookID = '" + BookIDLabel.Text + "' and StuID = '" + IDLabel.Text + "'", con);
                        dcmd.ExecuteNonQuery();
                        TotalBookLabel.Text = (CheckDataGridView.Rows.Count - 1).ToString();
                        con.Close();


                        con.Open();
                        SqlCommand acmd = new SqlCommand("update BooksInfo set AvailableQnt +=1 where ID = '" + BookIDLabel.Text + "' ; ", con);
                        acmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Book returned successfullly");
                        BookIssueStudent();
                    }
                    else
                    {
                        MessageBox.Show("This book is already returned!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Insert correct date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                MSGTextBox.Visible = true;
                MSGTextBox.Text = "Thank you for being with us! :)";
            }
        }
    }
}
