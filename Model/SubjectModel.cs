using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class SubjectModel
    {
        [DisplayName("ID")]
        public int? SubjectId { get; set; } = 0;
        [DisplayName("Tên môn học")]
        public string SubjectName { get; set; } = string.Empty;
        public List<StudentModel> students { get; set; } = new List<StudentModel>();
        

    }
}
