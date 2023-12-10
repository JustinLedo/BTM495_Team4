using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            /* PTORequest req = new PTORequest();
             List<PTORequest> ptoReqs = req.requests();

             manager_viewreqs_datagrid.AutoGenerateColumns = true;
             manager_viewreqs_datagrid.AutoSize = true;
             manager_viewreqs_datagrid.DataSource = ptoReqs;
            */

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                string query = "SELECT * FROM ptoRequests";
                SqlCommand cmd = new SqlCommand(query, connect);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                manager_viewreqs_datagrid.DataSource = dt;
                connect.Close();
            }
                //manager_viewreqs_datagrid.AutoSize = true;
          
        }
        private void manager_viewreqs_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex < 0 || e.RowIndex >= manager_viewreqs_datagrid.RowCount)
            {
                int row = manager_viewreqs_datagrid.CurrentCell.RowIndex;
                manager_idsearch_txtbox.Text = manager_viewreqs_datagrid.SelectedRows[0].Cells["empId"].Value.ToString();
manager_empnamesearch_txtbox.Text = manager_viewreqs_datagrid.SelectedRows[0].Cells["fullName"].Value.ToString();

                DataGridViewRow row = manager_viewreqs_datagrid.Rows[e.RowIndex];
                 manager_empnamesearch_txtbox.Text = row.Cells[8].Value.ToString();
                 manager_idsearch_txtbox.Text = row.Cells[2].Value.ToString();
             
            }*/

        }

      
        private void manager_searchemp_btn_Click(object sender, EventArgs e)
        {
            
                DataTable filter = (DataTable)manager_viewreqs_datagrid.DataSource;
                filter.DefaultView.RowFilter = "empId = '" + manager_idsearch_txtbox.Text + "'";


            }
        /* else if (manager_empnamesearch_txtbox != null && manager_idsearch_txtbox == null)
         {
             DataTable filter = (DataTable)manager_viewreqs_datagrid.DataSource;
             filter.DefaultView.RowFilter = "fullName = '" + manager_empnamesearch_txtbox.Text + "'";
         }
         else if (manager_empnamesearch_txtbox != null && manager_idsearch_txtbox != null)
         {
             DataTable filter = (DataTable)manager_viewreqs_datagrid.DataSource;
             filter.DefaultView.RowFilter = "empId = '" + Convert.ToInt32(manager_idsearch_txtbox.Text.ToString() + "'";
         }
         else 
         {
             displayOpenRequests();
         } */

        /*if (manager_idsearch_txtbox != null && manager_empnamesearch_txtbox == null)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = manager_viewreqs_datagrid.DataSource;
            bs.Filter = "empId LIKE '%" + manager_idsearch_txtbox.Text + "%'";
            manager_viewreqs_datagrid.DataSource = bs.DataSource;
        }
        else if (manager_empnamesearch_txtbox != null && manager_idsearch_txtbox == null)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = manager_viewreqs_datagrid.DataSource;
            bs.Filter = "fullName LIKE '%" + manager_empnamesearch_txtbox.Text + "%'";
            manager_viewreqs_datagrid.DataSource = bs.DataSource;
        }*/





        private void manager_reviewreqs_authorize_btn_Click(object sender, EventArgs e)
        {

            //ADD CREATION TO PTOAPPROVALS TABLE

            if (connect.State == ConnectionState.Closed)
            {

                connect.Open();
                string sql = "SELECT * FROM ptoRequests WHERE comments IS NULL";
                using (SqlCommand check = new SqlCommand(sql, connect))
                {


                    if (approve_radbtn.Checked == true  && deny_radbtn.Checked == false)
                    {
                        string insertData = "UPDATE ptoRequests SET requestedStatus = 'Approved! Please validate.', comments = '" + manager_comments_txtbox.Text + "' WHERE empId = '" + manager_idsearch_txtbox.Text + "';";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {

                            //cmd.Parameters.AddWithValue("@status", "Approved!");
                            //cmd.Parameters.AddWithValue("@comments", "Enjoy");
                            //cmd.Parameters.AddWithValue("@empId", SqlDbType.Int).Value = manager_idsearch_txtbox.Text;


                            cmd.ExecuteNonQuery();
                            
                            displayOpenRequests();

                            MessageBox.Show("Approved successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connect.Close();
                        }
                        /*
                        Random rnd = new Random();
                        int newPTOCode = rnd.Next(1, 100);

                        var today = DateTime.Today;


                        string createApproval = "INSERT INTO ptoApproval (approvalId, empId, approvalStatus, approvalDate, approvedBy, comments, ptoCode) VALUES (1, 1, 'Approved!', '" + today + "', 'Manager', '" + manager_comments_txtbox.Text + "', " + newPTOCode ;

                        using (SqlCommand cmd = new SqlCommand(createApproval, connect))
                        {

                            //cmd.Parameters.AddWithValue("@status", "Approved!");
                            //cmd.Parameters.AddWithValue("@comments", "Enjoy");
                            //cmd.Parameters.AddWithValue("@empId", SqlDbType.Int).Value = manager_idsearch_txtbox.Text;


                            cmd.ExecuteNonQuery();

                            displayOpenRequests();
                        }
                        */

                        /*string approvalData = "UPDATE ptoApprovals SET requestedStatus = 'Approved! Please validate.', empId = " + + "comments = '" + manager_comments_txtbox.Text + "' WHERE empId = '" + manager_idsearch_txtbox.Text + "';";

                        using (SqlCommand cmd = new SqlCommand(approvalData, connect))
                        {

                            //cmd.Parameters.AddWithValue("@status", "Approved!");
                            //cmd.Parameters.AddWithValue("@comments", "Enjoy");
                            //cmd.Parameters.AddWithValue("@empId", SqlDbType.Int).Value = manager_idsearch_txtbox.Text;


                            cmd.ExecuteNonQuery();

                            displayOpenRequests();

                            MessageBox.Show("Approved successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connect.Close();
                        }*/


                        displayOpenRequests();
                    }

                    else if (deny_radbtn.Checked == true && approve_radbtn.Checked == false)
                    {
                        string insertData = "UPDATE ptoRequests SET requestedStatus = 'Denied!', comments = '" + manager_comments_txtbox.Text + "' WHERE empId = '" + manager_idsearch_txtbox.Text + "';";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                           /* cmd.Parameters.AddWithValue("@requestedStatus", "Denied!");
                            cmd.Parameters.AddWithValue("@comments", manager_comments_txtbox.Text);
                            cmd.Parameters.AddWithValue("@empId", manager_idsearch_txtbox.Text);
                           */
                            cmd.ExecuteNonQuery();

                            displayOpenRequests();

                            MessageBox.Show("Denied successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connect.Close();

                        }
                        /*Random rnd = new Random();
                        int newPTOCode = rnd.Next(1, 100);

                        var today = DateTime.Today;


                        string createDenial = "INSERT INTO ptoApproval (approvalId, empId, approvalStatus, approvalDate, deniedBy, comments) VALUES (1, 1, 'Denied', '" + today + "', 'Manager', '" + manager_comments_txtbox.Text + "';";

                        using (SqlCommand cmd = new SqlCommand(createDenial, connect))
                        {

                            //cmd.Parameters.AddWithValue("@status", "Approved!");
                            //cmd.Parameters.AddWithValue("@comments", "Enjoy");
                            //cmd.Parameters.AddWithValue("@empId", SqlDbType.Int).Value = manager_idsearch_txtbox.Text;


                            cmd.ExecuteNonQuery();

                            displayOpenRequests();
                        }
                        connect.Close();*/

                        displayOpenRequests();
                    }

                }

            }
        }

        private void manager_viewreqs_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
          manager_idsearch_txtbox.Text = Convert.ToString(manager_viewreqs_datagrid.Rows[row].Cells["empId"].Value);
            manager_empnamesearch_txtbox.Text = Convert.ToString(manager_viewreqs_datagrid.Rows[row].Cells["fullName"].Value);
        }

        private void manager_viewreqs_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagerViewReqs_Load(object sender, EventArgs e)
        {

        }
    }
        }
    

