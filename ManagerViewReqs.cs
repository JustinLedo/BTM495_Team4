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
    public partial class ManagerViewReqs : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        public ManagerViewReqs()
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
            PTORequest req = new PTORequest();
            List<PTORequest> ptoReqs = req.requests();

            manager_viewreqs_datagrid.DataSource = ptoReqs;
        }
        private void manager_viewreqs_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = manager_viewreqs_datagrid.Rows[e.RowIndex];
                manager_empnamesearch_txtbox.Text = row.Cells[8].Value.ToString();
                manager_idsearch_txtbox.Text = row.Cells[2].Value.ToString();
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
                    string sql = "SELECT * FROM ptoRequests WHERE comments IS NULL";
                            using (SqlCommand check  = new SqlCommand(sql, connect))
                            {


                        if (approve_radbtn.Checked)
                        {
                            string insertData = "INSERT INTO employees " +
                                "(requestedStatus, comments)" +
                                "VALUES(@status, @comments";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Approved!");
                                cmd.Parameters.AddWithValue("@comments", manager_comments_txtbox);


                                cmd.ExecuteNonQuery();

                                displayOpenRequests();

                                MessageBox.Show("Approved successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (deny_radbtn.Checked) 
                        {
                            string insertData = "INSERT INTO employees " +
"(requestedStatus, comments)" +
"VALUES(@status, @comments";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Denied!");
                                cmd.Parameters.AddWithValue("@comments", manager_comments_txtbox);


                                cmd.ExecuteNonQuery();

                                displayOpenRequests();

                                MessageBox.Show("Denied successfully!"
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
            }
        }
    

