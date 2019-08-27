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
    public partial class Update : Form
    {

        public Update()
        {
            InitializeComponent();
            ViewBooks();
        }


        void ViewBooks()
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

        private void Update_Load(object sender, EventArgs e)
        {
            
        }
        

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete selected data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from BooksInfo where ID = " + id + ";", con);
                    cmd.ExecuteNonQuery();

                    TotalBookLabel.Text = (dataGridView1.Rows.Count - 1).ToString();
                    con.Close();
                    ViewBooks();
                    MessageBox.Show("Data has been deleted!");

                    

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

        private void SearchButton_Click_1(object sender, EventArgs e)
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


        int id;

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to update seleted data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update BooksInfo set BookName = '" + BookNameTextBox.Text + "', BookAuthorName = '" + AuthorNameTextBox.Text + "',BookPurchaseDate = '" + dateTimePicker1.Value + "', BookPrice = " + PriceTextBox.Text + ",BookQuantity = " + QuantityTextBox.Text + " where ID= " + id + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ViewBooks();
                    MessageBox.Show("Books are Updated");
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                BookNameTextBox.Text = row.Cells[1].FormattedValue.ToString();
                AuthorNameTextBox.Text = row.Cells[2].FormattedValue.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].FormattedValue.ToString());
                PriceTextBox.Text = row.Cells[4].FormattedValue.ToString();
                QuantityTextBox.Text = row.Cells[5].FormattedValue.ToString();
                id = Convert.ToInt16(row.Cells[0].FormattedValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ViewBooks();
        }
    }
}
