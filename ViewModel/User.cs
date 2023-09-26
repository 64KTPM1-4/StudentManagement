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

{
    public class Username
    {
        private string tenTaiKhoan;
        private string matKhau;

        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        private bool loaiTK;
        public bool LoaiTK
        {
            get => loaiTK;
            set => loaiTK = value;
        }

        public Username(string tentaikhoan, string matkhau, int loaitk) 
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTK = loaitk;
        }
    }
}

