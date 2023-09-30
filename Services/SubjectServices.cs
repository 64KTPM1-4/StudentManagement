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

        public void AddSubject(string SubjectName)
        {


            int SubjectId = 0;
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
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
        }

        
    }
}
