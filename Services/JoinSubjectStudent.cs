using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using QuanLiSinhVien.Model;
namespace QuanLiSinhVien.Services
{
    public class JoinSubjectStudent
    {
        List<SubjectModel> subjectList;
        SubjectModel currentSubject;
        List<NotesModel> noteList;
        List<StudentModel> studentList;
        public JoinSubjectStudent(ClassModel currentClass, SubjectModel currentSubject)
        {
           
            studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText(@"Student.json"));
            subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            try
            {
                noteList = JsonConvert.DeserializeObject<List<NotesModel>>(File.ReadAllText(@"Note.json"));
                noteList = noteList.Where(x => x.SubjectId == currentSubject.SubjectId && x.ClassId == currentClass.ClassId).ToList();
            }
            catch (FileNotFoundException)
            {
                noteList = new List<NotesModel>();
                File.WriteAllText(@"Note.json", "[]");
            }
            this.currentSubject = currentSubject;
        }

        public List<JoinStudentNoteModel> Join()
        {
            var query = studentList.Join(noteList,
                
                        student => student.Id,
                        note => note.StudentId,
                        (student, note) => new JoinStudentNoteModel
                        {
                            Id = student.Id,
                            Name = student.Name,
                            dqt = note.dqt,
                            dt = note.dt,
                            dtk = (note.dqt + note.dt) / 2,
                            Note = note.Notes,
                        }).ToList();

            return query;
           
        }

        public void DeleteSubjectStudent(int studentId)
        {
            subjectList[subjectList.FindIndex(x => x.SubjectId == currentSubject.SubjectId)].StudentId.Remove(studentId);
            noteList.Remove(noteList.FirstOrDefault(x => x.StudentId == studentId));
            File.WriteAllText(@"Subject.json", JsonConvert.SerializeObject(subjectList));
            File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
        }

        public void AddPoint(double dqt, double dt, int studentId)
        {
            noteList[noteList.FindIndex(x => x.StudentId == studentId)].dt = dt;
            noteList[noteList.FindIndex(x => x.StudentId == studentId)].dqt = dqt;
            File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
        }

        public void AddNotes(string notes, int studentId)
        {
            noteList[noteList.FindIndex(x => x.StudentId == studentId)].Notes = notes;
            File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
        }

    }
}
