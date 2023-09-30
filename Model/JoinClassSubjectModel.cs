using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class JoinClassSubjectModel
    {
        [DisplayName("ID")]
        public int SubjectId { get; set; }
        [DisplayName("Tên môn học")]
        public string SubjectName { get; set; }
    }
}
