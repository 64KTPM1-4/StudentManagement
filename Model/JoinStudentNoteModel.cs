using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class JoinStudentNoteModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Tên sinh viên")]
        public string Name { get; set; }
        [DisplayName("Điểm quá trình")]
        public double dqt {  get; set; }
        [DisplayName("Điểm thi")]
        public double dt { get; set;}
        [DisplayName("Điểm tổng kết")]
        public double dtk { get; set;}
        [DisplayName("Vi phạm")]
        public string Note { get; set; }
    }
}
