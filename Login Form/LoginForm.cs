using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using QuanLiSinhVien.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien.Login_Form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Username_MouseHover(object sender, EventArgs e)
        {
            if(Username.Text == "Tên đăng nhập")
            Username.Text = string.Empty;
        }

        private void Password_MouseHover(object sender, EventArgs e)
        {
            if(Password.Text == "Mật khẩu")
            Password.Text = string.Empty;
        }

        private void Username_MouseLeave(object sender, EventArgs e)
        {
            if (Username.Text == string.Empty)
                Username.Text = "Tên đăng nhập";
        }

        private void Password_MouseLeave(object sender, EventArgs e)
        {
            if (Password.Text == string.Empty)
            Password.Text = "Mật khẩu";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            LoginServices login = new LoginServices();
            var currentAccount = login.isAccountValid(Username.Text, Password.Text);
            ClassServices classServices = new ClassServices();
            var classList = classServices.ClassSearch();
            try
            {
                if (currentAccount.roles == "chuyenvien")
                {
                    Class_Form class_Form = new Class_Form();
                    this.Hide();
                    class_Form.ShowDialog();
                    this.Show();
                }
                else if(currentAccount.roles == "loptruong")
                {
                    
                    var currentClass = classList.FirstOrDefault(x => x.ClassId == currentAccount.ClassId);
                    StudentOfClass studentOfClass = new StudentOfClass(currentClass, currentAccount.roles);
                    this.Hide();
                    studentOfClass.HideButton();
                    studentOfClass.ShowDialog();
                    this.Show();
                    
                }
                else if(currentAccount.roles == "GVCN")
                {
                    var currentClass = classList.FirstOrDefault(x => x.ClassId == currentAccount.ClassId);
                    StudentOfClass studentOfClass = new StudentOfClass(currentClass);
                    this.Hide();
                    studentOfClass.HideMainTeacherButton();
                    studentOfClass.ShowDialog();
                    this.Show();
                }
                else if(currentAccount.roles == "GVBM")
                {
                    ClassList classlist = new ClassList(currentAccount.SubjectId);
                    this.Hide();
                    classlist.ShowDialog();
                    this.Show();
                    
                }
                Username.Text = "Tên đăng nhập";
                Password.Text = "Mật khẩu";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
            
                
            
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            LoginButton_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
