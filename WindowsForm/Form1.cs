using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
                txtUserName.Clear();
                txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin"&&txtPassword.Text=="admin")

            {
                MessageBox.Show("Login SuccessFully...");
                Form2 from2 = new Form2();
                //from2.Show();

                MdiForm mdiform = new MdiForm();
                mdiform.Show();
                this.Hide();// this refers to the login form2
            }

            else
            {
                MessageBox.Show("Login Failed...");
            }

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
