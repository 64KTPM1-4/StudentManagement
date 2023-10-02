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
        public List<TeacherModel> TeacherSearch(ClassModel selectedClass = null)
        {
            var teacherList = new List<TeacherModel>();
            try
            {
                string json = File.ReadAllText(@"Teacher.json");
                teacherList = JsonConvert.DeserializeObject<List<TeacherModel>>(json);
                if (selectedClass != null)
                {
                    teacherList = teacherList.Where(x => x.MainClassName == selectedClass.ClassName).ToList();
                }
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Teacher.json", "[]");
            }
            return teacherList;
        }

        public void AddTeacher(string TeacherName, string mainClassName)
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
                MainClassName = mainClassName
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
    }
}
