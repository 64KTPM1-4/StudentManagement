using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLiSinhVien.Services
{
    public class ClassServices
    {
        
        public IEnumerable<ClassModel> ClassSearch(string keyword = null)
        {
            var classList = JsonConvert.DeserializeObject<IEnumerable<ClassModel>>("Class.json");
            return classList;
        }

        public void AddClass(string ClassName)
        {
            int sum = 0;

            foreach (char c in ClassName)
            {
                if (char.IsDigit(c))
                {
                    int digit = (int)Char.GetNumericValue(c);
                    sum += digit;
                }
                else
                {
                    int asciiValue = (int)c;
                    sum += asciiValue;
                }
               
            }

            int ClassId = sum % 10;
            List<ClassModel> newClass = new List<ClassModel>();
            newClass.Add(new ClassModel
            {
                ClassId = ClassId,
                ClassName = ClassName,
            });

            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(newClass));

        }

    }
}
