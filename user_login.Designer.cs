namespace Academix
{
    partial class user_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stu_login_btn = new System.Windows.Forms.Button();
            this.bus_login_btn = new System.Windows.Forms.Button();
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(195, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nurturing the Brightest Minds for a Promising Future";
            // 
            // stu_login_btn
            // 
            this.stu_login_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.stu_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stu_login_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.stu_login_btn.ForeColor = System.Drawing.Color.White;
            this.stu_login_btn.Location = new System.Drawing.Point(153, 188);
            this.stu_login_btn.Name = "stu_login_btn";
            this.stu_login_btn.Size = new System.Drawing.Size(471, 46);
            this.stu_login_btn.TabIndex = 48;
            this.stu_login_btn.Text = "Login as Student";
            this.stu_login_btn.UseVisualStyleBackColor = false;
            this.stu_login_btn.Click += new System.EventHandler(this.stu_login_btn_Click);
            // 
            // bus_login_btn
            // 
            this.bus_login_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.bus_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bus_login_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.bus_login_btn.ForeColor = System.Drawing.Color.White;
            this.bus_login_btn.Location = new System.Drawing.Point(153, 273);
            this.bus_login_btn.Name = "bus_login_btn";
            this.bus_login_btn.Size = new System.Drawing.Size(471, 46);
            this.bus_login_btn.TabIndex = 49;
            this.bus_login_btn.Text = "Login as Bursar";
            this.bus_login_btn.UseVisualStyleBackColor = false;
            this.bus_login_btn.Click += new System.EventHandler(this.bus_login_btn_Click);
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_login_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin_login_btn.ForeColor = System.Drawing.Color.White;
            this.admin_login_btn.Location = new System.Drawing.Point(153, 360);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(471, 46);
            this.admin_login_btn.TabIndex = 50;
            this.admin_login_btn.Text = "Login as Admin";
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.admin_login_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(223, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 27);
            this.label6.TabIndex = 51;
            this.label6.Text = "Don\'t have an account? Signup";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.bus_login_btn);
            this.Controls.Add(this.stu_login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "user_login";
            this.Text = "Academix";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stu_login_btn;
        private System.Windows.Forms.Button bus_login_btn;
        private System.Windows.Forms.Button admin_login_btn;
        private System.Windows.Forms.Label label6;
    }
}