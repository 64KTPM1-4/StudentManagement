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
            Class_Form frm = new Class_Form();
            this.Hide();
            frm.ShowDialog();
          
        }
    }
}
