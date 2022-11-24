using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Vrushivar
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        
        private void linklblShop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Hide();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void linklblUserDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaySafe paySafe = new PaySafe();    
            paySafe.Show();
            this.Hide();
        }

        private void linklblOrderDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Order_Details_Page order = new Order_Details_Page();    
            order.Show();
        }

        private void btn_UserDetails_Click(object sender, EventArgs e)
        {
        }
    }
}
