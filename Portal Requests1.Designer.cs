namespace BTM495_Team4
{
    partial class Portal_Requests1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_emp_dataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.create_reason_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manager_reviewreqs_authorize_btn = new System.Windows.Forms.Button();
            this.create_empname_txtbox = new System.Windows.Forms.TextBox();
            this.create_comments_txtbox = new System.Windows.Forms.TextBox();
            this.create_id_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeDataSet = new BTM495_Team4.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create_emp_dataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.create_emp_dataGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(36, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 249);
            this.panel1.TabIndex = 0;
            // 
            // create_emp_dataGrid
            // 
            this.create_emp_dataGrid.AllowUserToAddRows = false;
            this.create_emp_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.create_emp_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.create_emp_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.create_emp_dataGrid.EnableHeadersVisualStyles = false;
            this.create_emp_dataGrid.Location = new System.Drawing.Point(16, 58);
            this.create_emp_dataGrid.Name = "create_emp_dataGrid";
            this.create_emp_dataGrid.ReadOnly = true;
            this.create_emp_dataGrid.RowHeadersVisible = false;
            this.create_emp_dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.create_emp_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.create_emp_dataGrid.RowTemplate.Height = 24;
            this.create_emp_dataGrid.Size = new System.Drawing.Size(724, 177);
            this.create_emp_dataGrid.TabIndex = 3;
            this.create_emp_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manager_viewreqs_datagrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Requests";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.create_reason_txtbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.endDate_dateTimePicker);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.startDate_dateTimePicker);
            this.panel2.Controls.Add(this.manager_reviewreqs_authorize_btn);
            this.panel2.Controls.Add(this.create_empname_txtbox);
            this.panel2.Controls.Add(this.create_comments_txtbox);
            this.panel2.Controls.Add(this.create_id_txtbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(36, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 247);
            this.panel2.TabIndex = 1;
            // 
            // create_reason_txtbox
            // 
            this.create_reason_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.create_reason_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_reason_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_reason_txtbox.Location = new System.Drawing.Point(424, 52);
            this.create_reason_txtbox.Multiline = true;
            this.create_reason_txtbox.Name = "create_reason_txtbox";
            this.create_reason_txtbox.Size = new System.Drawing.Size(275, 30);
            this.create_reason_txtbox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Reason:";
            // 
            // endDate_dateTimePicker
            // 
            this.endDate_dateTimePicker.Location = new System.Drawing.Point(116, 165);
            this.endDate_dateTimePicker.Name = "endDate_dateTimePicker";
            this.endDate_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDate_dateTimePicker.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Start Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // startDate_dateTimePicker
            // 
            this.startDate_dateTimePicker.Location = new System.Drawing.Point(116, 130);
            this.startDate_dateTimePicker.Name = "startDate_dateTimePicker";
            this.startDate_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDate_dateTimePicker.TabIndex = 21;
            // 
            // manager_reviewreqs_authorize_btn
            // 
            this.manager_reviewreqs_authorize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.manager_reviewreqs_authorize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_reviewreqs_authorize_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manager_reviewreqs_authorize_btn.FlatAppearance.BorderSize = 0;
            this.manager_reviewreqs_authorize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.manager_reviewreqs_authorize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.manager_reviewreqs_authorize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_reviewreqs_authorize_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_reviewreqs_authorize_btn.ForeColor = System.Drawing.Color.White;
            this.manager_reviewreqs_authorize_btn.Location = new System.Drawing.Point(337, 196);
            this.manager_reviewreqs_authorize_btn.Name = "manager_reviewreqs_authorize_btn";
            this.manager_reviewreqs_authorize_btn.Size = new System.Drawing.Size(173, 35);
            this.manager_reviewreqs_authorize_btn.TabIndex = 20;
            this.manager_reviewreqs_authorize_btn.Text = "Submit";
            this.manager_reviewreqs_authorize_btn.UseVisualStyleBackColor = false;
            this.manager_reviewreqs_authorize_btn.Click += new System.EventHandler(this.manager_reviewreqs_authorize_btn_Click);
            // 
            // create_empname_txtbox
            // 
            this.create_empname_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.create_empname_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_empname_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_empname_txtbox.Location = new System.Drawing.Point(116, 91);
            this.create_empname_txtbox.Multiline = true;
            this.create_empname_txtbox.Name = "create_empname_txtbox";
            this.create_empname_txtbox.Size = new System.Drawing.Size(194, 30);
            this.create_empname_txtbox.TabIndex = 19;
            // 
            // create_comments_txtbox
            // 
            this.create_comments_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.create_comments_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_comments_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_comments_txtbox.Location = new System.Drawing.Point(424, 101);
            this.create_comments_txtbox.Multiline = true;
            this.create_comments_txtbox.Name = "create_comments_txtbox";
            this.create_comments_txtbox.Size = new System.Drawing.Size(275, 74);
            this.create_comments_txtbox.TabIndex = 18;
            // 
            // create_id_txtbox
            // 
            this.create_id_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.create_id_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_id_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_id_txtbox.Location = new System.Drawing.Point(116, 48);
            this.create_id_txtbox.Multiline = true;
            this.create_id_txtbox.Name = "create_id_txtbox";
            this.create_id_txtbox.Size = new System.Drawing.Size(194, 30);
            this.create_id_txtbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(334, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Request";
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
            // employeeDataSetBindingSource1
            // 
            this.employeeDataSetBindingSource1.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource1.Position = 0;
            // 
            // Portal_Requests1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Portal_Requests1";
            this.Size = new System.Drawing.Size(834, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create_emp_dataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView create_emp_dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource1;
        private System.Windows.Forms.Button manager_reviewreqs_authorize_btn;
        private System.Windows.Forms.TextBox create_comments_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox create_empname_txtbox;
        private System.Windows.Forms.TextBox create_id_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker endDate_dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox create_reason_txtbox;
        private System.Windows.Forms.Label label5;
    }
}
