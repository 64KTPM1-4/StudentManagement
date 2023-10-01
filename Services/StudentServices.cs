using System;
using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace QuanLiSinhVien.Services
{
    public class StudentSevices
    {
        public List<StudentModel> StudentSearch()
        {
            var studentList = new List<StudentModel>() { };
            try
            {
                string json = File.ReadAllText(@"students.json");
                studentList = JsonConvert.DeserializeObject<List<StudentModel>>(json);
            }
            catch(FileNotFoundException)
            {
                File.WriteAllText(@"students.json", "[]");
            }
            return studentList;
        }


        public void AddStudent(string StudentName)
        {
            int StudentId = 0;
            var studentList = StudentSearch();
            int index = studentList.Count() - 1;
            
            if(index >= 0) 
            {
                StudentId = studentList[index].Id + 1;
            }
            List<StudentModel> newStudent = new List<StudentModel>();
            newStudent.Add(new StudentModel
            {
                Id = StudentId,
                Name = StudentName,
            });

            studentList.AddRange(newStudent);
            File.WriteAllText(@"students.json", JsonConvert.SerializeObject(studentList));
        }

        public void DeleteStudent(string StudentName)
        {
            var studentList = StudentSearch();
            var Name = studentList.FirstOrDefault(s => s.Name.Equals(StudentName, StringComparison.OrdinalIgnoreCase));
            var index = studentList.FindIndex(x => x.Name == Name);
            studentList.RemoveAt(index);
            File.WriteAllText(@"students.json", JsonSerializer.Serialize(studentList));
        }


        public void EditStudent(string oldStudentName, string newStudentName)
        {
            var studentList = StudentSearch();
            var student = studentList.FirstOrDefault(s => s.Name.Equals(oldStudentName, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                student.Name = newStudentName;
                File.WriteAllText(@"students.json", JsonSerializer.Serialize(studentList));
            }
        }

        public void AddPointsStudent(string studentName, int pointsToAdd)
        {
            var studentList = StudentSearch();
            var student = studentList.FirstOrDefault(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                student.points += pointsToAdd;
                File.WriteAllText(@"students.json", JsonSerializer.Serialize(studentList));
            }
        }

        public void AddNotesStudent(string studentName, string note)
        {
            var studentList = StudentSearch();
            var student = studentList.FirstOrDefault(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                student.notes += Environment.NewLine + note;
                File.WriteAllText(@"students.json", JsonSerializer.Serialize(studentList));
            }
        }
    }
}
