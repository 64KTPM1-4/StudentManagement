using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiSinhVien
    .EntityFrameworkCore.DataAccess
{
    public class User
    {
        private string Users;
        private string Pass;

        public string Username
        {
            get => Users;
            set => Users = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }

        private bool loaiTK;
        public string LoaiTK
        {
            get => loaiTK;
            set => loaiTK = value;
        }

        public User(string username, string password, int loaitk) 
        {
            this.Username = username;
            this.Password = password;
            this.LoaiTK = loaitk;
        }
    }
}

