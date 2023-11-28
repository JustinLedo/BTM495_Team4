namespace BTM495_Team4
{
    partial class EmpRequests
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
            this.emp_reqs_datagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDataSet = new BTM495_Team4.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirm_radbtn = new System.Windows.Forms.RadioButton();
            this.cancel_radbtn = new System.Windows.Forms.RadioButton();
            this.emp_comments_txtbox = new System.Windows.Forms.TextBox();
            this.emp_reviewreqs_authorize_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_reqs_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emp_reqs_datagrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(36, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 290);
            this.panel1.TabIndex = 0;
            // 
            // emp_reqs_datagrid
            // 
            this.emp_reqs_datagrid.AllowUserToAddRows = false;
            this.emp_reqs_datagrid.AllowUserToDeleteRows = false;
            this.emp_reqs_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_reqs_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_reqs_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emp_reqs_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_reqs_datagrid.EnableHeadersVisualStyles = false;
            this.emp_reqs_datagrid.Location = new System.Drawing.Point(16, 58);
            this.emp_reqs_datagrid.Name = "emp_reqs_datagrid";
            this.emp_reqs_datagrid.ReadOnly = true;
            this.emp_reqs_datagrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_reqs_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.emp_reqs_datagrid.RowTemplate.Height = 24;
            this.emp_reqs_datagrid.Size = new System.Drawing.Size(724, 216);
            this.emp_reqs_datagrid.TabIndex = 3;
            this.emp_reqs_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manager_viewreqs_datagrid_CellContentClick);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Response to PTO Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Please enter the correct code to confirm or additional comments to cancel the req" +
    "uest:";
            // 
            // confirm_radbtn
            // 
            this.confirm_radbtn.AutoSize = true;
            this.confirm_radbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_radbtn.ForeColor = System.Drawing.Color.Black;
            this.confirm_radbtn.Location = new System.Drawing.Point(277, 49);
            this.confirm_radbtn.Name = "confirm_radbtn";
            this.confirm_radbtn.Size = new System.Drawing.Size(137, 22);
            this.confirm_radbtn.TabIndex = 14;
            this.confirm_radbtn.TabStop = true;
            this.confirm_radbtn.Text = "Confirm Request";
            this.confirm_radbtn.UseVisualStyleBackColor = true;
            // 
            // cancel_radbtn
            // 
            this.cancel_radbtn.AutoSize = true;
            this.cancel_radbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_radbtn.ForeColor = System.Drawing.Color.Black;
            this.cancel_radbtn.Location = new System.Drawing.Point(475, 49);
            this.cancel_radbtn.Name = "cancel_radbtn";
            this.cancel_radbtn.Size = new System.Drawing.Size(129, 22);
            this.cancel_radbtn.TabIndex = 15;
            this.cancel_radbtn.TabStop = true;
            this.cancel_radbtn.Text = "Cancel Request";
            this.cancel_radbtn.UseVisualStyleBackColor = true;
            // 
            // emp_comments_txtbox
            // 
            this.emp_comments_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.emp_comments_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emp_comments_txtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_comments_txtbox.Location = new System.Drawing.Point(55, 102);
            this.emp_comments_txtbox.Multiline = true;
            this.emp_comments_txtbox.Name = "emp_comments_txtbox";
            this.emp_comments_txtbox.Size = new System.Drawing.Size(582, 74);
            this.emp_comments_txtbox.TabIndex = 18;
            // 
            // emp_reviewreqs_authorize_btn
            // 
            this.emp_reviewreqs_authorize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.emp_reviewreqs_authorize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_reviewreqs_authorize_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emp_reviewreqs_authorize_btn.FlatAppearance.BorderSize = 0;
            this.emp_reviewreqs_authorize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.emp_reviewreqs_authorize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.emp_reviewreqs_authorize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_reviewreqs_authorize_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_reviewreqs_authorize_btn.ForeColor = System.Drawing.Color.White;
            this.emp_reviewreqs_authorize_btn.Location = new System.Drawing.Point(260, 182);
            this.emp_reviewreqs_authorize_btn.Name = "emp_reviewreqs_authorize_btn";
            this.emp_reviewreqs_authorize_btn.Size = new System.Drawing.Size(173, 25);
            this.emp_reviewreqs_authorize_btn.TabIndex = 20;
            this.emp_reviewreqs_authorize_btn.Text = "Submit";
            this.emp_reviewreqs_authorize_btn.UseVisualStyleBackColor = false;
            this.emp_reviewreqs_authorize_btn.Click += new System.EventHandler(this.emp_reviewreqs_authorize_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emp_reviewreqs_authorize_btn);
            this.panel2.Controls.Add(this.emp_comments_txtbox);
            this.panel2.Controls.Add(this.cancel_radbtn);
            this.panel2.Controls.Add(this.confirm_radbtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(36, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 219);
            this.panel2.TabIndex = 1;
            // 
            // EmpRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmpRequests";
            this.Size = new System.Drawing.Size(834, 542);
            this.Load += new System.EventHandler(this.EmpRequests_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_reqs_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView emp_reqs_datagrid;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton confirm_radbtn;
        private System.Windows.Forms.RadioButton cancel_radbtn;
        private System.Windows.Forms.TextBox emp_comments_txtbox;
        private System.Windows.Forms.Button emp_reviewreqs_authorize_btn;
        private System.Windows.Forms.Panel panel2;
    }
}
