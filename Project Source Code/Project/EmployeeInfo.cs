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
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }
                

        private void btSave_Click(object sender, EventArgs e)
        {

            if (nidTxt.Text != "" && firstNameTxt.Text!="" && lastNameTxt.Text!="" && phoneNumberTxt.Text!="" && ageTxt.Text!="" && addressTxt.Text!="" &&  joindateTxt.Text!="" && imageBox.Image!=null)
            {              
                try
                {
                    byte[] images = null;
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);




                    string constring = "server=localhost;user id=root;database=mysqlcsharp; sslMode=none";

                    string Query = "INSERT INTO mysqlcsharp.employeeinfo (FirstName, LastName, PhoneNumber, NidNumber, Age, Address, JoinDate,Image) VALUES ('" + firstNameTxt.Text + "','" + lastNameTxt.Text + "', '" + phoneNumberTxt.Text + "', '" + nidTxt.Text + "', '" + ageTxt.Text + "', '" + addressTxt.Text + "','" + joindateTxt.Text + "',@images);";
                    MySqlConnection conDataBase = new MySqlConnection(constring);


                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    cmdDataBase.Parameters.Add(new MySqlParameter("@images", images));
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
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else MessageBox.Show("One or more fields left empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            imageBox.Image = null;

        }

        private void bk_to_mngmnt_Click(object sender, EventArgs e)
        {
            Form bk = new Management_Page();
            bk.Show();
            Hide()
 ;        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            phoneNumberTxt.Text = "";
            nidTxt.Text = "";
            ageTxt.Text = "";
            addressTxt.Text = "";
            joindateTxt.Text = "";
            imageBox.Image = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form dataview = new Data_View();
            dataview.Show();
            Hide();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    byte[] images = null;
            if (nidTxt.Text != "" && firstNameTxt.Text != "" && lastNameTxt.Text != "" && phoneNumberTxt.Text != "" && ageTxt.Text != "" && addressTxt.Text != "" && joindateTxt.Text != "" && imageBox.Image != null)
            {
                
                try
                {

                    if (imageBox.Image == null)
                    {
                        FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);

                        string constring = "server=localhost;user id=root;database=mysqlcsharp; sslMode=none";
                        string Query = "UPDATE mysqlcsharp.employeeinfo set FirstName='" + firstNameTxt.Text + "', LastName='" + lastNameTxt.Text + "', PhoneNumber='" + phoneNumberTxt.Text + "', Age='" + ageTxt.Text + "',  Address='" + addressTxt.Text + "', JoinDate='" + joindateTxt.Text + "', Image=@images where NidNumber='" + nidTxt.Text + "'  ";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                        cmdDataBase.Parameters.Add(new MySqlParameter("@images", images));

                        MySqlDataReader myReader;




                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }

                    if(imageBox.Image!=null)
                    {
                      //  byte[] image2 = null;
                        string constring3 = "server=localhost;user id=root;database=mysqlcsharp; sslMode=none";
                        MySqlConnection conDataBase3 = new MySqlConnection(constring3);
                        
                        conDataBase3.Open();
                        string query3 = "SELECT * FROM mysqlcsharp.employeeinfo where PhoneNumber="+phoneNumberTxt.Text;
                        MySqlCommand command3 = new MySqlCommand(query3, conDataBase3);
                        MySqlDataReader mdr3 = command3.ExecuteReader();
                        /* if (mdr3.Read())
                         {                          
                              image2 = (byte[])mdr3[7];
                         }*/
                        conDataBase3.Close();




                        MemoryStream ms = new MemoryStream();
                        imageBox.Image.Save(ms, imageBox.Image.RawFormat);
                        byte[] imgg = ms.ToArray();







                        string Query11 = "UPDATE mysqlcsharp.employeeinfo set FirstName='" + firstNameTxt.Text + "', LastName='" + lastNameTxt.Text + "', PhoneNumber='" + phoneNumberTxt.Text + "', Age='" + ageTxt.Text + "',  Address='" + addressTxt.Text + "', JoinDate='" + joindateTxt.Text + "', Image=@imgg where NidNumber='" + nidTxt.Text + "'  ";
                        MySqlConnection conDataBase4 = new MySqlConnection(constring3);
                        MySqlCommand cmdDataBase4 = new MySqlCommand(Query11, conDataBase4);

                        cmdDataBase4.Parameters.Add("@imgg", MySqlDbType.LongBlob).Value = imgg;
                        
                        //cmdDataBase4.Parameters.Add(new MySqlParameter("@imgg", imgg));

                        //MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MySqlDataReader myReader2;

                        conDataBase4.Open();
                        myReader2 = cmdDataBase4.ExecuteReader();
                        MessageBox.Show("Data Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        while (myReader2.Read())
                        {

                        }
                        conDataBase4.Close();
                                                
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("One or more fields left empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        string imgLocation = "";
      
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            dialogue.Filter = "PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if(dialogue.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialogue.FileName.ToString();
                imageBox.ImageLocation = imgLocation;
            }
        }

        private void retrieveBTN_Click(object sender, EventArgs e)
        {
            if (phoneNumberTxt.Text != "")
            {
                try {
                    
                    string constring2 = "server=localhost;user id=root;database=mysqlcsharp; sslMode=none";
                    MySqlConnection conDataBase2 = new MySqlConnection(constring2);


                    conDataBase2.Open();
                    string query2 = "SELECT * FROM mysqlcsharp.employeeinfo where PhoneNumber=" + phoneNumberTxt.Text;
                    MySqlCommand command2 = new MySqlCommand(query2, conDataBase2);
                    MySqlDataReader mdr2 = command2.ExecuteReader();
                    if (mdr2.Read())
                    {
                        firstNameTxt.Text = mdr2.GetString("FirstName");
                        lastNameTxt.Text = mdr2.GetString("LastName");
                        nidTxt.Text = mdr2.GetString("NidNumber");
                        ageTxt.Text = mdr2.GetString("Age");
                        addressTxt.Text = mdr2.GetString("Address");
                        joindateTxt.Text = mdr2.GetString("JoinDate");

                        byte[] img = (byte[])mdr2[7];
                        MemoryStream ms = new MemoryStream(img);
                        imageBox.Image = Image.FromStream(ms);

                    }
                    else MessageBox.Show("No data found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    conDataBase2.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else MessageBox.Show("Phone Number field is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
