using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Microsoft.SqlServer.Server;

namespace WA_Vrushivar
{
    public partial class Admin_Page : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-91DCBNS;Initial Catalog=OnlineFarm;Integrated Security=True";
        public static string AID;
        public static string UserType;
        public Admin_Page()
        {
            InitializeComponent();
        }

        /// self written............ 

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }
        // visibility section

        private void btnADLogin_Click(object sender, EventArgs e)
        {
 
            if (txtAdminID.Text == "" || txtAdminPin.Text == "")
            {
                MessageBox.Show("Please Fill All Entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //connection string
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select * from AdminDetails where 
                                        Ad_ID like @id and AD_PIN = @Pin;";
                    cmd.Parameters.AddWithValue("@id", txtAdminID.Text);
                    cmd.Parameters.AddWithValue("@Pin", txtAdminPin.Text);

                    try
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            //ClassLibrary.loginuserid = dr.GetInt32(0);
                            //ClassLibrary3.adminid= dr.GetString(4);
                            //ClassLibrary3.adminpassword = dr.GetInt32(0);
                            UserType = dr[5].ToString();
                            WA_Vrushivar.Admin_Page.AID = txtAdminID.Text;
                            MessageBox.Show("Admin Login Successfull");
                            //visibility of panel
                            flowLayoutPanel3.Visible = true;
                        }
                        else
                        {
                            //MessageBox.Show("Username not found");
                            MessageBox.Show("Invalid ID and PIN...Please Enter Correct ID and PIN../n", "Error", MessageBoxButtons.OKCancel);
                        }
                        dr.Close();
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
        // lables.....................
        private void lnklblAssignTask_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task_Page task_Page = new Task_Page();
            task_Page.Show();
        }

        private void lnklblTrackOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Track_Orders track_Orders = new Track_Orders();
            track_Orders.Show();
        }

        private void linkLabel_NewProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_New_Product add_New_Product = new Add_New_Product();
            add_New_Product.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {
            AID = txtAdminID.Text;
        }       
    }
}
