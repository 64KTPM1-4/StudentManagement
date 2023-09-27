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
        { get; set; }

        public string MatKhau
        { get; set; }

        private int loaiTK;
        public int LoaiTK
        { get; set; }

        public Username(string tentaikhoan, string matkhau, int loaitk)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTK = loaitk;
        }
    }
}
