using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiSinhVien.Services
{
    public class ClassServices
    {
        
        public List<ClassModel> ClassSearch()
        {
            var classList = new List<ClassModel> { };
            classList = JsonSerializer.Deserialize<List<ClassModel>>(File.ReadAllText(@"Class.json"));
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
            var classList = new List<ClassModel>
            {
                
            };
            classList = JsonSerializer.Deserialize<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            List<ClassModel> newClass = new List<ClassModel>();
            newClass.Add(new ClassModel
            {
                ClassId = ClassId,
                ClassName = ClassName,
                Subjects = new List<SubjectModel> 
                { 
                    new SubjectModel() 
                    {
                        students = new List<StudentModel> 
                        { 
                            new StudentModel()
                            
                        }                     
                    } 
                }

            });

            classList.AddRange(newClass);
            File.WriteAllText(@"Class.json", JsonSerializer.Serialize(classList));

        }

    }
}
