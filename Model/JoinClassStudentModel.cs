using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class JoinClassStudentModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Tên sinh viên")]
        public string StudentName { get; set; }
    }
}
