namespace Project
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.bk_to_mngmnt = new System.Windows.Forms.Button();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnAddFood = new System.Windows.Forms.Button();
            this.foodidTXT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodnameTXT = new System.Windows.Forms.TextBox();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.deleteIdTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateidTXT = new System.Windows.Forms.TextBox();
            this.updatenameTXT = new System.Windows.Forms.TextBox();
            this.updatepriceTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bk_to_mngmnt
            // 
            this.bk_to_mngmnt.BackColor = System.Drawing.Color.Crimson;
            this.bk_to_mngmnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk_to_mngmnt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_to_mngmnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.bk_to_mngmnt.Location = new System.Drawing.Point(42, 3);
            this.bk_to_mngmnt.Name = "bk_to_mngmnt";
            this.bk_to_mngmnt.Size = new System.Drawing.Size(136, 23);
            this.bk_to_mngmnt.TabIndex = 24;
            this.bk_to_mngmnt.Text = "Back to Management";
            this.bk_to_mngmnt.UseVisualStyleBackColor = false;
            this.bk_to_mngmnt.Click += new System.EventHandler(this.bk_to_mngmnt_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(2, 3);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(34, 23);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 3;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(545, 12);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(90, 79);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 4;
            this.pictureBox20.TabStop = false;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.BackColor = System.Drawing.Color.DarkOrange;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(636, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 79);
            this.label19.TabIndex = 23;
            this.label19.Text = "FOODS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAddFood
            // 
            this.BtnAddFood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAddFood.BackColor = System.Drawing.Color.Green;
            this.BtnAddFood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFood.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnAddFood.Location = new System.Drawing.Point(350, 188);
            this.BtnAddFood.Name = "BtnAddFood";
            this.BtnAddFood.Size = new System.Drawing.Size(75, 80);
            this.BtnAddFood.TabIndex = 3;
            this.BtnAddFood.Text = "Add Food";
            this.BtnAddFood.UseVisualStyleBackColor = false;
            this.BtnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // foodidTXT
            // 
            this.foodidTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foodidTXT.BackColor = System.Drawing.Color.Bisque;
            this.foodidTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodidTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.foodidTXT.Location = new System.Drawing.Point(141, 188);
            this.foodidTXT.Name = "foodidTXT";
            this.foodidTXT.Size = new System.Drawing.Size(203, 20);
            this.foodidTXT.TabIndex = 0;
            this.foodidTXT.TextChanged += new System.EventHandler(this.foodidTXT_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(636, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 457);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // foodnameTXT
            // 
            this.foodnameTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foodnameTXT.BackColor = System.Drawing.Color.Bisque;
            this.foodnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodnameTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.foodnameTXT.Location = new System.Drawing.Point(141, 217);
            this.foodnameTXT.Name = "foodnameTXT";
            this.foodnameTXT.Size = new System.Drawing.Size(203, 20);
            this.foodnameTXT.TabIndex = 1;
            // 
            // priceTXT
            // 
            this.priceTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceTXT.BackColor = System.Drawing.Color.Bisque;
            this.priceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.priceTXT.Location = new System.Drawing.Point(141, 246);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(203, 20);
            this.priceTXT.TabIndex = 2;
            this.priceTXT.TextChanged += new System.EventHandler(this.priceTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Food";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(26, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Food ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Food Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(26, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Food Price:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1350, 729);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleShape3.BackColor = System.Drawing.Color.Cornsilk;
            this.rectangleShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape3.BorderWidth = 3;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape3.Location = new System.Drawing.Point(23, 522);
            this.rectangleShape3.Name = "rectangleShape1";
            this.rectangleShape3.Size = new System.Drawing.Size(407, 175);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleShape2.BackColor = System.Drawing.Color.Cornsilk;
            this.rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape2.Location = new System.Drawing.Point(23, 352);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(407, 114);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(23, 112);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(407, 175);
            // 
            // deleteIdTXT
            // 
            this.deleteIdTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteIdTXT.BackColor = System.Drawing.Color.Bisque;
            this.deleteIdTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteIdTXT.Location = new System.Drawing.Point(141, 427);
            this.deleteIdTXT.Name = "deleteIdTXT";
            this.deleteIdTXT.Size = new System.Drawing.Size(203, 20);
            this.deleteIdTXT.TabIndex = 4;
            this.deleteIdTXT.TextChanged += new System.EventHandler(this.foodidTXT_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(26, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Food ID:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 41);
            this.label5.TabIndex = 18;
            this.label5.Text = "Delete Food";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "Update Info";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // updateidTXT
            // 
            this.updateidTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateidTXT.BackColor = System.Drawing.Color.Bisque;
            this.updateidTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateidTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updateidTXT.Location = new System.Drawing.Point(141, 597);
            this.updateidTXT.Name = "updateidTXT";
            this.updateidTXT.Size = new System.Drawing.Size(203, 20);
            this.updateidTXT.TabIndex = 6;
            this.updateidTXT.TextChanged += new System.EventHandler(this.foodidTXT_TextChanged);
            // 
            // updatenameTXT
            // 
            this.updatenameTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updatenameTXT.BackColor = System.Drawing.Color.Bisque;
            this.updatenameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatenameTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updatenameTXT.Location = new System.Drawing.Point(141, 626);
            this.updatenameTXT.Name = "updatenameTXT";
            this.updatenameTXT.Size = new System.Drawing.Size(203, 20);
            this.updatenameTXT.TabIndex = 7;
            // 
            // updatepriceTXT
            // 
            this.updatepriceTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updatepriceTXT.BackColor = System.Drawing.Color.Bisque;
            this.updatepriceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepriceTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updatepriceTXT.Location = new System.Drawing.Point(141, 655);
            this.updatepriceTXT.Name = "updatepriceTXT";
            this.updatepriceTXT.Size = new System.Drawing.Size(203, 20);
            this.updatepriceTXT.TabIndex = 8;
            this.updatepriceTXT.TextChanged += new System.EventHandler(this.priceTXT_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.BackColor = System.Drawing.Color.Cornsilk;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(26, 597);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Food ID:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.BackColor = System.Drawing.Color.Cornsilk;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(26, 625);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Food Name:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.BackColor = System.Drawing.Color.Cornsilk;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(26, 654);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Food Price:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.DarkOrange;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(636, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(666, 39);
            this.label11.TabIndex = 12;
            this.label11.Text = "Available Food Info";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(350, 593);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 84);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDelete.Location = new System.Drawing.Point(350, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1137, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 36);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search Food";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.updateidTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updatenameTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.updatepriceTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteIdTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.foodnameTXT);
            this.Controls.Add(this.foodidTXT);
            this.Controls.Add(this.BtnAddFood);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.bk_to_mngmnt);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bk_to_mngmnt;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnAddFood;
        private System.Windows.Forms.TextBox foodidTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox foodnameTXT;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.TextBox deleteIdTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateidTXT;
        private System.Windows.Forms.TextBox updatenameTXT;
        private System.Windows.Forms.TextBox updatepriceTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}