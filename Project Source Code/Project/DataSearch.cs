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
    public partial class DataSearch : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;


        public DataSearch()
        {
            InitializeComponent();
        }

        private void DataSearch_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        public void searchData(string valueToSearch)
        {
            string query = "SELECT *  FROM mysqlcsharp.employeeinfo WHERE CONCAT(`FirstName`, `LastName`, `PhoneNumber`, `NidNumber`, `Age`, `Address`, `JoinDate`) like'%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);

            dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSearch.RowTemplate.Height = 195;
            dataGridViewSearch.AllowUserToAddRows = false;

            table = new DataTable();
            adapter.Fill(table);
            dataGridViewSearch.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridViewSearch.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            adapter.Dispose();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = valueToSearchTXT.Text.ToString();
            searchData(valueToSearch);
        }

        private void bk_Click(object sender, EventArgs e)
        {
            Form back = new Data_View();
            back.Show();
            Hide();
        }
    }
}
