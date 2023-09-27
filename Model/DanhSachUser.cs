using System;
using System.Collections.Generic;
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

        List<Username> listTK;

        public List<Username> ListTK
        { get; set; }

        DanhSachUser()
        {
            listTK = new List<Username>();
            listTK.Add(new Username("TruongKhoa", "truongkhoa123", 1));
            listTK.Add(new Username("GVChuNhiem", "CN123456", 2));
            listTK.Add(new Username("GVBoMon", "BM123456", 3));
            listTK.Add(new Username("LopTruong", "LT123456", 4));
        }
    }
}