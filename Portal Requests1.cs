using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495_Team4
{
    public partial class Portal_Requests1 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Portal_Requests1()
        {
            InitializeComponent();

            displayOpenRequests();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayOpenRequests();
        }

        public void displayOpenRequests()
        {

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                string query = "SELECT * FROM ptoRequests WHERE empId = " + Employee.currentUser;
                SqlCommand cmd = new SqlCommand(query, connect);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                create_emp_dataGrid.DataSource = dt;
                connect.Close();
            }

        }
        private void manager_viewreqs_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = create_emp_dataGrid.Rows[e.RowIndex];
                create_empname_txtbox.Text = row.Cells[8].Value.ToString();
                create_id_txtbox.Text = row.Cells[2].Value.ToString();
            }

        }

        private void manager_searchemp_btn_Click(object sender, EventArgs e)
        {

        }

        private void manager_reviewreqs_authorize_btn_Click(object sender, EventArgs e)
        {

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM ptoRequests WHERE empId = " + Employee.currentUser;
                    using (SqlCommand check = new SqlCommand(sql, connect))
                    {


                        if (create_id_txtbox == null)
                        {
                            string insertData = "INSERT INTO ptoRequests " +
                                "(empId, fullName, startDate, endDate, requestedStatus, reasonForRequest, comments)" +
                                "VALUES(@empId, @fullName, @startDate, @endDate, @requestedStatus, @reasonForRequest, @comments";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@empId", Employee.currentUser);
                                cmd.Parameters.AddWithValue("@fullName", create_empname_txtbox);
                                cmd.Parameters.AddWithValue("@startDate", startDate_dateTimePicker);
                                cmd.Parameters.AddWithValue("@endDate", endDate_dateTimePicker);
                                cmd.Parameters.AddWithValue("@requestedStatus", "Created, Awaiting Review");
                                cmd.Parameters.AddWithValue("@reasonForRequet", create_reason_txtbox);
                                cmd.Parameters.AddWithValue("@comments", create_comments_txtbox);


                                cmd.ExecuteNonQuery();

                                displayOpenRequests();

                                MessageBox.Show("created successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            string insertData = "INSERT INTO ptoRequests " +
                              "(empId, fullName, startDate, endDate, requestedStatus, reasonForRequest, comments)" +
                              "VALUES(@empId, @fullName, @startDate, @endDate, @requestedStatus, @reasonForRequest, @comments";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@empId", create_id_txtbox);
                                cmd.Parameters.AddWithValue("@fullName", create_empname_txtbox);
                                cmd.Parameters.AddWithValue("@startDate", startDate_dateTimePicker);
                                cmd.Parameters.AddWithValue("@endDate", endDate_dateTimePicker);
                                cmd.Parameters.AddWithValue("@requestedStatus", "Created, Awaiting Review");
                                cmd.Parameters.AddWithValue("@reasonForRequet", create_reason_txtbox);
                                cmd.Parameters.AddWithValue("@comments", create_comments_txtbox);

                                cmd.ExecuteNonQuery();

                                displayOpenRequests();

                                MessageBox.Show("created successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}


