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
    public partial class StudentOfClass : Form
    {
        ClassModel currentClass;
        TeacherServices teacherServices;
        JoinClassStudentServices joinClassStudentServices;
        ClassServices classServices;
        int selectedStudentId;
        List<TeacherModel> currentTeacher;
        public StudentOfClass(ClassModel selectedClass)
        {
            InitializeComponent();
            classServices = new ClassServices();
            currentClass = selectedClass;
            joinClassStudentServices = new JoinClassStudentServices(currentClass);
            teacherServices = new TeacherServices();
            ClassStudentGridView.DataSource = joinClassStudentServices.JoinList();
            if(currentClass.MainTeacherId >= 0)
            {
                currentTeacher = teacherServices.TeacherSearch(currentClass.MainTeacherId);
                MainTeacherName.Text = "GVCN: " + currentTeacher[0].TeacherName;
            }
            else
            {
                MainTeacherName.Text = "GVCN: Chưa có";
            }
            
            ClassNameLabel.Text = "Danh sách sinh viên thuộc lớp quản lí " + selectedClass.ClassName;

            if (MainTeacherName.Text == "GVCN: Chưa có")
            {
                AddMainTeacherButton.Show();
                
            }
            else DeleteMainTeacherButton.Show();
        }


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddStudentToClassButton_Click(object sender, EventArgs e)
        {
            AddClassStudent addClassStudent = new AddClassStudent(currentClass);
            addClassStudent.ShowDialog();
            joinClassStudentServices = new JoinClassStudentServices(currentClass);
            ClassStudentGridView.DataSource = joinClassStudentServices.JoinList();
            ClassStudentGridView.Update();
            ClassStudentGridView.Refresh();
        }

        private void ClassStudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = ClassStudentGridView.SelectedCells[0].Value.ToString();
            if (e.ColumnIndex == 1 && onclick != "0")
            {
                selectedStudentId = (int)ClassStudentGridView.Rows[e.RowIndex].Cells[0].Value;
                DeleteStudentFromClassButton.Show();
            }
            else
            {
                DeleteStudentFromClassButton.Hide();
            }
        }

        private void DeleteStudentFromClassButton_Click(object sender, EventArgs e)
        {
            classServices.DeleteStudentFromClass(currentClass, selectedStudentId);
            joinClassStudentServices = new JoinClassStudentServices(currentClass);
            ClassStudentGridView.DataSource = joinClassStudentServices.JoinList();
            ClassStudentGridView.Update();
            ClassStudentGridView.Refresh();
        }

        private void AddMainTeacherButton_Click(object sender, EventArgs e)
        {
            AddMainTeacher addMainTeacher = new AddMainTeacher(currentClass);
            addMainTeacher.ShowDialog();
            currentTeacher = teacherServices.TeacherSearch(addMainTeacher.TeacherId());
            MainTeacherName.Text = "GVCN: " + currentTeacher[0].TeacherName;
            AddMainTeacherButton.Hide();
            DeleteMainTeacherButton.Show();

        }

        private void DeleteMainTeacherButton_Click(object sender, EventArgs e)
        {
            classServices.DeleteMainTeacher(currentClass);
            MainTeacherName.Text = "GVCN: Chưa có";
            DeleteMainTeacherButton.Hide();
            AddMainTeacherButton.Show();
        }
    }
}
