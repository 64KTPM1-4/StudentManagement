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

        public SubjectServices() 
        {
            LoadSubjects();
        }

        public IEnumerable<SubjectModel> GetAllSubjects() 
        {
            return subjects;
        }

        public SubjectModel GetSubjectsById(int? subjectId)
        {
            return subjects.FirstOrDefault(subject => subject.SubjectId == subjectId);
        }

        public void AddedSubject(SubjectModel subject) 
        {
            subject.SubjectId = subjects.Count > 0 ? subjects.Max(s => s.SubjectId ?? 0) + 1 : 1;
            subjects.Add(subject);
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

        private void LoadSubjects()
        {
            string json = File.ReadAllText(@"Class.json");

            if(!string.IsNullOrEmpty(json)) 
            {
                subjects = JsonConvert.DeserializeObject<List<SubjectModel>>(json);
            }
            else
            {
                subjects = new List<SubjectModel>();
            }
        }

        private void SaveSubjects()
        {
            string json = JsonConvert.SerializeObject(subjects, Formatting.Indented);
            File.WriteAllText(@"subjects.json", json);
        }
    }
}
