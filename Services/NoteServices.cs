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
    public class NoteServices
    {
        public List<NotesModel> NoteSearch(StudentModel selectedStudent = null)
        {
            var noteList = new List<NotesModel>() { };
            try
            {
                string json = File.ReadAllText(@"Note.json");
                noteList = JsonConvert.DeserializeObject<List<NotesModel>>(json);
                if (selectedStudent != null)
                {
                    noteList = noteList.Where(x => x.StudentId == selectedStudent.Id).Select(x => new NotesModel
                    {
                        Notes = x.Notes,
                        Diem = x.Diem,
                        StudentId = x.StudentId,
                        ClassId = x.ClassId,
                    }).OrderBy(x => x.Notes).ToList();
                }
                else
                {
                    noteList = noteList.OrderBy(x => x.Notes).ToList();
                }
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(@"Note.json", "[]");
            }
            return noteList;
        }

        public void AddNote(string Note, int StudentId, int ClassId)
        {
            var noteList = NoteSearch();
            List<NotesModel> newNote = new List<NotesModel>();
            newNote.Add(new NotesModel
            {
                Notes = Note,
                StudentId = StudentId,
                ClassId = ClassId
            });

            noteList.AddRange(newNote);
            File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
        }

        public void DeleteNote(string Note) 
        {
            var noteList = NoteSearch();
            var index = noteList.FindIndex(s => s.Notes == Note);
            noteList.RemoveAt(index);
            File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
        }

        public void EditNote(string oldNote, string newNote)
        {
            var noteList = NoteSearch();
            var Note = noteList.FirstOrDefault(x => x.Notes.Equals(oldNote, StringComparison.OrdinalIgnoreCase));

            if(Note != null) 
            {
                Note.Notes = newNote;
                File.WriteAllText(@"Note.json", JsonConvert.SerializeObject(noteList));
            }
        }

        public void AddPoint(float Diem, int StudentId, int ClassId)
        {
            var noteList = NoteSearch();
        }
    }
}