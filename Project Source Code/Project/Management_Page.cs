using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Management_Page : Form
    {
        public Management_Page()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login_form f1 = new Login_form();
            f1.Show();
            Hide();
        }

        private void Management_Page_Load(object sender, EventArgs e)
        {
            timer1.Start();
            datelabel.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void employee_btn_Click(object sender, EventArgs e)
        {

            Form loading = new loading();
            loading.Show();
            Hide();

            //Form employee = new EmployeeList();
            //employee.Show();
           // Hide();
        }

        private void food_btn_Click(object sender, EventArgs e)
        {
            Form food = new Food();
            food.Show();
            Hide();
        }

        private void drink_btn_Click(object sender, EventArgs e)
        {
            Form drinks = new Drinks();
            drinks.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pos_btn_Click(object sender, EventArgs e)
        {
            Form pos = new POS();
            pos.Show();            
        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            Form changePassword = new ChangePassword();
            changePassword.Show();
            Hide();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void datelabel_Click(object sender, EventArgs e)
        {

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
