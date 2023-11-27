namespace BTM495_Team4
{
    partial class EmployeeLogin
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
            this.emp_login_button = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_username_txtbox = new System.Windows.Forms.TextBox();
            this.emp_password_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_showpass_chkbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.managerp_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_login_button
            // 
            this.emp_login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.emp_login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_login_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emp_login_button.FlatAppearance.BorderSize = 0;
            this.emp_login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(245)))), ((int)(((byte)(106)))));
            this.emp_login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(245)))), ((int)(((byte)(106)))));
            this.emp_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_login_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_login_button.ForeColor = System.Drawing.Color.White;
            this.emp_login_button.Location = new System.Drawing.Point(281, 318);
            this.emp_login_button.Name = "emp_login_button";
            this.emp_login_button.Size = new System.Drawing.Size(133, 56);
            this.emp_login_button.TabIndex = 1;
            this.emp_login_button.Text = "LOGIN";
            this.emp_login_button.UseVisualStyleBackColor = false;
            this.emp_login_button.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(566, 9);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(22, 23);
            this.quit.TabIndex = 2;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // emp_username_txtbox
            // 
            this.emp_username_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.emp_username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emp_username_txtbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_username_txtbox.Location = new System.Drawing.Point(281, 148);
            this.emp_username_txtbox.Multiline = true;
            this.emp_username_txtbox.Name = "emp_username_txtbox";
            this.emp_username_txtbox.Size = new System.Drawing.Size(275, 30);
            this.emp_username_txtbox.TabIndex = 5;
            this.emp_username_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emp_password_txtbox
            // 
            this.emp_password_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.emp_password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emp_password_txtbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_password_txtbox.Location = new System.Drawing.Point(281, 213);
            this.emp_password_txtbox.Multiline = true;
            this.emp_password_txtbox.Name = "emp_password_txtbox";
            this.emp_password_txtbox.PasswordChar = '*';
            this.emp_password_txtbox.Size = new System.Drawing.Size(275, 30);
            this.emp_password_txtbox.TabIndex = 7;
            this.emp_password_txtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emp_showpass_chkbox
            // 
            this.emp_showpass_chkbox.AutoSize = true;
            this.emp_showpass_chkbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_showpass_chkbox.Location = new System.Drawing.Point(416, 249);
            this.emp_showpass_chkbox.Name = "emp_showpass_chkbox";
            this.emp_showpass_chkbox.Size = new System.Drawing.Size(130, 22);
            this.emp_showpass_chkbox.TabIndex = 8;
            this.emp_showpass_chkbox.Text = "Show Password";
            this.emp_showpass_chkbox.UseVisualStyleBackColor = true;
            this.emp_showpass_chkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manager Portal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // managerp_button
            // 
            this.managerp_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.managerp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerp_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.managerp_button.FlatAppearance.BorderSize = 0;
            this.managerp_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.managerp_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.managerp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerp_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerp_button.ForeColor = System.Drawing.Color.White;
            this.managerp_button.Location = new System.Drawing.Point(39, 339);
            this.managerp_button.Name = "managerp_button";
            this.managerp_button.Size = new System.Drawing.Size(173, 35);
            this.managerp_button.TabIndex = 2;
            this.managerp_button.Text = "SIGN IN";
            this.managerp_button.UseVisualStyleBackColor = false;
            this.managerp_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Paid Time Off System";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(245)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.managerp_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTM495_Team4.Properties.Resources.employee1;
            this.pictureBox1.Location = new System.Drawing.Point(73, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.emp_showpass_chkbox);
            this.Controls.Add(this.emp_password_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emp_username_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.emp_login_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button emp_login_button;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_username_txtbox;
        private System.Windows.Forms.TextBox emp_password_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox emp_showpass_chkbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button managerp_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

