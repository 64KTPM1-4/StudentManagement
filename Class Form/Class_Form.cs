using QuanLiSinhVien.Class;
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
    public partial class Class_Form : Form
    {
        public Class_Form()
        {
            InitializeComponent();
        }


        private void Show_Class_Click(object sender, EventArgs e)
        {
            ClassList studentForm = new ClassList();
            this.Hide();
            studentForm.ShowDialog();
            this.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Class_Click(object sender, EventArgs e)
        {
            SubjectList subjectList = new SubjectList();
            this.Hide();
            subjectList.ShowDialog();
            this.Show();
        }

        private void Delete_Class_Click(object sender, EventArgs e)
        {
            
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            TeacherList teacherList = new TeacherList();
            this.Hide();
            teacherList.ShowDialog();
            this.Show();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            this.Hide();
            studentList.ShowDialog();
            this.Show();
        }
    }
}
