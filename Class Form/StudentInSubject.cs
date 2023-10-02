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
        SubjectServices subjectServices;
        SubjectModel currentSubject;
        public StudentInSubject(SubjectModel selectedSubject, string ClassName)
        {
            InitializeComponent();
            joinSubjectStudent = new JoinSubjectStudent(selectedSubject.SubjectName);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            currentSubject = selectedSubject;
            ClassNameLabel.Text = "Danh sách sinh viên đăng ký học phần " + currentSubject.SubjectName + " lớp " + ClassName;
        }

        private void SubjectStudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = SubjectStudentGridView.SelectedCells[0].Value.ToString();
            if (e.ColumnIndex == 1 && onclick != "0")
            {
                DeleteClassStudentButton.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClassStudentButton_Click(object sender, EventArgs e)
        {
            AddSubjectStudent addSubjectStudent = new AddSubjectStudent(currentSubject);
            addSubjectStudent.ShowDialog();
            joinSubjectStudent = new JoinSubjectStudent(currentSubject.SubjectName);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
        }

        private void DeleteClassStudentButton_Click(object sender, EventArgs e)
        {
            joinSubjectStudent.DeleteSubjectStudent(SubjectStudentGridView.SelectedCells[0].Value.ToString());
            joinSubjectStudent = new JoinSubjectStudent(currentSubject.SubjectName);
            SubjectStudentGridView.DataSource = joinSubjectStudent.Join();
            SubjectStudentGridView.Update();
            SubjectStudentGridView.Refresh();
            DeleteClassStudentButton.Hide();

        }
    }
}
