using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495_Team4
{
    public partial class EmployeePortal : Form
    {
        public EmployeePortal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void quit_Click(object sender, EventArgs e)
        {
              Application.Exit();
            
                
            }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DialogResult close = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (close == DialogResult.Yes)
            {
                ManagerLogin loginForm = new ManagerLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        private void manager_dashboard_button_Click(object sender, EventArgs e)
        {
            empPortal1.Visible = true;
            empRequests1.Visible = false;
            
        }

        private void manager_viewReqs_button_Click_1(object sender, EventArgs e)
        {
            //Managerdashboard1.Visible = false;
            //managerViewReqs1.Visible = true;
        }

        private void emp_validate_btn_Click(object sender, EventArgs e)
        {
            empPortal1.Visible = false;
            empRequests1.Visible = true;
        }
    }
    }

