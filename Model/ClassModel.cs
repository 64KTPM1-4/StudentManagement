using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class ClassModel
    {
        public int? ClassId { get; set; }
        public string ClassName { get; set; }
        public List<SubjectModel> Subjects { get; set; } = new List<SubjectModel>();
        

    }
}
