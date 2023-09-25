using QuanLiSinhVien.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien.Login
{
    public partial class SignUpForm : Form
    {
        private StudentEntities student;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if (Username.Text.Length > 0) usernameLabel.Hide();
            else usernameLabel.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text.Length > 0) passwordLabel.Hide();
            else passwordLabel.Show();
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text.Length > 0) CpasswordLabel.Hide();
            else CpasswordLabel.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            student = new StudentEntities();
            var Query = student.LoginInfor.FirstOrDefault(model => model.Username == Username.Text);
            if (Query != null) MessageBox.Show("Tài khoản đã tồn tại !");
            else if (Password.Text != ConfirmPassword.Text) MessageBox.Show("Mật khẩu không trùng khớp !");
            else
            {

            }

        }

        private void usernameLabel_Mouse(object sender, EventArgs e)
        {
            usernameLabel.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
