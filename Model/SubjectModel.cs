using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class SubjectModel
    {

        public int? SubjectId { get; set; } = 0;
        public string SubjectName { get; set; } = string.Empty;
        public int? points { get; set; } = 0;
        public string notes { get; set; } = string.Empty;
        public List<StudentModel> students { get; set; } = new List<StudentModel>();
        

    }
}
