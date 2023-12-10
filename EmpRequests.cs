using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495_Team4
{
    public partial class EmpRequests : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\justi\source\repos\JustinLedo\BTM495_Team4\Employee.mdf;Integrated Security=True;Connect Timeout=30");
        public EmpRequests()
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
                string query = "SELECT * FROM ptoRequests WHERE comments IS NOT NULL " + "AND empId = 1";
                SqlCommand cmd = new SqlCommand(query, connect);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                emp_reqs_datagrid.DataSource = dt;
                connect.Close();
            }



        }
        private void manager_viewreqs_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void manager_searchemp_btn_Click(object sender, EventArgs e)
        {

        }

        private void emp_reqs_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* int row = e.RowIndex;
             manager_idsearch_txtbox.Text = Convert.ToString(emp_reqs_datagrid.Rows[row].Cells["empId"].Value);
             manager_empnamesearch_txtbox.Text = Convert.ToString(emp_reqs_datagrid.Rows[row].Cells["fullName"].Value); */
        }
        private void EmpRequests_Load(object sender, EventArgs e)
        {

        }

        private void emp_reviewreqs_authorize_btn_Click(object sender, EventArgs e)
        {
            if (confirm_radbtn.Checked == true && cancel_radbtn.Checked == false)
            {
                connect.Open();
                string selectData = "SELECT * FROM ptoApproval WHERE empId = " + Employee.currentUser;

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@ptoCode", emp_comments_txtbox.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show("Request Successfully validated!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmd.ExecuteNonQuery();
                        displayOpenRequests();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Code", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else if (cancel_radbtn.Checked == true && confirm_radbtn.Checked == false)
            {

                string insertData = "UPDATE ptoApproval SET deniedBy = 'John', comments = '" + emp_comments_txtbox.Text + "' WHERE empId = 1;";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {


                    cmd.ExecuteNonQuery();

                    displayOpenRequests();

                    MessageBox.Show("Request successfully canceled!"
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
            }   
        }
    
    }
}



