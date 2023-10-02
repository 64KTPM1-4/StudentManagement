using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using QuanLiSinhVien.Model;
namespace QuanLiSinhVien.Services
{
    public class JoinSubjectStudent
    {
        List<SubjectModel> subjectList;
        SubjectModel currentSubject;
        public JoinSubjectStudent(string SubjectName)
        {
            subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            currentSubject = subjectList.FirstOrDefault(x => x.SubjectName == SubjectName);
        }

        public List<JoinSubjectStudentModel> Join()
        {
            var studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            var query = currentSubject.studentId.Select(x => x).Join(studentList,
                
                    subject => subject,
                    student => student.Id,
                    (subject, student) => new JoinSubjectStudentModel
                    {
                        Id = subject,
                        Name = student.Name,
                    }

                ).ToList();
            return query;
        }

        public void DeleteSubjectStudent(string studentName)
        {
            var studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            var studentId = studentList.Where(x => x.Name == studentName).Select(x => x.Id).FirstOrDefault();
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            var index = subjectList.FindIndex(x => x.SubjectId == currentSubject.SubjectId);
            subjectList[index].studentId.Remove(studentId);
            File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
        }

    }
}
