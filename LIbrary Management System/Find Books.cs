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
    public partial class Find_Books : Form
    {
        public Find_Books(string Sid)
        {
            InitializeComponent();
            StuID = Sid;
        }

        string StuID;
        int BookID;
       public void ViewBooks()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID, BookName as 'Name', BookAuthorName as 'Author Name', BookPurchaseDate as 'Purchase Date', BookPrice as 'Price', BookQuantity as 'Quantity', AvailableQnt as 'Available Book' from BooksInfo;";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                dataGridView1.DataSource = BS;
                sda.Update(dt);
                

                con.Close();

                TotalBookLabel.Text = (dataGridView1.Rows.Count - 1).ToString();

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

        private void Find_Books_Load(object sender, EventArgs e)
        {
            ViewBooks();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID, BookName as 'Name', BookAuthorName as 'Author Name', BookPurchaseDate as 'Purchase Date', BookPrice as 'Price', BookQuantity as 'Quantity', AvailableQnt as 'Available Book' from BooksInfo where BookName like '%" + SearchTextBox.Text + "%';";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
               

                TotalBookLabel.Text = (dataGridView1.Rows.Count - 1).ToString();

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

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            IssueByUser ibu = new IssueByUser(StuID, BookID);
            ibu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookID = Convert.ToInt16(this.dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ViewBooks();
        }
    }
}
