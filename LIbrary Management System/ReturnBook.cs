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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            ReturnDateTimePicker.Value = DateTime.Now;
        }


        void BookIssueStudent()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("exec GetIssueBookStudentInfo;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                CheckDataGridView.DataSource = BS;
                sda.Update(dt);


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


        void ViewByClick()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                InfoPanel.Visible = true;
                IDLabel.Text = row.Cells[0].FormattedValue.ToString();
                NameLabel.Text = row.Cells[1].FormattedValue.ToString();
                DeptLabel.Text = row.Cells[2].FormattedValue.ToString();
                ContactLabel.Text = row.Cells[3].FormattedValue.ToString();
                EmailLabel.Text = row.Cells[4].FormattedValue.ToString();
                BookIDLabel.Text = row.Cells[5].FormattedValue.ToString();
                BookNameLabel.Text = row.Cells[6].FormattedValue.ToString();
                IssueDateLabel.Text = row.Cells[7].FormattedValue.ToString();

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + IDLabel.Text + "'; ", con);
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
            finally
            {
                con.Close();
            }
        }

        DataGridViewRow row;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            row = this.CheckDataGridView.Rows[e.RowIndex];

            ViewByClick();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("exec GetIssueBookStudentInfoBySearch '" + StuIDTextBox.Text + "';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                CheckDataGridView.DataSource = BS;
                sda.Update(dt);


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

        private void ReturrnButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            

            try
            {
                string BookReturnDate = "";
                DateTime IssueDate = Convert.ToDateTime(IssueDateLabel.Text);
                DateTime ReturnDate = ReturnDateTimePicker.Value;
                TimeSpan ts = ReturnDate - IssueDate;
                int day =Convert.ToInt16(ts.TotalDays);

                con.Open();
                SqlCommand ckcmd = new SqlCommand("select * from Issue_book where StuID = '" + IDLabel.Text + "' and BookID = '" + BookIDLabel.Text + "'", con);
                SqlDataReader reader = ckcmd.ExecuteReader();
                if (reader.Read())
                {
                    BookReturnDate = reader[8].ToString();
                }
                con.Close();

                if (day >= 0)
                {
                    if (BookReturnDate == "")
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("update Issue_book set BookReturnDate = '" + ReturnDateTimePicker.Value.ToString() + "' where BookID = '" + BookIDLabel.Text + "' and StuID = '" + IDLabel.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        SqlCommand dcmd = new SqlCommand("delete from Issue_book where BookID = '" + BookIDLabel.Text + "' and StuID = '" + IDLabel.Text + "'", con);
                        dcmd.ExecuteNonQuery();
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
            }

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            BookIssueStudent();
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
