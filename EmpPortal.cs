using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495_Team4
{
    public partial class EmpPortal : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");

        public EmpPortal()
        {
            InitializeComponent();
            displayBAL();
            displayRtoV();
            displayTR();
        }


        public void displayRtoV()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(requestId) FROM ptoRequests WHERE comments IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            emp_reqtoval.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connect.Close(); }
            }

        }
        public void displayBAL()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string bal = "SELECT ptoBalance FROM ptoBal WHERE empId = 1";
                    using (SqlCommand cmd = new SqlCommand(bal, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            emp_tbal.Text = count.ToString();
                        }
                        reader.Close();
                    }
                    string remhrs = "SELECT remainingHours FROM ptoBal WHERE empId = 1";
                    using (SqlCommand cmd = new SqlCommand(remhrs, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            emp_remhrs.Text = count.ToString();
                        }
                        reader.Close();
                    }
                    string acchrs = "SELECT accruedHours FROM ptoBal WHERE empId = 1";
                    using (SqlCommand cmd = new SqlCommand(acchrs, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            emp_acchrs.Text = count.ToString();
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
                    string selectData = "SELECT COUNT(requestID) FROM ptoRequests WHERE empId = 1";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            emp_treqs.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connect.Close(); }

            }
        }

        private void EmpPortal_Load(object sender, EventArgs e)
        {

        }
    }
}
