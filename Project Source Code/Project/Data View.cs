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
using System.IO;

namespace Project
{
    public partial class Data_View : Form
    {
        public Data_View()
        {
            InitializeComponent();
        }              
     
        private void Data_View_Load(object sender, EventArgs e)
        {         
             try {

                MySqlConnection connection = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM mysqlcsharp.employeeinfo ", connection);
                
                connection.Open();

                DataSet ds = new DataSet();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 210;
                dataGridView1.AllowUserToAddRows = false;

                adapter.Fill(ds, "employyeinfo");
                dataGridView1.DataSource = ds.Tables["employyeinfo"];

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                adapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }                       
        }
        

        private void bk_Click(object sender, EventArgs e)
        {
            Form mg = new EmployeeInfo();
            mg.Show();
            Hide();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form datasearch = new DataSearch();
            datasearch.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                string constring = "server=localhost;user id=root;database=mysqlcsharp; sslMode=none";
                string Query = "DELETE from mysqlcsharp.employeeinfo where NidNumber='" + deleteDataTXT.Text + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
               // MySqlDataReader myReader;

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
                else MessageBox.Show("Data not found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deleteDataTXT.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
    }

