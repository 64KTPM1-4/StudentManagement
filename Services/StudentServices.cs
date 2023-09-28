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
        List<StudentModel> students;

        public StudentSevices() 
        {
            LoadStudents();
        }

        public IEnumerable<StudentModel> GetAllStudents() 
        {
            return students;
        }

        public StudentModel GetStudentById(int studentId)
        {
            return students.FirstOrDefault(student => student.Id == studentId);
        }

        public void AddStudent(StudentModel student)
        {
            student.Id = students.Count > 0 ? students.Max(s => s.Id) + 1 : 1;  
            students.Add(student);
            SaveStudents();
        }

        public void RemoveStudent(int studentId) 
        {
            StudentModel studentRemove = students.FirstOrDefault(s => s.Id == studentId);

            if(studentRemove != null) 
            {
                students.Remove(studentRemove);
                SaveStudents();
            }
        }

        private void LoadStudents()
        {
            string json = File.ReadAllText(@"students.json");
            if(!string.IsNullOrEmpty(json)) 
            {
                students = JsonConvert.DeserializeObject<List<StudentModel>>(json);
            }
            else
            {
                students = new List<StudentModel>();
            }
        }

        private void SaveStudents()
        {
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(@"students.json", json);
        }
    }
}
