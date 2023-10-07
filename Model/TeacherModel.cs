using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class TeacherModel
    {
        [DisplayName("ID")]
        public int TeacherId { get; set; } = 0;
        [DisplayName("Tên giáo viên")]
        public string TeacherName { get; set; } = string.Empty;
    }
}
