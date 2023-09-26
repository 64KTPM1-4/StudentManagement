using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

using System.Data.Entity.Infrastructure;

namespace QuanLiSinhVien.Login
{
    public partial class LoginForm : QuanLiSinhVien.ClassList
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if(Username.Text != "")
            usernameLabel.Hide();
            else usernameLabel.Show();

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if(Password.Text != "")
            passwordLabel.Hide();
            else passwordLabel.Show();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) LoginButton_Click(sender, e);
        }
    }
}
