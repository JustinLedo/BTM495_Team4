namespace BTM495_Team4
{
    partial class EmployeePortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePortal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeDataSet = new BTM495_Team4.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.emp_validate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.emp_dashboard_button = new System.Windows.Forms.Button();
            this.manager_viewReqs_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.empPortal1 = new BTM495_Team4.EmpPortal();
            this.empRequests1 = new BTM495_Team4.EmpRequests();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.quit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 58);
            this.panel1.TabIndex = 0;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(1075, 9);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(22, 23);
            this.quit.TabIndex = 5;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Paid Time Off System";
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.emp_validate_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.emp_dashboard_button);
            this.panel2.Controls.Add(this.manager_viewReqs_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 542);
            this.panel2.TabIndex = 1;
            // 
            // emp_validate_btn
            // 
            this.emp_validate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.emp_validate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_validate_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.emp_validate_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.emp_validate_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.emp_validate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_validate_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_validate_btn.ForeColor = System.Drawing.Color.White;
            this.emp_validate_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_validate_btn.Image")));
            this.emp_validate_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_validate_btn.Location = new System.Drawing.Point(33, 421);
            this.emp_validate_btn.Name = "emp_validate_btn";
            this.emp_validate_btn.Size = new System.Drawing.Size(179, 74);
            this.emp_validate_btn.TabIndex = 12;
            this.emp_validate_btn.Text = "VALIDATE REQUEST";
            this.emp_validate_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_validate_btn.UseVisualStyleBackColor = false;
            this.emp_validate_btn.Click += new System.EventHandler(this.emp_validate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sign Out";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(10, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // emp_dashboard_button
            // 
            this.emp_dashboard_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.emp_dashboard_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_dashboard_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.emp_dashboard_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.emp_dashboard_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.emp_dashboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_dashboard_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_dashboard_button.ForeColor = System.Drawing.Color.White;
            this.emp_dashboard_button.Image = ((System.Drawing.Image)(resources.GetObject("emp_dashboard_button.Image")));
            this.emp_dashboard_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_dashboard_button.Location = new System.Drawing.Point(33, 233);
            this.emp_dashboard_button.Name = "emp_dashboard_button";
            this.emp_dashboard_button.Size = new System.Drawing.Size(179, 74);
            this.emp_dashboard_button.TabIndex = 9;
            this.emp_dashboard_button.Text = "DASHBOARD";
            this.emp_dashboard_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_dashboard_button.UseVisualStyleBackColor = false;
            this.emp_dashboard_button.Click += new System.EventHandler(this.manager_dashboard_button_Click);
            // 
            // manager_viewReqs_button
            // 
            this.manager_viewReqs_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.manager_viewReqs_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_viewReqs_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manager_viewReqs_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.manager_viewReqs_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.manager_viewReqs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_viewReqs_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_viewReqs_button.ForeColor = System.Drawing.Color.White;
            this.manager_viewReqs_button.Image = ((System.Drawing.Image)(resources.GetObject("manager_viewReqs_button.Image")));
            this.manager_viewReqs_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manager_viewReqs_button.Location = new System.Drawing.Point(33, 332);
            this.manager_viewReqs_button.Name = "manager_viewReqs_button";
            this.manager_viewReqs_button.Size = new System.Drawing.Size(179, 74);
            this.manager_viewReqs_button.TabIndex = 7;
            this.manager_viewReqs_button.Text = "CREATE REQUEST";
            this.manager_viewReqs_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manager_viewReqs_button.UseVisualStyleBackColor = false;
            this.manager_viewReqs_button.Click += new System.EventHandler(this.manager_viewReqs_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome, Employee!\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.empPortal1);
            this.panel3.Controls.Add(this.empRequests1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(266, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 542);
            this.panel3.TabIndex = 2;
            // 
            // empPortal1
            // 
            this.empPortal1.Location = new System.Drawing.Point(0, 0);
            this.empPortal1.Name = "empPortal1";
            this.empPortal1.Size = new System.Drawing.Size(834, 542);
            this.empPortal1.TabIndex = 1;
            // 
            // empRequests1
            // 
            this.empRequests1.Location = new System.Drawing.Point(-3, -2);
            this.empRequests1.Name = "empRequests1";
            this.empRequests1.Size = new System.Drawing.Size(834, 542);
            this.empRequests1.TabIndex = 0;
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePortal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manager_viewReqs_button;
        private System.Windows.Forms.Button emp_dashboard_button;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button emp_validate_btn;
        private EmpRequests empRequests1;
        private EmpPortal empPortal1;
    }
}