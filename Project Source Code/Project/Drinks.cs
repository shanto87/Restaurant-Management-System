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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
        }

      

        private void Drinks_Load(object sender, EventArgs e)
        {

            try
            {

                MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=mysqlcsharp;sslMode=none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM mysqlcsharp.drink ", connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "drink");
                dataGridView1.DataSource = ds.Tables["drink"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bk_to_mngmnt_Click_1(object sender, EventArgs e)
        {
            Form mngmnt = new Management_Page();
            mngmnt.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form g = new DrinksSearch();
            g.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (drinkIdTXT.Text != "" && drinknameTXT.Text!="" && drinkpriceTXT.Text!="")
            {

                
                try
                {
                    string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                    string Query = "INSERT INTO mysqlcsharp.drink (id, name, price) VALUES ('" + drinkIdTXT.Text + "','" + drinknameTXT.Text + "', '" + drinkpriceTXT.Text + "');";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "DELETE from mysqlcsharp.drink where id='" + deleteidTXT.Text + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;


                conDataBase.Open();
                //myReader = cmdDataBase.ExecuteReader();                
                Update();

               /* while (myReader.Read())
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updatedrinkidTXT.Text != "")
            {

                
                try
                {
                    string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                    string Query = "UPDATE mysqlcsharp.drink set id='" + updatedrinkidTXT.Text + "', name='" + updatedrinknameTXT.Text + "', price='" + updatedrinkpriceTXT.Text + "' where id='" + updatedrinkidTXT.Text + "'  ";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    //MySqlDataReader myReader;


                    conDataBase.Open();
                    // myReader = cmdDataBase.ExecuteReader();

                    if (cmdDataBase.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("ID not found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else MessageBox.Show("Drink ID must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updatedrinkidTXT.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            updatedrinknameTXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           updatedrinkpriceTXT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
