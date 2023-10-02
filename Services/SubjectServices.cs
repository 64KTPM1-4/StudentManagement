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

        public List<SubjectModel> SubjectSearch()
        {
            var subjectList = new List<SubjectModel> { };
            try
            {
                string json = File.ReadAllText(@"Subject.json");
                subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(json);
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Subject.json", "[]");
            }
            return subjectList;
        }

        public bool AddSubject(string SubjectName)
        {

            int SubjectId = 0;
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            var valid = subjectList.FirstOrDefault(x => x.SubjectName == SubjectName);
            if (valid == null)
            {
                int index = subjectList.Count() - 1;
                if (index >= 0)
                {
                    SubjectId = subjectList[index].SubjectId + 1;
                }
                List<SubjectModel> newSubject = new List<SubjectModel>();
                newSubject.Add(new SubjectModel
                {
                    SubjectId = SubjectId,
                    SubjectName = SubjectName,

                });

                subjectList.AddRange(newSubject);
                File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
                return true;
            }
            else return false;
        }

        public void DeleteSubject(string subjectName)
        {
            var subjectList = SubjectSearch();
            var index = subjectList.FindIndex(x => x.SubjectName == subjectName);
            subjectList.RemoveAt(index);
            File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
        }

        public bool AddSubjectStudent(SubjectModel currentSubject, int StudentId)
        {

            var subjectList = SubjectSearch();
            int index = subjectList.FindIndex(x => x.SubjectId == currentSubject.SubjectId);
            var valid = subjectList[index].studentId.FindIndex(x => x == StudentId);

            if (valid == -1)
            {
                subjectList[index].studentId.Add(StudentId);
                File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
                return true;
            }
            else return false;

        }

    }
}
