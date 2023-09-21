using QuanLiSinhVien.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Login_Form : QuanLiSinhVien.Class.AddClass
    {
        SignUpForm signUpForm = new SignUpForm();
        Class_Form frm = new Class_Form();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if(Username.Text.Length > 0) label1.Hide();
            else label1.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text.Length > 0) label2.Hide();
            else label2.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frm.ShowDialog();
            this.Show();
          
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
                
            }
        }
    }
}
