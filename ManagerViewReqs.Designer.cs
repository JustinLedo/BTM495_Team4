namespace BTM495_Team4
{
    partial class ManagerViewReqs
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
            this.manager_viewreqs_datagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeDataSet = new BTM495_Team4.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_reviewreqs_authorize_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deny_radbtn = new System.Windows.Forms.RadioButton();
            this.approve_radbtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.manager_comments_txtbox = new System.Windows.Forms.TextBox();
            this.manager_searchemp_btn = new System.Windows.Forms.Button();
            this.manager_empnamesearch_txtbox = new System.Windows.Forms.TextBox();
            this.manager_idsearch_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_viewreqs_datagrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manager_viewreqs_datagrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(36, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 290);
            this.panel1.TabIndex = 0;
            // 
            // manager_viewreqs_datagrid
            // 
            this.manager_viewreqs_datagrid.AllowUserToAddRows = false;
            this.manager_viewreqs_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manager_viewreqs_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.manager_viewreqs_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manager_viewreqs_datagrid.EnableHeadersVisualStyles = false;
            this.manager_viewreqs_datagrid.Location = new System.Drawing.Point(16, 58);
            this.manager_viewreqs_datagrid.Name = "manager_viewreqs_datagrid";
            this.manager_viewreqs_datagrid.ReadOnly = true;
            this.manager_viewreqs_datagrid.RowHeadersVisible = false;
            this.manager_viewreqs_datagrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manager_viewreqs_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.manager_viewreqs_datagrid.RowTemplate.Height = 24;
            this.manager_viewreqs_datagrid.Size = new System.Drawing.Size(724, 216);
            this.manager_viewreqs_datagrid.TabIndex = 3;
            this.manager_viewreqs_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manager_viewreqs_datagrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Open Requests";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.manager_searchemp_btn);
            this.panel2.Controls.Add(this.manager_reviewreqs_authorize_btn);
            this.panel2.Controls.Add(this.manager_empnamesearch_txtbox);
            this.panel2.Controls.Add(this.manager_comments_txtbox);
            this.panel2.Controls.Add(this.manager_idsearch_txtbox);
            this.panel2.Controls.Add(this.deny_radbtn);
            this.panel2.Controls.Add(this.approve_radbtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(36, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 219);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Request Review ";
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
            this.manager_reviewreqs_authorize_btn.Location = new System.Drawing.Point(517, 169);
            this.manager_reviewreqs_authorize_btn.Name = "manager_reviewreqs_authorize_btn";
            this.manager_reviewreqs_authorize_btn.Size = new System.Drawing.Size(173, 35);
            this.manager_reviewreqs_authorize_btn.TabIndex = 20;
            this.manager_reviewreqs_authorize_btn.Text = "Submit";
            this.manager_reviewreqs_authorize_btn.UseVisualStyleBackColor = false;
            this.manager_reviewreqs_authorize_btn.Click += new System.EventHandler(this.manager_reviewreqs_authorize_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(356, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Response to PTO Request:";
            // 
            // deny_radbtn
            // 
            this.deny_radbtn.AutoSize = true;
            this.deny_radbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deny_radbtn.ForeColor = System.Drawing.Color.Black;
            this.deny_radbtn.Location = new System.Drawing.Point(677, 50);
            this.deny_radbtn.Name = "deny_radbtn";
            this.deny_radbtn.Size = new System.Drawing.Size(63, 22);
            this.deny_radbtn.TabIndex = 15;
            this.deny_radbtn.TabStop = true;
            this.deny_radbtn.Text = "Deny";
            this.deny_radbtn.UseVisualStyleBackColor = true;
            // 
            // approve_radbtn
            // 
            this.approve_radbtn.AutoSize = true;
            this.approve_radbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve_radbtn.ForeColor = System.Drawing.Color.Black;
            this.approve_radbtn.Location = new System.Drawing.Point(567, 50);
            this.approve_radbtn.Name = "approve_radbtn";
            this.approve_radbtn.Size = new System.Drawing.Size(83, 22);
            this.approve_radbtn.TabIndex = 14;
            this.approve_radbtn.TabStop = true;
            this.approve_radbtn.Text = "Approve";
            this.approve_radbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(375, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comments:";
            // 
            // manager_comments_txtbox
            // 
            this.manager_comments_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.manager_comments_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manager_comments_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_comments_txtbox.Location = new System.Drawing.Point(465, 78);
            this.manager_comments_txtbox.Multiline = true;
            this.manager_comments_txtbox.Name = "manager_comments_txtbox";
            this.manager_comments_txtbox.Size = new System.Drawing.Size(275, 74);
            this.manager_comments_txtbox.TabIndex = 18;
            // 
            // manager_searchemp_btn
            // 
            this.manager_searchemp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.manager_searchemp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_searchemp_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manager_searchemp_btn.FlatAppearance.BorderSize = 0;
            this.manager_searchemp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.manager_searchemp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.manager_searchemp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_searchemp_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_searchemp_btn.ForeColor = System.Drawing.Color.White;
            this.manager_searchemp_btn.Location = new System.Drawing.Point(116, 169);
            this.manager_searchemp_btn.Name = "manager_searchemp_btn";
            this.manager_searchemp_btn.Size = new System.Drawing.Size(173, 35);
            this.manager_searchemp_btn.TabIndex = 21;
            this.manager_searchemp_btn.Text = "Select Employee";
            this.manager_searchemp_btn.UseVisualStyleBackColor = false;
            this.manager_searchemp_btn.Click += new System.EventHandler(this.manager_searchemp_btn_Click);
            // 
            // manager_empnamesearch_txtbox
            // 
            this.manager_empnamesearch_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.manager_empnamesearch_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manager_empnamesearch_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_empnamesearch_txtbox.Location = new System.Drawing.Point(116, 91);
            this.manager_empnamesearch_txtbox.Multiline = true;
            this.manager_empnamesearch_txtbox.Name = "manager_empnamesearch_txtbox";
            this.manager_empnamesearch_txtbox.Size = new System.Drawing.Size(194, 30);
            this.manager_empnamesearch_txtbox.TabIndex = 19;
            // 
            // manager_idsearch_txtbox
            // 
            this.manager_idsearch_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.manager_idsearch_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manager_idsearch_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_idsearch_txtbox.Location = new System.Drawing.Point(116, 48);
            this.manager_idsearch_txtbox.Multiline = true;
            this.manager_idsearch_txtbox.Name = "manager_idsearch_txtbox";
            this.manager_idsearch_txtbox.Size = new System.Drawing.Size(194, 30);
            this.manager_idsearch_txtbox.TabIndex = 16;
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
            // ManagerViewReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerViewReqs";
            this.Size = new System.Drawing.Size(834, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_viewreqs_datagrid)).EndInit();
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
        private System.Windows.Forms.DataGridView manager_viewreqs_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource1;
        private System.Windows.Forms.Button manager_reviewreqs_authorize_btn;
        private System.Windows.Forms.TextBox manager_comments_txtbox;
        private System.Windows.Forms.RadioButton deny_radbtn;
        private System.Windows.Forms.RadioButton approve_radbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manager_searchemp_btn;
        private System.Windows.Forms.TextBox manager_empnamesearch_txtbox;
        private System.Windows.Forms.TextBox manager_idsearch_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
