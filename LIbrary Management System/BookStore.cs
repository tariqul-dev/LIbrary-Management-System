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
    public partial class BookStore : Form
    {
        public BookStore()
        {
            InitializeComponent();
        }

        int BookID;
        private void BookStore_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BooksInfo", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                BookInfoDataGridView.DataSource = BS;
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
        

        private void BookInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
            
            try
            {
                DataGridViewRow row = BookInfoDataGridView.Rows[e.RowIndex];
                BookID = Convert.ToInt16(row.Cells[0].FormattedValue.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Issue_book where BookID = " + BookID + ";", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                StudentInfoDataGridView.DataSource = BS;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BooksInfo where BookName like '%" + SearchTextBox.Text + "%';";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                BookInfoDataGridView.DataSource = dt;
                

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


        string StuID = "";
        int RemainDay;
        string GetDate = "";
        string BookName = "";

        private void StudentInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.StudentInfoDataGridView.Rows[e.RowIndex];
            StuID = row.Cells[0].FormattedValue.ToString();
            BookName = row.Cells[6].FormattedValue.ToString();
            GetDate = row.Cells[7].FormattedValue.ToString();
            RemainDay = Convert.ToInt16(row.Cells[9].FormattedValue.ToString());

            DateTime IssueDate = Convert.ToDateTime(GetDate);
            DateTime CurrentDate = DateTime.Now;
            TimeSpan ts = CurrentDate - IssueDate;
            int day = Convert.ToInt16(ts.TotalDays);

            if (day >= RemainDay-1)
            {
                MessageBox.Show("You have " + (day - RemainDay).ToString() + " to return \n" + BookName + "\nthis book");

            }
        }
    }
}
