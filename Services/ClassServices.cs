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
            try
            {
                classList = JsonSerializer.Deserialize<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Class.json", "[]");
            }
            return classList;
        }

        public void AddClass(string ClassName)
        {
            



            int ClassId = 0;
            var classList = JsonSerializer.Deserialize<List<ClassModel>>(File.ReadAllText(@"Class.json"));

            int index = classList.Count() - 1;
            if (index >= 0)
            {
                ClassId = classList[index].ClassId + 1;
            }
            

            List<ClassModel> newClass = new List<ClassModel>();
            newClass.Add(new ClassModel
            {
                ClassId = ClassId,
                ClassName = ClassName,
                SubjectId = new List<int>()

            });

            classList.AddRange(newClass);
            File.WriteAllText(@"Class.json", JsonSerializer.Serialize(classList));

        }
        public void AddClassSubject(ClassModel currentClass, int SubjectId)
        {
            
            var classList = ClassSearch();
            int index = classList.FindIndex(x => x.ClassId == currentClass.ClassId);
           
            classList[index].SubjectId.Add(SubjectId);
            
            
            File.WriteAllText(@"Class.json", JsonSerializer.Serialize(classList));

        }

    }
}
