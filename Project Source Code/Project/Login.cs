using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    
    public partial class Login_form : Form
    {
        
       // string un = string.Empty;
        //string d_pw = string.Empty;
        //string d_un = string.Empty;

        //string user = string.Empty;

        string pw = string.Empty;
        string pass = string.Empty;
        

        public Login_form()
        {
           
            InitializeComponent();
        }

        private void UN_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PW_txtbx_TextChanged(object sender, EventArgs e)
        {
           pw = PW_txtbx.Text;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrator")
            {
                StreamReader sr = new StreamReader("v.txt");
                pass = sr.ReadLine();
                sr.Close();

                if (PW_txtbx.Text.ToString() == pass.ToString())
                {
                    Management_Page f2 = new Management_Page();
                    f2.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Employee")
            {
                Form n = new Management_page_duplicate();
                n.Show();
                Hide();
            }
            else MessageBox.Show("Please select user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you reaaly want to exit?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToLongDateString(); 
            time.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Employee")
            {
                PW_txtbx.Enabled = false;
                PW_txtbx.Visible = false;
                PWlbl.Visible = false;

            }
            else
            {
                PW_txtbx.Enabled = true;
                PWlbl.Visible = true;
                PW_txtbx.Visible = true;
            }
        }
    }
}
