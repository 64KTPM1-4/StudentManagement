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
    public class SubjectServices
    {

        List<SubjectModel> subjects;
        ClassModel currentClass;
        List<ClassModel> ClassList;
        public SubjectServices(List<ClassModel> Class, ClassModel selectedClass) 
        {
            currentClass = selectedClass;
            ClassList = Class;
            subjects = new List<SubjectModel>();
        }

        public List<SubjectModel> SubjectsSearch() 
        {
            
            return currentClass.Subjects;
        }

        public SubjectModel GetSubjectsById(int? subjectId)
        {
            return subjects.FirstOrDefault(subject => subject.SubjectId == subjectId);
        }
        SubjectModel subject;
        public void AddedSubject(string subjectName) 
        {
            int sum = 0;
            foreach (char c in subjectName)
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

            subject = new SubjectModel();
            subject.SubjectId = sum;
            subject.SubjectName = subjectName;
            subjects.Add(subject);
            currentClass.Subjects.Add(subject);
            int index = ClassList.FindIndex(s => s == currentClass);
            ClassList[index] = currentClass;
            SaveSubjects();
        }

        public void RemoveSubject(int? subjectId)
        {
            SubjectModel subjectRemove = subjects.FirstOrDefault(subject => subject.SubjectId == subjectId);

            if (subjectRemove != null) 
            {
                subjects.Remove(subjectRemove);
                SaveSubjects();
            }
        }



        private void SaveSubjects()
        {
           var json = JsonConvert.SerializeObject(ClassList, Formatting.Indented);
            File.WriteAllText(@"Class.json", json);
        }
    }
}
