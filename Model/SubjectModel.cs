using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class SubjectModel
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int points { get; set; }
        public string notes {  get; set; }
        IEnumerable<StudentModel> students { get; set; }
        

    }
}
