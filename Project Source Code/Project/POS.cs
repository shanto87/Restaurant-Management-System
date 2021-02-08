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

    public partial class POS : Form
    {
        MySqlConnection connectionFood = new MySqlConnection("server=localhost;user id=root;database=mysqlcsharp;sslMode=none");
        MySqlCommand commandFood;
        MySqlDataAdapter adapterFood;
        DataTable tableFood;

        MySqlConnection connectionDrink = new MySqlConnection("server=localhost;user id=root;database=mysqlcsharp;sslMode=none");
        MySqlCommand commandDrink;
        MySqlDataAdapter adapterDrink;
        DataTable tableDrink;

        double change = 0;
        double tax = 0;
        double cash = 0;
        double price = 0;
        double grandTotal = 0;
        
        string order = string.Empty;

        string insertName = string.Empty;
        int insertPrice = 0;
        int insertQuantity = 1;

        MySqlConnection connection = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");
        MySqlConnection connection2 = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");

        MySqlCommand command;
        MySqlCommand command2;

        MySqlDataReader mdr;
        MySqlDataReader mdr2;

        public POS()
        {
            InitializeComponent();
        }

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form mgt = new Management_Page();
            mgt.Show();
            Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }



        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void POS_Load(object sender, EventArgs e)
        {
            searchDataFood("");
            cashbox.Enabled = false;
            taxbox.Enabled = false;
            changebox.Enabled = false;
            calculate.Enabled = false;
            totalbx.Enabled = false;
            try
            {

                MySqlConnection connection = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM mysqlcsharp.food", connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "food");
                dataGridViewFOOD.DataSource = ds.Tables["food"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            try
            {

                MySqlConnection connection2 = new MySqlConnection("server=localhost; user id=root; database=mysqlcsharp; sslMode=none");
                MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM mysqlcsharp.drink ", connection2);

                connection2.Open();

                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2, "drink");
                dataGridViewDRINK.DataSource = ds2.Tables["drink"];
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        private void print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawString(shopnametxtbx.Text, new Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 120, 50);

            e.Graphics.DrawString("Customer Name : " + cntxtbx.Text, new Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Black, 50, 160);
            e.Graphics.DrawString("Date : " + dateTimePicker.Text, new Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Black, 550, 160);
            //e.Graphics.DrawString("Item Name                        Quantity            Per Unit Price                  Total", new Font("Book Antiqua", 10,FontStyle.Bold),Brushes.Black,50,180);

            e.Graphics.DrawString("Order Details: ", new Font("Book Antiqua", 10, FontStyle.Underline), Brushes.Blue, 50, 1200);

            Bitmap objMp = new Bitmap(this.rcptGRID.Width, this.rcptGRID.Height);
            rcptGRID.DrawToBitmap(objMp, new Rectangle(0, 0, this.rcptGRID.Width, this.rcptGRID.Height));
            e.Graphics.DrawImage(objMp, 50, 200);

            // e.Graphics.DrawString(rcptBox.Text, new Font("Book Antiqua", 12, FontStyle.Regular), Brushes.Black, 50, 200);
            int endline = rcptGRID.Height;

            e.Graphics.DrawString("================================================================", new Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 50, endline+15);

            e.Graphics.DrawString("Total Price = " + totalbx.Text + "/-   (Vat  "+taxbox.Text+"% included) ", new Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Black, 50, endline+30);
            e.Graphics.DrawString("Cash:  " + cashbox.Text+"/-", new Font("Book Antiqua", 10,FontStyle.Bold),Brushes.Black,50,endline+45);
            e.Graphics.DrawString("Change:  " + changebox.Text+"/-", new Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Black, 50, endline+60);
            e.Graphics.DrawString("Thanks for having our service. Come again... Thank You!!!", new Font("Book Antiqua", 9, FontStyle.Regular), Brushes.Black, 50, endline+80);
        }

        private void shopnametxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            totalbx.Text = "";
            //rcptBox.Text = "";
            price = 0;
            cashbox.Text = "";
            changebox.Text = "";
            totalbx.Text = "";
            priceTotal.Text = "";
            taxbox.Text = "";
            grandTotal = 0;
            rcptGRID.Rows.Clear();
            //order += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }

        private void custominputtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (custominputprice.Text == string.Empty && custominputtxt.Text == string.Empty)
            {
                MessageBox.Show("Food name or Price cannot be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                price = price + int.Parse(custominputprice.Text);
               // this.rcptBox.Text += custominputtxt.Text + "                                              " + custominputprice.Text + "/-" + Environment.NewLine;
                order = "";
                custominputprice.Text = "";
                custominputtxt.Text = "";
                MessageBox.Show("Successfully Inserted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void custominputprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void namedateins_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Inserted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void yoyal_Click(object sender, EventArgs e)
        {
            
            if (cashbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter cash amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (taxbox.Text == string.Empty)
            {
                MessageBox.Show("Tax field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                cash = double.Parse(cashbox.Text);
                tax = double.Parse(taxbox.Text);
                price = double.Parse(priceTotal.Text) + ((double.Parse(priceTotal.Text) * tax) / 100);

                change = cash - price;
                changebox.Text = change.ToString();                
                totalbx.Text = price.ToString();
                
                if(change<0)
                {
                    MessageBox.Show("Pay " + (change * -1) + "/- More!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cashbox.Text = totalbx.Text;
                    changebox.Text = "0";                    
                }
                
            }
        }
    

        private void totalbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            priceTotal.Text = grandTotal.ToString();

            cashbox.Enabled = true;
            taxbox.Enabled = true;
            changebox.Enabled = true;
            calculate.Enabled = true;
            totalbx.Enabled = true;
        }

        private void cashbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNfoodSearch_Click(object sender, EventArgs e)
        {
            if (foodidTXT.Text != "")
            {
                if (foodnameTXT.Text == "")
                {
                    connection.Open();
                    string query = "SELECT * FROM mysqlcsharp.food where id=" + foodidTXT.Text;
                    command = new MySqlCommand(query, connection);
                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {
                        foodnameTXT.Text = mdr.GetString("foodname");
                        foodpriceTXT.Text = mdr.GetString("price");

                        insertPrice = int.Parse(foodpriceTXT.Text);
                        insertName = foodnameTXT.Text;
                    }
                    else MessageBox.Show("No data found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                else MessageBox.Show("Clear all data first to search again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Food ID field is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNdrinkSearch_Click(object sender, EventArgs e)
        {
            if (drinkidTXT.Text != "")
            {
                if (drinknameTXT.Text == "")
                {
                    connection2.Open();
                    string query2 = "SELECT * FROM mysqlcsharp.drink where id=" + drinkidTXT.Text;
                    command2 = new MySqlCommand(query2, connection2);
                    mdr2 = command2.ExecuteReader();
                    if (mdr2.Read())
                    {
                        drinknameTXT.Text = mdr2.GetString("name");
                        drinkpriceTXT.Text = mdr2.GetString("price");

                        insertPrice = int.Parse(drinkpriceTXT.Text);
                        insertName = drinknameTXT.Text;
                    }
                    else MessageBox.Show("No data found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection2.Close();
                }
                else MessageBox.Show("Clear all data first to search again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Drink ID field is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNfoodInsert_Click(object sender, EventArgs e)
        {
            if (foodidTXT.Text != "")
            {
            
                insertQuantity = int.Parse(foodquantityTXT.Text);
                grandTotal = grandTotal + (insertQuantity * insertPrice);
                //rcptBox.Text += insertName + "                      " + insertQuantity + "          " + foodpriceTXT.Text + "/- Per Unit                    " + insertQuantity * insertPrice + Environment.NewLine;

                rcptGRID.Rows.Add(foodnameTXT.Text,foodpriceTXT.Text,foodquantityTXT.Text,(insertQuantity*insertPrice));

                foodidTXT.Text = "";
                foodnameTXT.Text = "";
                foodpriceTXT.Text = "";
                foodquantityTXT.Text = "1";
            }
            else MessageBox.Show("Food ID field left blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNDrinkInsert_Click(object sender, EventArgs e)
        {
            if (drinkidTXT.Text != "")
            {
                insertQuantity = int.Parse(drinkquantityTXT.Text);
                grandTotal = grandTotal + (insertQuantity * insertPrice);
                //rcptBox.Text += insertName + "                      " + insertQuantity + "          " + drinkpriceTXT.Text + "/- Per Unit                   " + insertQuantity * insertPrice + Environment.NewLine;

                rcptGRID.Rows.Add(drinknameTXT.Text, drinkpriceTXT.Text, drinkquantityTXT.Text, (insertQuantity * insertPrice));
                drinkidTXT.Text = "";
                drinknameTXT.Text = "";
                drinkpriceTXT.Text = "";
                drinkquantityTXT.Text = "1";
            }
            else MessageBox.Show("Drink ID field left blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFoodFInd_Click(object sender, EventArgs e)
        {
            string valueToSearchFood = TXTfoodFind.Text.ToString();
            searchDataFood(valueToSearchFood);

        }
        public void searchDataFood(string valueToSearchFood)
        {
            try {
                string queryFood = "SELECT * FROM mysqlcsharp.food WHERE CONCAT(`id`, `foodname`, `price`) like'%" + valueToSearchFood + "%'";
                commandFood = new MySqlCommand(queryFood, connectionFood);
                adapterFood = new MySqlDataAdapter(commandFood);
                tableFood = new DataTable();
                adapterFood.Fill(tableFood);
                dataGridViewFOOD.DataSource = tableFood;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchDataDrink(string valueToSearchDrink)
        {
            try
            {
                string queryDrink = "SELECT * FROM mysqlcsharp.drink WHERE CONCAT(`id`, `name`, `price`) like'%" + valueToSearchDrink + "%'";
                commandDrink = new MySqlCommand(queryDrink, connectionDrink);
                adapterDrink = new MySqlDataAdapter(commandDrink);
                tableDrink = new DataTable();
                adapterDrink.Fill(tableDrink);
                dataGridViewDRINK.DataSource = tableDrink;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDrinkFind_Click(object sender, EventArgs e)
        {
            string valueToSearchDrink = TXTdrinkFind.Text.ToString();
            searchDataDrink(valueToSearchDrink);
        }

        private void btnCLRF_Click(object sender, EventArgs e)
        {
            TXTfoodFind.Text = "";
            foodidTXT.Text = "";
            foodnameTXT.Text = "";
            foodpriceTXT.Text = "";
            foodquantityTXT.Text = "";
        }

        private void btnCLRD_Click(object sender, EventArgs e)
        {
            TXTdrinkFind.Text = "";
            drinkidTXT.Text = "";
            drinknameTXT.Text = "";
            drinkpriceTXT.Text = "";
            drinkquantityTXT.Text = "";
        }

        

        private void dataGridViewFOOD_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            /*foodidTXT.Text = dataGridViewFOOD.SelectedRows[0].Cells[0].Value.ToString();
            foodnameTXT.Text = dataGridViewFOOD.SelectedRows[0].Cells[1].Value.ToString();
            foodpriceTXT.Text = dataGridViewFOOD.SelectedRows[0].Cells[2].Value.ToString();*/
        }

        private void dataGridViewDRINK_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           /* drinkidTXT.Text = dataGridViewDRINK.SelectedRows[0].Cells[0].Value.ToString();
            drinknameTXT.Text = dataGridViewDRINK.SelectedRows[0].Cells[1].Value.ToString();
            drinkpriceTXT.Text = dataGridViewDRINK.SelectedRows[0].Cells[2].Value.ToString();*/
        }

        private void shoplabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFOOD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
