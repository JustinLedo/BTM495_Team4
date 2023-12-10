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
using System.Linq.Expressions;

namespace BTM495_Team4
{
    public partial class ManagerLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        public ManagerLogin()
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

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empp_button_Click(object sender, EventArgs e)
        {
            EmployeeLogin loginForm = new EmployeeLogin();
            loginForm.Show();
            this.Hide();

        }

        private void manager_showpass_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            manager_password_txtbox.PasswordChar = manager_showpass_chkbox.Checked ? '\0' : '*';
        }

        private void manager_login_button_Click(object sender, EventArgs e)
        {
            if (manager_username_txtbox.Text == "" || manager_password_txtbox.Text == "")
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
                        string selectData = "SELECT * FROM managers WHERE username = @username " + "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", manager_username_txtbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", manager_password_txtbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Manager.currentUser = (int)cmd.ExecuteScalar();

                                ManagerPortal managerPortal = new ManagerPortal();
                                managerPortal.Show();
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


    }
}
  
