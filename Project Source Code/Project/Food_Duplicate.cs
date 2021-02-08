using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Food_Duplicate : Form
    {
        public Food_Duplicate()
        {
            InitializeComponent();
        }

        

        private void Food_Duplicate_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=mysqlcsharp;sslMode=none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM mysqlcsharp.food ", connection);


                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "food");
                dataGridView1.DataSource = ds.Tables["food"];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            if (foodidTXT.Text != "" && foodnameTXT.Text!="" && priceTXT.Text!="")
            {

                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "INSERT INTO mysqlcsharp.food (id, foodname, price) VALUES ('" + foodidTXT.Text + "','" + foodnameTXT.Text + "', '" + priceTXT.Text + "');";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Data Saved Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (myReader.Read())
                    {

                    }
                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("One or more field left empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateidTXT.Text != "")
            {

                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "UPDATE mysqlcsharp.food set id='" + updateidTXT.Text + "', foodname='" + updatenameTXT.Text + "', price='" + updatepriceTXT.Text + "' where id='" + updateidTXT.Text + "'  ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    /*myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (myReader.Read())
                    {

                    }*/


                    if (cmdDataBase.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("ID not found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Food ID must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
            string Query = "DELETE from mysqlcsharp.food where id='" + deleteIdTXT.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
               // myReader = cmdDataBase.ExecuteReader();
               // MessageBox.Show("Data Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update();
                /*while (myReader.Read())
                {

                }*/

                if (cmdDataBase.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("ID not found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form mngment = new Management_page_duplicate();
            mngment.Show();
            Hide();
        }

        private void Food_Duplicate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

        }

        private void updatepriceTXT_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updateidTXT.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            updatenameTXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            updatepriceTXT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
