using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiSinhVien.Model;
using Newtonsoft.Json;
using System.IO;

namespace QuanLiSinhVien.Services
{
    public class JoinListStudentServices
    {
        List<ClassModel> classList;
        List<StudentModel> studentList;
        ClassModel selectedClass;
        public JoinListStudentServices(ClassModel currentClass)
        {
            classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            selectedClass = currentClass;
        }

        public List<JoinListStudentModel> joinListStudent()
        {
            var query = selectedClass.StudentId.Select(x => x).Join(studentList,

                ID => ID,
                studentList => studentList.Id,
                (ID, studentList) => new JoinListStudentModel
                {
                    Id = ID,
                    Name = studentList.Name,
                    ClassName = selectedClass.ClassName,
                    
                }
                
                ).ToList();
            return query;
        }

        
    }
}
