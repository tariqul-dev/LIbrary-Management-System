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
    public partial class StudentLog : Form
    {
        public StudentLog()
        {
            InitializeComponent();
        }

        private void StudentLog_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_log;", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                StudentLogDataGridView.DataSource = BS;
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

        private void FilterComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Student_log where log_action like '%" + FilterComboBox.Text + "%';", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    BindingSource BS = new BindingSource();
                    BS.DataSource = dt;
                    StudentLogDataGridView.DataSource = BS;
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
        }
    }
}
