using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class 
        Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (usernametxt.Text.CompareTo("Admin") == 0 && passwordtxt.Text.CompareTo("p") == 0)
            {
                StaffListView stafflstview = new StaffListView();
                stafflstview.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user or password");
            }
        }
    }
}
