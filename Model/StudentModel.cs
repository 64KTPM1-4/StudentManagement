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
        public int ClassId { get; set; } = -5;

    }
}
