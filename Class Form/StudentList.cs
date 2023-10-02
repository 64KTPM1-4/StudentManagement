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
using QuanLiSinhVien.Model;

namespace QuanLiSinhVien
{
    public partial class StudentList : Form
    {
        StudentSevices studentSevices;
        List<StudentModel> studentLists;
        public StudentList()
        {
            InitializeComponent();
            studentSevices = new StudentSevices();
            studentLists = studentSevices.StudentSearch();
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

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = StudentGridView.SelectedCells[0].Value.ToString();
            if (e.ColumnIndex == 1 && onclick != "0")
            {
                ShowButton();
            }
            else HideButton();
        }

        private void ShowButton()
        {
            
            DeleteStudentButton.Show();
        }
        
        private void HideButton()
        {
            
            DeleteStudentButton.Hide();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            studentSevices.DeleteStudent(StudentGridView.SelectedCells[0].Value.ToString());
            StudentGridView.DataSource = studentSevices.StudentSearch();
            StudentGridView.Update();
            StudentGridView.Refresh();
            DeleteStudentButton.Hide();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
