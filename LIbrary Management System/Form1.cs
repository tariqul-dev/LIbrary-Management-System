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
    public partial class LoginForm : Form
    {

       
        public LoginForm()
        {
            InitializeComponent();
        }


        private void Login()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
            int count = 0;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Admin_table where Username = '" + UsernameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", con);

                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    MessageBox.Show("ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(count == 1)
                {
                    this.Hide();
                    AdminMDI mu = new AdminMDI();
                    mu.Show();
                }
                else
                {
                    MessageBox.Show("Contact your admin", "At Risk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            Login();
        }
    }
}
