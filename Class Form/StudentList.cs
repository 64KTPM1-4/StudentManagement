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
    public partial class StudentList : Form
    {
        StudentSevices studentSevices;
        public StudentList()
        {
            InitializeComponent();
            studentSevices = new StudentSevices();
            StudentGridView.DataSource = studentSevices.StudentSearch();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            StudentGridView.DataSource = studentSevices.StudentSearch();
            StudentGridView.Update();
            StudentGridView.Refresh();
        }
    }
}
