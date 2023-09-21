using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            this.Hide();
            Class_Form class_Form = new Class_Form();
            class_Form.ShowDialog();
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void usernameLabel_MouseHover(object sender, EventArgs e)
        {
            usernameLabel.Hide();
        }

        private void passwordLabel_MouseHover(object sender, EventArgs e)
        {
            passwordLabel.Hide();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            usernameLabel.Hide();

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            passwordLabel.Hide();
        }
    }
}
