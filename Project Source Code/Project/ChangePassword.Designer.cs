namespace Project
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.conNewPass = new System.Windows.Forms.TextBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.bk_to_mngmnt = new System.Windows.Forms.Button();
            this.btnChnage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirm New Password :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(399, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oldPass
            // 
            this.oldPass.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.oldPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.oldPass.Location = new System.Drawing.Point(220, 165);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(254, 27);
            this.oldPass.TabIndex = 0;
            this.oldPass.TextChanged += new System.EventHandler(this.oldPass_TextChanged);
            // 
            // newPass
            // 
            this.newPass.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.newPass.Location = new System.Drawing.Point(220, 205);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(254, 27);
            this.newPass.TabIndex = 1;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // conNewPass
            // 
            this.conNewPass.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.conNewPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNewPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.conNewPass.Location = new System.Drawing.Point(220, 245);
            this.conNewPass.Name = "conNewPass";
            this.conNewPass.Size = new System.Drawing.Size(254, 27);
            this.conNewPass.TabIndex = 2;
            this.conNewPass.TextChanged += new System.EventHandler(this.conNewPass_TextChanged);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(6, 10);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(40, 31);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 7;
            this.pictureBox19.TabStop = false;
            // 
            // bk_to_mngmnt
            // 
            this.bk_to_mngmnt.BackColor = System.Drawing.Color.Crimson;
            this.bk_to_mngmnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk_to_mngmnt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_to_mngmnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.bk_to_mngmnt.Location = new System.Drawing.Point(55, 10);
            this.bk_to_mngmnt.Name = "bk_to_mngmnt";
            this.bk_to_mngmnt.Size = new System.Drawing.Size(175, 31);
            this.bk_to_mngmnt.TabIndex = 5;
            this.bk_to_mngmnt.Text = "Back to Management";
            this.bk_to_mngmnt.UseVisualStyleBackColor = false;
            this.bk_to_mngmnt.Click += new System.EventHandler(this.bk_to_mngmnt_Click);
            // 
            // btnChnage
            // 
            this.btnChnage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChnage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChnage.Location = new System.Drawing.Point(318, 288);
            this.btnChnage.Name = "btnChnage";
            this.btnChnage.Size = new System.Drawing.Size(75, 32);
            this.btnChnage.TabIndex = 3;
            this.btnChnage.Text = "Change";
            this.btnChnage.UseVisualStyleBackColor = false;
            this.btnChnage.Click += new System.EventHandler(this.btnChnage_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(138, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Change Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(512, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChnage);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.bk_to_mngmnt);
            this.Controls.Add(this.conNewPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox conNewPass;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Button bk_to_mngmnt;
        private System.Windows.Forms.Button btnChnage;
        private System.Windows.Forms.Label label4;
    }
}