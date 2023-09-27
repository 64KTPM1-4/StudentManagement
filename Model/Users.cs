using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        { get; set; }

        private string matKhau;

        public string MatKhau
        { get; set; }

        TaiKhoan(string tentaikhoan, string matkhau) 
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
        }
    }