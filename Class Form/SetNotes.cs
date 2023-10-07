using QuanLiSinhVien.Model;
using QuanLiSinhVien.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class SetNotes : Form
    {
        int studentId;
        JoinSubjectStudent joinSubjectStudent;
        public SetNotes(ClassModel currentClass, SubjectModel currentSubject, int studentId)
        {
            InitializeComponent();
            joinSubjectStudent = new JoinSubjectStudent(currentClass, currentSubject);
            this.studentId = studentId;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            joinSubjectStudent.AddNotes(NotesBox.Text, studentId);
            this.Close();
        }
    }
}
