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
    public partial class FoodSearch : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=mysqlcsharp;sslMode=none");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public FoodSearch()
        {
            InitializeComponent();
        }

        private void FoodSearch_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM mysqlcsharp.food WHERE CONCAT(`id`, `foodname`, `price`) like'%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = valuetosearchTXT.Text.ToString();
            searchData(valueToSearch);
        }

        private void bk_Click(object sender, EventArgs e)
        {
            Form r = new Food();
            r.Show();
            Hide();
        }
    }
}
