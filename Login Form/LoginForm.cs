using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using QuanLiSinhVien.Database;
using System.Data.Entity.Infrastructure;

namespace QuanLiSinhVien.Login
{
    public partial class LoginForm : QuanLiSinhVien.ClassList
    {
        private StudentEntities student;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            student = new StudentEntities();

            var Query = student.LoginInfor.FirstOrDefault(model => model.Username == Username.Text && 
                                                          model.Password == Password.Text);

            if (Query != null)
            {

                this.Hide();
                Class_Form class_Form = new Class_Form();
                class_Form.ShowDialog();
                this.Show();

            }

            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");

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
