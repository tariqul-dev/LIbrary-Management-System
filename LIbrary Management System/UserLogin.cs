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
    public partial class UserLogin : Form
    {
        public UserLogin()
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
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + StuIDTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", con);

                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    MessageBox.Show("ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (count == 1)
                {
                    this.Hide();
                    UserMDI mu = new UserMDI(StuIDTextBox.Text);
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            Student_info si = new Student_info();
            si.Show();
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
    }
}
