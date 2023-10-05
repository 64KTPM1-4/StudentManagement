using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int ClassId { get; set; }
        [DisplayName("Điểm số")]
        public float Diem { get; set; }
    }
}
