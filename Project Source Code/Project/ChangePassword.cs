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
    public partial class ChangePassword : Form
    {
        string d_pass = string.Empty;
        public object Streamwriter { get; private set; }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form management = new Management_Page();
            management.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oldPass.Text = "";
            newPass.Text = "";
            conNewPass.Text = "";
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (File.Exists("v.txt"))
            {
                StreamReader strmreader = new StreamReader("v.txt");
                string d_pass = string.Empty;
                d_pass = strmreader.ReadLine();
                strmreader.Close();
            }
        }

        private void btnChnage_Click(object sender, EventArgs e)
        {
            StreamReader strmreader = new StreamReader("v.txt");
            string d_pass = string.Empty;
            d_pass = strmreader.ReadLine();
            strmreader.Close();

            if (d_pass.ToString() == oldPass.Text.ToString())
            {
                if (newPass.Text == conNewPass.Text)
                {
                    StreamWriter strmwriter = new StreamWriter("v.txt");
                    strmwriter.WriteLine(newPass.Text);
                    MessageBox.Show("Password changed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    strmwriter.Close();

                }
                else MessageBox.Show("New password and Confirm new password does not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else MessageBox.Show("Old Password does not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

         }

        private void oldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void conNewPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
