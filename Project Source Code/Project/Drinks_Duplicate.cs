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
    public partial class Drinks_Duplicate : Form
    {
        public Drinks_Duplicate()
        {
            InitializeComponent();
        }

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form mngmnt = new Management_page_duplicate();
            mngmnt.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (drinkIdTXT.Text != "" && drinknameTXT.Text!="" && drinkpriceTXT.Text!="")
            {

                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "INSERT INTO mysqlcsharp.drink (id, name, price) VALUES ('" + drinkIdTXT.Text + "','" + drinknameTXT.Text + "', '" + drinkpriceTXT.Text + "');";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
            string Query = "DELETE from mysqlcsharp.drink where id='" + deleteidTXT.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                //myReader = cmdDataBase.ExecuteReader();
                //MessageBox.Show("Data Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string constring = "server=localhost;user id=root;database=mysqlcsharp;sslMode=none";
                string Query = "UPDATE mysqlcsharp.drink set id='" + updatedrinkidTXT.Text + "', name='" + updatedrinknameTXT.Text + "', price='" + updatedrinkpriceTXT.Text + "' where id='" + updatedrinkidTXT.Text + "'  ";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    /*  myReader = cmdDataBase.ExecuteReader();
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
            else MessageBox.Show("Drink ID must not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Drinks_Duplicate_Load(object sender, EventArgs e)
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            updatedrinkidTXT.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            updatedrinknameTXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            updatedrinkpriceTXT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
   }

