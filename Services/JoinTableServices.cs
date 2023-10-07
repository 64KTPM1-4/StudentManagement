using System.Collections.Generic;
using System.Linq;
using QuanLiSinhVien.Model;
using Newtonsoft.Json;
using System.IO;
namespace QuanLiSinhVien.Services
{
    public class JoinTableServices
    {
        List<ClassModel> classList;
        ClassModel currentClass;
       public JoinTableServices(ClassModel selectedClass)
       {
            classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            currentClass = classList.FirstOrDefault(x => x.ClassId == selectedClass.ClassId);
       }
        public List<JoinClassSubjectModel> JoinClassSubject() 
        {            
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            var query = currentClass.SubjectId.Select(x => x).Join(subjectList,
                                                    ID => ID,
                                                    list => list.SubjectId,
                                                    (ID, list) => new JoinClassSubjectModel
                                                    {

                                                        SubjectId = ID,
                                                        SubjectName = list.SubjectName
                                                    }
                                                    ).ToList();
            return query;
        }

        public void DeleteClassSubject(string SubjectName)
        {
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            var subjectId = subjectList.Where(x => x.SubjectName == SubjectName).Select(x => x.SubjectId).FirstOrDefault();
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            var index = classList.FindIndex(x => x.ClassId == currentClass.ClassId);
            classList[index].SubjectId.Remove(subjectId);
            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
        }

        public List<JoinStudentModel> JoinClassStudents()
        {
            var studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            var query = currentClass.StudentId.Select(x => x).Join(studentList,
                                               ID => ID,
                                               list => list.Id,
                                               (ID, list) => new JoinStudentModel
                                               {
                                                   Id = ID,
                                                   StudentName = list.Name
                                               }
                                               ).ToList();
            return query;
        }



    }
}
