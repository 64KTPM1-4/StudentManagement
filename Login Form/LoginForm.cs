using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.IO;


namespace QuanLiSinhVien.Login
{
    public partial class LoginForm : QuanLiSinhVien.ClassList
    {
        List<AccountModel> accounts;
        
        
        public LoginForm()
        {
            accounts = new List<AccountModel>();
            accounts.Add(new AccountModel()
            {
                username = "TruongKhoa",
                password = "truongkhoa123",
                roles = "Truong khoa"
            });
            accounts.Add(new AccountModel()
            {
                username = "GVCN",
                password = "gvcn123",
                roles = "GVCN"
            });

            accounts.Add(new AccountModel()
            {
                username = "GVBM",
                password = "gvbm123",
                roles = "GVBM"
            });

            accounts.Add(new AccountModel()
            {
                username = "Loptruong",
                password = "loptruong123",
                roles = "Lop truong"
            });

            string record = JsonConvert.SerializeObject(accounts);
            File.WriteAllText(@"Account.json", record);
            

            InitializeComponent();

        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {

            var LoginCheck = JsonConvert.DeserializeObject<List<AccountModel>>(File.ReadAllText(@"Account.json"));
            bool valid = false;
            foreach (AccountModel account in LoginCheck)
            {
                if (account.username == Username.Text && account.password == Password.Text)
                {
                    valid = true; 
                    break;
                }
                 
            
            }

            if (valid)
            {
                Class_Form class_Form = new Class_Form();
                this.Hide();
                class_Form.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
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

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            return true;
        }
    }
}
