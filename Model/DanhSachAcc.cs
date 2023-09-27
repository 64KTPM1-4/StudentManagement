using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien.Model
{
    public class DanhSachAccount
    {
            
        var accounts = new List<AccountModel>
        {
            new AccountModel { username = "Chuyenvien", password = "chuyenvien123", roles = "Chuyen vien" },
            new AccountModel { username = "GiaovienChuNhiem", password = "GVCN123", roles = "GVCN" },
            new AccountModel { username = "GiaovienBoMon", password = "GVBM123", roles = "GVBM" },
            new AccountModel { username = "Loptruong", password = "loptruong123", roles = "Lop truong" }
        };

        string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
        File.WriteAllText("Account.json", json);

        InitializeComponent();

    }
}
