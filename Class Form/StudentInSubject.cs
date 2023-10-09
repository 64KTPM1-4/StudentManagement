using QuanLiSinhVien;
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
    public partial class StudentInSubject : Form
    {
        JoinSubjectStudent joinSubjectStudent;

        SubjectModel currentSubject;
        ClassModel currentClass;
        int selectedStudentId;
        int SubjectId;
        public StudentInSubject(SubjectModel selectedSubject, ClassModel selectedClass, int currentSubjectId = -5)
        {
            InitializeComponent();
            currentClass = selectedClass;
            joinSubjectStudent = new JoinSubjectStudent(selectedClass, selectedSubject);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            currentSubject = selectedSubject;
            ClassNameLabel.Text = "Danh sách sinh viên đăng ký học phần " + currentSubject.SubjectName + " lớp " + currentClass.ClassName;
            SubjectId = currentSubjectId;
            if (currentSubjectId != -5) AddClassStudentButton.Hide();
        }

        private void SubjectStudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = SubjectStudentGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == 1 && SubjectId == -5)
            {
                DeleteClassStudentButton.Show();
                PointButton.Show();
                NoteButton.Show();
                selectedStudentId = (int)SubjectStudentGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            else if (e.ColumnIndex == 1 && SubjectId != -5)
            {
                
                PointButton.Show();
                NoteButton.Show();
                selectedStudentId = (int)SubjectStudentGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            else if (e.ColumnIndex == 5) MessageBox.Show(SubjectStudentGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            else
            {
                DeleteClassStudentButton.Hide();
                PointButton.Hide();
                NoteButton.Hide();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClassStudentButton_Click(object sender, EventArgs e)
        {
            AddSubjectStudent addSubjectStudent = new AddSubjectStudent(currentClass, currentSubject);
            addSubjectStudent.ShowDialog();
            joinSubjectStudent = new JoinSubjectStudent(currentClass, currentSubject);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
        }

        private void DeleteClassStudentButton_Click(object sender, EventArgs e)
        {
            joinSubjectStudent.DeleteSubjectStudent(selectedStudentId);
            joinSubjectStudent = new JoinSubjectStudent(currentClass ,currentSubject);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
            DeleteClassStudentButton.Hide();

        }

        private void StudentInSubject_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteClassStudentButton.Hide();
            PointButton.Hide();
            NoteButton.Hide();
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            SetPoint setPoint = new SetPoint(currentClass, currentSubject, selectedStudentId);
            setPoint.ShowDialog();
            joinSubjectStudent = new JoinSubjectStudent(currentClass, currentSubject);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
            DeleteClassStudentButton.Hide();
            PointButton.Hide();
            NoteButton.Hide();
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {
            SetNotes setNotes = new SetNotes(currentClass, currentSubject, selectedStudentId);
            setNotes.ShowDialog();
            joinSubjectStudent = new JoinSubjectStudent(currentClass, currentSubject);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
            DeleteClassStudentButton.Hide();
            PointButton.Hide();
            NoteButton.Hide();

        }
    }
}
