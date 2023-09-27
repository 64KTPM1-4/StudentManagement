using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLiSinhVien.Services
{
    public class LoginServices
    {
        public bool isAccountValid(List<AccountModel> accounts, string Username, string Password)
        {
            bool valid = false;
            foreach (AccountModel account in accounts)
            {
                if (account.username == Username && account.password == Password)
                {
                    valid = true;
                    break;
                }

            }
            return valid;
        }
    }
}
