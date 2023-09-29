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
        public int? Id { get; set; } = 0;
        [DisplayName("Tên sinh viên")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Điểm")]
        public int? points { get; set; } = 0;
        [DisplayName("Vi phạm")]
        public string notes { get; set; } = string.Empty;


    }
}
