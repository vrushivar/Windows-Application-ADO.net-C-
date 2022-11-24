using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WA_Vrushivar
{   
    public partial class LoginPage : Form
    {
        // object of sqldata_adapter 
        SqlDataAdapter sqlAdp = new SqlDataAdapter();       
        // connection string
        public static string ConnectionString = "Data Source=DESKTOP-91DCBNS;Initial Catalog=OnlineFarm;Integrated Security=True";

        public LoginPage()
        {
            InitializeComponent();
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
          
        }
       
        public void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            //this.Hide();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        {
            
            string str2=textBox2.Text;

            if(textBox1.Text == "" || textBox2.Text =="")
            {              
               
                MessageBox.Show("Please Fill All Entries", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                //connection string
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select * from UserDetails where 
                                        Username like @username and Password like @password;";
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);                  
                   try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            ClassLibrary.loginuserid = dr.GetInt32(0);
                            ClassLibrary.Loginusername = dr.GetString(4);
                            ClassLibrary.loginpassword = dr.GetInt32(0);
                            MessageBox.Show("Login Successfull");

                            //set loginId publicaly for further use
                            
                            //make HOME PAGE visible.
                            Home_Page home_Page =new Home_Page();
                            home_Page.Show();
                            this.Hide();
                        }
                        else
                        {
                            //MessageBox.Show("Username not found");
                            MessageBox.Show("Invalid Username/ID and Password....../n If you are new user please register yourself", "Error", MessageBoxButtons.OKCancel);
                        }
                        dr.Close();
                        conn.Close();
                        SqlConnection conn2 = new SqlConnection(ConnectionString);
                        conn2.Open();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = conn2;
                        cmd2.CommandText = @"update UserDetails set Status='Active' where Username like @Username ;";
                        cmd2.Parameters.AddWithValue("@Username", textBox1.Text);                       
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }

                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelAdminPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Page admin_Page = new Admin_Page();
            admin_Page.Show();          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Link label going to Staff login Page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Worker_Staff_Page worker_Staff_Page = new Worker_Staff_Page();
            worker_Staff_Page.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
