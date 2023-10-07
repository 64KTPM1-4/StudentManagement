using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class NotesModel
    {
        [DisplayName("Vi phạm")]
        public string Notes { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int ClassId {  get; set; }
        [DisplayName("Điểm quá trình")]
        public double dqt { get; set; } = 0;
        [DisplayName("Điểm thi")]
        public double dt { get; set; } = 0;
        [DisplayName("Điểm tổng kết")]
        public double dtk { get; set; } = 0;
    }
}
