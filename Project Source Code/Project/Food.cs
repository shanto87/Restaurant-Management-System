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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form mngment = new Management_Page();
            mngment.Show();
            Hide();
        }

        private void Food_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void foodidTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            if (foodidTXT.Text != "" && foodnameTXT.Text!="" && priceTXT.Text!="")
            {

                
                try
                {
                    string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                    string Query = "INSERT INTO mysqlcsharp.food (id, foodname, price) VALUES ('" + foodidTXT.Text + "','" + foodnameTXT.Text + "', '" + priceTXT.Text + "');";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;


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

        private void priceTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateidTXT.Text != "")
            {

                
                try
                {
                    string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                    string Query = "UPDATE mysqlcsharp.food set id='" + updateidTXT.Text + "', foodname='" + updatenameTXT.Text + "', price='" + updatepriceTXT.Text + "' where id='" + updateidTXT.Text + "'  ";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                  //  MySqlDataReader myReader;


                    conDataBase.Open();
                    if (cmdDataBase.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("ID not found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //myReader = cmdDataBase.ExecuteReader();
                    //MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*while (myReader.Read())
                    {

                    }*/
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
            
            try
            {
                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "DELETE from mysqlcsharp.food where id='" + deleteIdTXT.Text + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;


                conDataBase.Open();
               // myReader = cmdDataBase.ExecuteReader();                       
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form f = new FoodSearch();
            f.Show();
            Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updateidTXT.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            updatenameTXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            updatepriceTXT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
