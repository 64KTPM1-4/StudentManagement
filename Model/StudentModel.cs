using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class StudentModel
    {
        [DisplayName("ID")]
        public int Id { get; set; } = 0;
        [DisplayName("Tên sinh viên")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Lớp quản lí")]
        public string MainClassName {  get; set; }

        public List<string> Notes { get; set; } = new List<string>();

        public List<float> Point { get; set; } = new List<float>();
    }
}
