namespace Project
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PWlbl = new System.Windows.Forms.Label();
            this.PW_txtbx = new System.Windows.Forms.TextBox();
            this.Tittle_lbl = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Login_exit = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PWlbl
            // 
            this.PWlbl.BackColor = System.Drawing.Color.Crimson;
            this.PWlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PWlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWlbl.ForeColor = System.Drawing.Color.White;
            this.PWlbl.Location = new System.Drawing.Point(22, 353);
            this.PWlbl.Name = "PWlbl";
            this.PWlbl.Size = new System.Drawing.Size(97, 25);
            this.PWlbl.TabIndex = 8;
            this.PWlbl.Text = "Password";
            this.PWlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PW_txtbx
            // 
            this.PW_txtbx.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PW_txtbx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_txtbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PW_txtbx.Location = new System.Drawing.Point(125, 353);
            this.PW_txtbx.Name = "PW_txtbx";
            this.PW_txtbx.Size = new System.Drawing.Size(248, 25);
            this.PW_txtbx.TabIndex = 0;
            this.PW_txtbx.TextChanged += new System.EventHandler(this.PW_txtbx_TextChanged);
            // 
            // Tittle_lbl
            // 
            this.Tittle_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tittle_lbl.BackColor = System.Drawing.Color.Crimson;
            this.Tittle_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tittle_lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle_lbl.ForeColor = System.Drawing.Color.White;
            this.Tittle_lbl.Location = new System.Drawing.Point(324, 27);
            this.Tittle_lbl.Name = "Tittle_lbl";
            this.Tittle_lbl.Size = new System.Drawing.Size(327, 57);
            this.Tittle_lbl.TabIndex = 3;
            this.Tittle_lbl.Text = "OPERA CAFE";
            this.Tittle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Black;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(298, 379);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 32);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 576);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Login_exit
            // 
            this.Login_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Login_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_exit.ForeColor = System.Drawing.Color.Crimson;
            this.Login_exit.Location = new System.Drawing.Point(67, 576);
            this.Login_exit.Name = "Login_exit";
            this.Login_exit.Size = new System.Drawing.Size(53, 29);
            this.Login_exit.TabIndex = 2;
            this.Login_exit.Text = "Exit";
            this.Login_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login_exit.UseVisualStyleBackColor = true;
            this.Login_exit.Click += new System.EventHandler(this.Login_exit_Click);
            // 
            // L1
            // 
            this.L1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(714, 8);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(75, 19);
            this.L1.TabIndex = 4;
            this.L1.Text = "Date:";
            // 
            // L2
            // 
            this.L2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(714, 27);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(75, 18);
            this.L2.TabIndex = 6;
            this.L2.Text = "Time:";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(762, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(222, 18);
            this.date.TabIndex = 5;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(762, 27);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(222, 18);
            this.time.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login As";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(125, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Administrator";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(996, 613);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Tittle_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PWlbl);
            this.Controls.Add(this.PW_txtbx);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PWlbl;
        private System.Windows.Forms.TextBox PW_txtbx;
        private System.Windows.Forms.Label Tittle_lbl;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Login_exit;
       // private myDatabaseDataSetTableAdapters.tableOfEmployeeTableAdapter tableOfEmployeeTableAdapter1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

