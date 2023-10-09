using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class AccountModel
    {

        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string roles { get; set; } = string.Empty;
        public int ClassId { get; set; } = -5;
        public int SubjectId { get; set; } = -5;
    }
}
