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
    public class TeacherServices
    {
        public List<TeacherModel> TeacherSearch()
        {
            var teacherList = new List<TeacherModel>();
            try
            {
                string json = File.ReadAllText(@"Teacher.json");
                teacherList = JsonConvert.DeserializeObject<List<TeacherModel>>(json);
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Teacher.json", "[]");
            }
            return teacherList.OrderBy(x => x.TeacherId).ToList();
        }

        public void AddTeacher(string TeacherName)
        {
            int TeacherId = 0;
            var teacherList = TeacherSearch();
            int index = teacherList.Count() - 1;

            if (index >= 0) 
            {
                TeacherId = teacherList[index].TeacherId + 1;
            }
            List<TeacherModel> newTeacher = new List<TeacherModel>();

            newTeacher.Add(new TeacherModel
            {
                TeacherId = TeacherId,
                TeacherName = TeacherName,

            });

            teacherList.AddRange(newTeacher);
            File.WriteAllText(@"Teacher.json", JsonConvert.SerializeObject(teacherList));
        }

        public void DeleteTeacher(string TeacherName)
        {
            var teacherList = TeacherSearch();
            var index = teacherList.FindIndex(x => x.TeacherName == TeacherName);
            teacherList.RemoveAt(index);
            File.WriteAllText(@"Teacher.json", JsonConvert.SerializeObject(teacherList));
        }

        public void EditTeacher(string oldTeacherName, string newTeacherName)
        {
            var teacherList = TeacherSearch();
            var teacher = teacherList.FirstOrDefault(x => x.TeacherName.Equals(oldTeacherName, StringComparison.OrdinalIgnoreCase));

            if(teacher != null)
            {
                teacher.TeacherName = newTeacherName;
                File.WriteAllText(@"Teacher.json", JsonConvert.SerializeObject((teacher)));
            }
        }

        public string MainTeacher(ClassModel selectedClass)
        {

            var teacherList = TeacherSearch();
            var currentTeacher = teacherList.FirstOrDefault(x => x.TeacherId == selectedClass.TeacherId);
            try
            {
                return currentTeacher.TeacherName;
            }
            catch(NullReferenceException)
            {
                return "Chưa có";
            }
        }

    }
}
