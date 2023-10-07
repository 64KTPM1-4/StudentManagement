using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class ClassModel
    {
        [DisplayName("ID")]
        public int ClassId { get; set; }
        [DisplayName("Tên lớp")]
        public string ClassName { get; set; }
        public List<int> SubjectId { get; set; } = new List<int>();
        public List<int> StudentId { get; set; } = new List<int>();
        public int MainTeacherId { get; set; } = -5;

    }
}
