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

namespace LIbrary_Management_System
{
    public partial class IssueByUser : Form
    {
        public IssueByUser(string Sid, int BID = 0)
        {
            InitializeComponent();
            StuID = Sid;
            BookID = BID;
            IssueDateTimePicker.Value = DateTime.Now;
        }

        string StuID;
        int BookID;




        



        private void IssueByUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + StuID + "';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                int i = 0;

                i = Convert.ToInt16(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        StuNameTextBox.Text = dr[1].ToString();
                        StuDeptTextBox.Text = dr[7].ToString();
                        StuContTextBox.Text = dr[5].ToString();
                        StuEmailTextBox.Text = dr[6].ToString();

                    }
                    
                }


                con.Close();

                if (BookID != 0)
                {
                    con.Open();
                    SqlCommand acmd = new SqlCommand("select * from BooksInfo where ID = " + BookID + "", con);
                    SqlDataReader sqReader = acmd.ExecuteReader();
                    if (sqReader.Read())
                    {
                        BookNameTextBox.Text = sqReader[1].ToString();
                        BookNameTextBox.ReadOnly = true;
                        RemainDayTextBox.TabIndex = 0;
                    }
                    con.Close();
                }
                else
                {
                    BookNameTextBox.TabIndex = 0;
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

        private void IssueButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {

               
                con.Open();
                SqlCommand scmd = new SqlCommand("select * from BooksInfo where BookName = '" + BookNameTextBox.Text + "'", con);
                SqlDataReader sdr = scmd.ExecuteReader();



                int AvailableBook = 0;
                int id = 0;

                if (sdr.Read())
                {
                    AvailableBook = Convert.ToInt32(sdr[6]);
                    id = Convert.ToInt16(sdr[0]);
                }

                con.Close();

                if (AvailableBook != 0)
                {
                    con.Open();
                    SqlCommand sscmd = new SqlCommand("select * from Issue_book where StuID = '" + StuID + "' and BookID = " + id + ";", con);
                    SqlDataReader sReader = sscmd.ExecuteReader();
                    int count = 0;

                    while (sReader.Read())
                    {
                        count++;
                    }
                    con.Close();

                    if (count == 0)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Issue_book(StuID ,StuName, StuDept, StuContact, StuEmail, BookID, BookName, BookIssueDate, RemainDay) values('" + StuID + "', '" + StuNameTextBox.Text + "', '" + StuDeptTextBox.Text + "', '" + StuContTextBox.Text + "', '" + StuEmailTextBox.Text + "', " + id + ", '" + BookNameTextBox.Text + "', '" + IssueDateTimePicker.Value.ToString() + "', '" + Convert.ToInt16(RemainDayTextBox.Text) + "');", con);
                        cmd.ExecuteNonQuery();


                        con.Close();

                        MessageBox.Show("Book is successfully issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Open();
                        AvailableBook--;
                        SqlCommand ucmd = new SqlCommand("update BooksInfo set AvailableQnt = " + AvailableBook + " where BookName = '" + BookNameTextBox.Text + "'", con);
                        ucmd.ExecuteNonQuery();
                        con.Close();
                    }

                    else if (count > 0)
                    {
                        MessageBox.Show("You have issued this book once but did not return. So return first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                else
                {
                    MessageBox.Show("This book is not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            

           
            BookNameTextBox.Clear();
        }

        private void BookNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                BookListBox.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from BooksInfo where BookName like '%" + BookNameTextBox.Text + "%';", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    int i = 0;

                    i = Convert.ToInt16(dt.Rows.Count.ToString());

                    if (i > 0)
                    {
                        BookListBox.Visible = true;
                        foreach (DataRow dr in dt.Rows)
                        {
                            BookListBox.Items.Add(dr[1]).ToString();

                        }
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
        }

        private void BookNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    BookListBox.Focus();
                    BookListBox.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BookNameTextBox.Text = BookListBox.SelectedItem.ToString();
                    BookListBox.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {   BookNameTextBox.Text = BookListBox.SelectedItem.ToString();
                BookListBox.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
