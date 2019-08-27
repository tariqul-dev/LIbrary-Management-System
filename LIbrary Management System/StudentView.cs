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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }


        
        void ViewStudents()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select StuID, Name, Age, Gender, Semester, Contact, Email, Dept, Password from Student_table;", con);
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

                CountLabel.Text = (dataGridView1.Rows.Count - 1).ToString();

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

        private void StudentView_Load(object sender, EventArgs e)
        {
            ViewStudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            string gender = "";

            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                StuIDTextBox.Text = row.Cells[0].FormattedValue.ToString();
                StuNameTextBox.Text = row.Cells[1].FormattedValue.ToString();
                StuAgeTextBox.Text = row.Cells[2].FormattedValue.ToString();
                gender = row.Cells[3].FormattedValue.ToString();
                StuSemTextBox.Text = row.Cells[4].FormattedValue.ToString();
                StuContactTextBox.Text = row.Cells[5].FormattedValue.ToString();
                StuEmailTextBox.Text = row.Cells[6].FormattedValue.ToString();
                DeptComboBox.Text = row.Cells[7].FormattedValue.ToString();

                if (gender == "Male")
                {
                    MaleRadioButton.Focus();
                }
                if (gender == "Female")
                {
                    FemaleRadioButton.Focus();
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student_table where StuID = '" + StuIDTextBox.Text + "'; ", con);
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                PasswordTextBox.Text = Reader[9].ToString();

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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to update select information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
                try
                {
                    con.Open();
                    if (ImageLocation != "")
                    {
                        byte[] image = null;
                        FileStream stream = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader BR = new BinaryReader(stream);
                        image = BR.ReadBytes((int)stream.Length);


                        string gender = "";
                        if (MaleRadioButton.Checked)
                        {
                            gender = "Male";
                        }
                        if (FemaleRadioButton.Checked)
                        {
                            gender = "Female";
                        }


                        SqlCommand cmd = new SqlCommand("update Student_table set StuID = '" + StuIDTextBox.Text + "', Name = '" + StuNameTextBox.Text + "', Age = " + StuAgeTextBox.Text + ", Gender = '" + gender + "', Semester = '" + StuSemTextBox.Text + "', Contact = '" + StuContactTextBox.Text + "', Email = '" + StuEmailTextBox.Text + "', Dept = '" + DeptComboBox.Text + "', Password = '" + PasswordTextBox.Text + "', Image = @image where StuID = '" + StuIDTextBox.Text + "';", con);
                        cmd.Parameters.Add(new SqlParameter("@image", image));
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    else if(ImageLocation == "")
                    {
                        string gender = "";
                        if (MaleRadioButton.Checked)
                        {
                            gender = "Male";
                        }
                        if (FemaleRadioButton.Checked)
                        {
                            gender = "Female";
                        }


                        SqlCommand cmd = new SqlCommand("update Student_table set StuID = '" + StuIDTextBox.Text + "', Name = '" + StuNameTextBox.Text + "', Age = " + StuAgeTextBox.Text + ", Gender = '" + gender + "', Semester = '" + StuSemTextBox.Text + "', Contact = '" + StuContactTextBox.Text + "', Email = '" + StuEmailTextBox.Text + "', Dept = '" + DeptComboBox.Text + "', Password = '" + PasswordTextBox.Text + "' where StuID = '" + StuIDTextBox.Text + "';", con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }

                    MessageBox.Show("Information successfully updated...");
                    ViewStudents();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Delete selected information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("delete from Student_table where StuID = '" + StuIDTextBox.Text + "';", con);
                    cmd.ExecuteNonQuery();

                    CountLabel.Text = (dataGridView1.Rows.Count - 1).ToString();
                    con.Close();

                    MessageBox.Show("Information successfully deleted...");
                    ViewStudents();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P024OII\\TARIQULPC;Initial Catalog=Library_Management_System;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select StuID, Name, Age, Gender, Semester, Contact, Email, Dept, Password from Student_table where Name like '%" + SearchTextBox.Text + "%';", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource BS = new BindingSource();
                BS.DataSource = dt;
                dataGridView1.DataSource = BS;
                sda.Update(dt);

                CountLabel.Text = (dataGridView1.Rows.Count - 1).ToString();
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

        private void DeptComboBox_Enter(object sender, EventArgs e)
        {
            if (DeptComboBox.Text == "---Select department---")
            {
                DeptComboBox.Text = "";
            }
        }
    }
}
