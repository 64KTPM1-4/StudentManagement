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
        StudentSevices studentSevices;
        TeacherServices teacherServices;
        JoinListStudentServices joinListStudentServices;
        public StudentOfClass(ClassModel selectedClass)
        {
            InitializeComponent();
            currentClass = selectedClass;
            studentSevices = new StudentSevices();
            teacherServices = new TeacherServices();
            joinListStudentServices = new JoinListStudentServices(currentClass);
            ClassStudentGridView.DataSource = joinListStudentServices.joinListStudent();
            var currentTeacher = teacherServices.MainTeacher(currentClass);

            MainTeacherName.Text = "GVCN: " + currentTeacher;
            if (currentTeacher == "Chưa có")
            {
                AddMainTeacherButton.Show();
            }


            ClassNameLabel.Text = "Danh sách sinh viên thuộc lớp quản lí " + selectedClass.ClassName;

            
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMainTeacherButton_Click(object sender, EventArgs e)
        {
            AddMainTeacher addMainTeacher = new AddMainTeacher(currentClass.ClassId);
            addMainTeacher.ShowDialog();
            teacherServices = new TeacherServices();
            MainTeacherName.Text = teacherServices.MainTeacher(currentClass);
            MainTeacherName.Update();
            MainTeacherName.Refresh();
        }
    }
}
