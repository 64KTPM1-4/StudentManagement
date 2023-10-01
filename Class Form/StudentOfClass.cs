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
        JoinTableServices joinTableServices;
        public StudentOfClass(ClassModel selectedClass)
        {
            InitializeComponent();
            currentClass = selectedClass;
            joinTableServices = new JoinTableServices(selectedClass);
            ClassStudentGridView.DataSource = joinTableServices.JoinClassStudents();
            ClassNameLabel.Text = "Danh sách sinh viên thuộc lớp quản lí " + selectedClass.ClassName;

            
        }

        private void StudentOfClass_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
