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
    public partial class Student_info : Form
    {
        public Student_info()
        {
            InitializeComponent();
        }
        string ImageLocation = "";
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "JPG Files(*.jpg) | *.jpg | JPEG Files(*.jpeg) | *.jpeg | PNG Files(*.png) | *.png | All files(*.*) | *.*";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = FileDialog.FileName.ToString();
                StuPictureBox.ImageLocation = ImageLocation;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        
        public bool IdentityCheck()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
            int count = 0;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + StuIDTextBox.Text + "'", con);
                SqlDataReader Reader = cmd.ExecuteReader();

                

                while (Reader.Read())
                {
                    count++;
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

            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        string gender;
        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (IdentityCheck())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
                try
                {
                    if (ImageLocation != "")
                    {
                        con.Open();

                        byte[] image = null;
                        FileStream stream = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader BR = new BinaryReader(stream);
                        image = BR.ReadBytes((int)stream.Length);



                        SqlCommand cmd = new SqlCommand("insert into Student_table values('" + StuIDTextBox.Text + "', '" + StuNameTextBox.Text + "'," + StuAgeTextBox.Text + ",'" + gender + "', '" + StuSemTextBox.Text + "','" + StuContactTextBox.Text + "','" + StuEmailTextBox.Text + "', '" + DeptComboBox.Text + "', @image, '" + PasswordTextBox.Text + "')", con);
                        cmd.Parameters.Add(new SqlParameter("@image", image));
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Successfully data added...");
                    }
                    else if (ImageLocation == "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Student_table(StuID, Name, Age, Gender, Semester, Contact, Email, Dept, Password) values('" + StuIDTextBox.Text + "', '" + StuNameTextBox.Text + "'," + StuAgeTextBox.Text + ",'" + gender + "', '" + StuSemTextBox.Text + "','" + StuContactTextBox.Text + "','" + StuEmailTextBox.Text + "', '" + DeptComboBox.Text + "', '" + PasswordTextBox.Text + "');", con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Successfully data added...");
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
            else
            {
                MessageBox.Show("This Student ID is used with another name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            StudentView sv = new StudentView();
            sv.Show();
        }
    }
}
