using QuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuanLiSinhVien.Services
{
    public class ClassServices
    {
        
        public List<ClassModel> ClassSearch()
        {
            var classList = new List<ClassModel> { };
            try
            {
                classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Class.json", "[]");
            }
            return classList;
        }

        public bool AddClass(string ClassName)
        {
            
            int ClassId = 0;
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            var valid = classList.FirstOrDefault(x => x.ClassName == ClassName);
            if(valid == null)
            {
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
                    SubjectId = new List<int>(),
                    StudentId = new List<int>()

                });

                classList.AddRange(newClass);
                File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
                return true;
            }
            else return false;

            

        }
        public bool AddClassSubject(ClassModel currentClass, int SubjectId)
        {
            
            var classList = ClassSearch();
            
            int index = classList.FindIndex(x => x.ClassId == currentClass.ClassId);
            var valid = classList[index].SubjectId.FindIndex(x => x == SubjectId);

            if (valid == -1)
            {
                var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
                classList[index].SubjectId.Add(SubjectId);
                File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
                File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
                return true;
            }
            else return false;

        }

        public string AddClassStudent(ClassModel currentClass, int StudentId)
        {
            var classList = ClassSearch();
            var valid = currentClass.StudentId.FindIndex(x => x == StudentId);
            var studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText("Student.json"));
            var currentStudent = studentList.FirstOrDefault(x => x.Id == StudentId);
            

            if (valid == -1)
            {
                if (currentStudent.ClassId == -5)
                {
                    int index = classList.FindIndex(s => s.ClassId == currentClass.ClassId);
                    classList[index].StudentId.Add(StudentId);

                    currentStudent.ClassId = currentClass.ClassId;
                    int stIndex = studentList.FindIndex(s => s.Id == StudentId);
                    studentList[stIndex] = currentStudent;

                    File.WriteAllText(@"Student.json", JsonConvert.SerializeObject(studentList));
                    File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
                    return "";
                }
                else
                {
                    var exsistClass = classList.FirstOrDefault(x => x.ClassId == currentStudent.ClassId);
                    var ClassName = exsistClass.ClassName;
                    return ClassName;
                }
                
            }
            else return "In this class";
        }
            

        public void DeleteClass(string className)
        {
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            var index = classList.FindIndex(x => x.ClassName == className);
            classList.RemoveAt(index);
            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
        }

        public bool EditClassName(string currentClassName, string newClassName)
        {

            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            var valid = classList.FindIndex(x => x.ClassName == newClassName);
            if(valid == -1)
            {
                var index = classList.FindIndex(x => x.ClassName == currentClassName);
                classList[index].ClassName = newClassName;
                File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
                return true;
            }
            else return false;

        }

        public void DeleteStudentFromClass(ClassModel selectedClass, int selectedStudentId)
        {
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            selectedClass.StudentId.Remove(selectedStudentId);
            var index = classList.FindIndex(x => x.ClassId == selectedClass.ClassId);
            classList[index] = selectedClass;
            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));

            var studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            var stIndex = studentList.FindIndex(x => x.Id == selectedStudentId);
            studentList[stIndex].ClassId = -5;
            File.WriteAllText(@"Student.json", JsonConvert.SerializeObject(studentList));

        }

        public void AddMainTeacher(ClassModel selectedClass, int teacherId)
        {
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            selectedClass.MainTeacherId = teacherId;
            classList[classList.FindIndex(x => x.ClassId == selectedClass.ClassId)] = selectedClass;
            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
        }

        public void DeleteMainTeacher(ClassModel selectedClass)
        {
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            selectedClass.MainTeacherId = -5;
            classList[classList.FindIndex(x => x.ClassId == selectedClass.ClassId)] = selectedClass;
            File.WriteAllText(@"Class.json", JsonConvert.SerializeObject(classList));
        }

    }
}
