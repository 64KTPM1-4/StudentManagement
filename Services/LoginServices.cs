using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace QuanLiSinhVien.Services
{
    public class LoginServices
    {
        List<AccountModel> accounts;
        public AccountModel isAccountValid(string Username, string Password)
        {
            
            accounts = JsonConvert.DeserializeObject<List<AccountModel>>(File.ReadAllText(@"Account.json"));
            var currentAccount = accounts.FirstOrDefault(x => x.username == Username && x.password == Password);
            return currentAccount;
            
        }
    }
}
