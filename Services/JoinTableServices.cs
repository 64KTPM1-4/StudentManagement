using System.Collections.Generic;
using System.Linq;
using QuanLiSinhVien.Model;
using Newtonsoft.Json;
using System.IO;
namespace QuanLiSinhVien.Services
{
    public class JoinTableServices
    {
       
        public static List<JoinClassSubjectModel> JoinClassSubject(ClassModel selectedClass) 
        {
            var classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json"));
            var currentClass = classList.FirstOrDefault(x => x.ClassId == selectedClass.ClassId);
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            var query = currentClass.SubjectId.Select(x => x).Join(subjectList,
                                                    ID => ID,
                                                    list => list.SubjectId,
                                                    (ID, list) => new JoinClassSubjectModel
                                                    {

                                                        SubjectId = ID,
                                                        SubjectName = list.SubjectName,
                                                    }
                                                    ).ToList();
            return query;
        }

        
    }
}
