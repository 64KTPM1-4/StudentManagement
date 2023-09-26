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
    public class DanhSachUser
    {
        private static DanhSachUser instance;
        public static DanhSachUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DanhSachUser();
                }
                return instance; 
            }
            set => instance = value;
        }

        List<string> listTK;

        public List<string> ListTK
        {
            get => listTK; 
            set => listTK = value;
        }

        DanhSachUser() 
        {
            listTK = new List<string>();
            listTK.Add(new Username("TruongKhoa", "truongkhoa123", "1"));
            listTK.Add(new Username("GVChuNhiem", "CN123456", "2"));
            listTK.Add(new Username("GVBoMon", "BM123456", "3"));
            listTK.Add(new Username("LopTruong", "LT123456", "4"));
            listTK.Add(new Username("FIXer", "test123", "5"));
        }
    }
}