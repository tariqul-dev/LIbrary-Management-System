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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into BooksInfo values('" + BookNameTextBox.Text + "', '" + AuthorNameTextBox.Text + "', '" + dateTimePicker1.Text + "', " + PriceTextBox.Text + ", " + QuantityTextBox.Text + ", " + QuantityTextBox.Text + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book is successfully added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            BookNameTextBox.Clear();
            AuthorNameTextBox.Clear();
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}
