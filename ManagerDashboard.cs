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
using System.Runtime.Remoting.Contexts;

namespace BTM495_Team4
{
    public partial class ManagerDashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        public ManagerDashboard()
        {
            InitializeComponent();
            displayOR();
            displayTE();
            displayTR();
        }


        public void displayTE()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM employees WHERE id > 0";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) 
                        {
                            int count = Convert.ToInt32(reader[0]);
                            manager_totalemps_label.Text = count.ToString();
                        }
                        reader.Close(); 
                            }
                } catch (Exception ex){ MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connect.Close(); }
               
            }
            
        }
        public void displayOR()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(requestId) FROM ptoRequests WHERE comments IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            manager_outreqs_label.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connect.Close(); }

            }

        }
        public void displayTR()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(requestID) FROM ptoRequests";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            manager_totalreqs_label.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connect.Close(); }

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
