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

namespace BTM495_Team4
{
    public partial class EmployeeLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (emp_username_txtbox.Text == "" || emp_password_txtbox.Text == "")
            {
                MessageBox.Show("Please fill in all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM employees WHERE username = @username " + "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", emp_username_txtbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", emp_password_txtbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Employee.currentUser = (int)cmd.ExecuteScalar();
                                
                                                                                                                        
                                EmployeePortal empPortal = new EmployeePortal();
                                empPortal.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            emp_password_txtbox.PasswordChar = emp_showpass_chkbox.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerLogin loginForm = new ManagerLogin();
            loginForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
