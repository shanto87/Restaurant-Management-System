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
    public partial class Management_page_duplicate : Form
    {
        public Management_page_duplicate()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login_form f1 = new Login_form();
            f1.Show();
            Hide();
        }

        private void FoodBtnD_Click(object sender, EventArgs e)
        {
            Form food = new Food_Duplicate();
            food.Show();
            Hide();
        }

        private void DrinkBtnD_Click(object sender, EventArgs e)
        {
            Form drinks = new Drinks_Duplicate();
            drinks.Show();
            Hide();
        }

        private void POSBtnD_Click(object sender, EventArgs e)
        {
            Form pos = new POS();
            pos.Show();
        }

        private void Management_page_duplicate_Load(object sender, EventArgs e)
        {
            timer1.Start();
            datelabel.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
