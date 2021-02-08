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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            this.ControlBox = false;
            timer1.Start();
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 3;

            
            if (rectangleShape2.Width >= 623)
            {
                timer1.Stop();
               
                Form a1 = new EmployeeInfo();
                a1.Show();
                Hide();
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
