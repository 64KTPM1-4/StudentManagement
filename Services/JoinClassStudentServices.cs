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
    public class JoinClassStudentServices
    {
        List<StudentModel> studentList;
        List<ClassModel> classList;
        ClassModel currentClass;
        public JoinClassStudentServices(ClassModel selectedClass)
        {
            classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText("Class.json"));
            currentClass = classList.FirstOrDefault(x => x.ClassId == selectedClass.ClassId);
            studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText("Student.json"));
            studentList = studentList.Where(x => x.ClassId == selectedClass.ClassId).ToList();
        }

        public List<JoinStudentModel> JoinList()
        {

            var query = currentClass.StudentId.Join(studentList,
                
                            studentList => studentList,
                            student => student.Id,
                            (studentList, student) => new JoinStudentModel
                            {
                                Id = student.Id,
                                StudentName = student.Name,
                            }
                
                        ).ToList();
            return query;
        }

    }
}
