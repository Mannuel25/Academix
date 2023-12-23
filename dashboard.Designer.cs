namespace Academix
{
    partial class dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matric_number = new System.Windows.Forms.DataGridViewButtonColumn();
            this.full_name = new System.Windows.Forms.DataGridViewButtonColumn();
            this.email = new System.Windows.Forms.DataGridViewButtonColumn();
            this.phone_no = new System.Windows.Forms.DataGridViewButtonColumn();
            this.level = new System.Windows.Forms.DataGridViewButtonColumn();
            this.faculty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.amt_paid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fees_balance = new System.Windows.Forms.DataGridViewButtonColumn();
            this.view_depts = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view_bursars = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.all_stds = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.signoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matric_number,
            this.full_name,
            this.email,
            this.phone_no,
            this.level,
            this.faculty,
            this.dept,
            this.amt_paid,
            this.fees_balance});
            this.dataGridView1.Location = new System.Drawing.Point(30, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(784, 136);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matric_number
            // 
            this.matric_number.DataPropertyName = "matric_number";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matric_number.DefaultCellStyle = dataGridViewCellStyle1;
            this.matric_number.HeaderText = "Matric Number";
            this.matric_number.Name = "matric_number";
            this.matric_number.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.full_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.full_name.HeaderText = "Full Name";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.email.DefaultCellStyle = dataGridViewCellStyle3;
            this.email.HeaderText = "Email Address";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone_no
            // 
            this.phone_no.DataPropertyName = "phone_no";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phone_no.DefaultCellStyle = dataGridViewCellStyle4;
            this.phone_no.HeaderText = "Phone Number";
            this.phone_no.Name = "phone_no";
            this.phone_no.ReadOnly = true;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.level.DefaultCellStyle = dataGridViewCellStyle5;
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // faculty
            // 
            this.faculty.DataPropertyName = "faculty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faculty.DefaultCellStyle = dataGridViewCellStyle6;
            this.faculty.HeaderText = "Faculty";
            this.faculty.Name = "faculty";
            this.faculty.ReadOnly = true;
            // 
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dept.DefaultCellStyle = dataGridViewCellStyle7;
            this.dept.HeaderText = "Department";
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            // 
            // amt_paid
            // 
            this.amt_paid.DataPropertyName = "amt_paid";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.amt_paid.DefaultCellStyle = dataGridViewCellStyle8;
            this.amt_paid.HeaderText = "Amount Paid";
            this.amt_paid.Name = "amt_paid";
            this.amt_paid.ReadOnly = true;
            this.amt_paid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amt_paid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fees_balance
            // 
            this.fees_balance.DataPropertyName = "fees_balance";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fees_balance.DefaultCellStyle = dataGridViewCellStyle9;
            this.fees_balance.HeaderText = "School Fees Balance";
            this.fees_balance.Name = "fees_balance";
            this.fees_balance.ReadOnly = true;
            // 
            // view_depts
            // 
            this.view_depts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view_depts.Location = new System.Drawing.Point(447, 80);
            this.view_depts.Name = "view_depts";
            this.view_depts.Size = new System.Drawing.Size(119, 23);
            this.view_depts.TabIndex = 9;
            this.view_depts.Text = "View Departments";
            this.view_depts.UseVisualStyleBackColor = true;
            this.view_depts.Click += new System.EventHandler(this.view_depts_Click);
            // 
            // search_input
            // 
            this.search_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_input.Location = new System.Drawing.Point(604, 82);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(99, 20);
            this.search_input.TabIndex = 10;
            this.search_input.TextChanged += new System.EventHandler(this.search_input_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_btn.Location = new System.Drawing.Point(740, 82);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(64, 23);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // view_bursars
            // 
            this.view_bursars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view_bursars.Location = new System.Drawing.Point(314, 82);
            this.view_bursars.Name = "view_bursars";
            this.view_bursars.Size = new System.Drawing.Size(99, 23);
            this.view_bursars.TabIndex = 50;
            this.view_bursars.Text = "View all Bursars";
            this.view_bursars.UseVisualStyleBackColor = true;
            this.view_bursars.Click += new System.EventHandler(this.view_bursars_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 51;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // all_stds
            // 
            this.all_stds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_stds.Location = new System.Drawing.Point(175, 82);
            this.all_stds.Name = "all_stds";
            this.all_stds.Size = new System.Drawing.Size(99, 23);
            this.all_stds.TabIndex = 52;
            this.all_stds.Text = "View all Students";
            this.all_stds.UseVisualStyleBackColor = true;
            this.all_stds.Click += new System.EventHandler(this.all_stds_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Double click on any record to make changes";
            // 
            // signoutBtn
            // 
            this.signoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signoutBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.signoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.ForeColor = System.Drawing.Color.White;
            this.signoutBtn.Location = new System.Drawing.Point(728, 356);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(86, 34);
            this.signoutBtn.TabIndex = 64;
            this.signoutBtn.Text = "Logout";
            this.signoutBtn.UseVisualStyleBackColor = false;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 402);
            this.Controls.Add(this.signoutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.all_stds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_bursars);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.view_depts);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academix | Admin Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button view_depts;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button view_bursars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button all_stds;
        private System.Windows.Forms.DataGridViewButtonColumn matric_number;
        private System.Windows.Forms.DataGridViewButtonColumn full_name;
        private System.Windows.Forms.DataGridViewButtonColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn phone_no;
        private System.Windows.Forms.DataGridViewButtonColumn level;
        private System.Windows.Forms.DataGridViewButtonColumn faculty;
        private System.Windows.Forms.DataGridViewButtonColumn dept;
        private System.Windows.Forms.DataGridViewButtonColumn amt_paid;
        private System.Windows.Forms.DataGridViewButtonColumn fees_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signoutBtn;

    }
}