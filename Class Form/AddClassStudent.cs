using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using QuanLiSinhVien.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class AddClassStudent : Form
    {
        StudentSevices studentSevices;
        ClassModel currentClass;
        ClassServices classServices;
        public AddClassStudent(ClassModel currentClass)
        {
            InitializeComponent();
            this.currentClass = currentClass;
            classServices = new ClassServices();
            studentSevices = new StudentSevices();
            StudentComboBox.DataSource = studentSevices.StudentSearch();
            StudentComboBox.DisplayMember = "Name";
            StudentComboBox.ValueMember = "Id";
            int MemberCount = StudentComboBox.Items.Count;

            if (MemberCount > 0) AddStudentToClassButton.Show();
            else AddStudentToClassButton.Hide();
        }

        private void AddStudentToClassButton_Click(object sender, EventArgs e)
        {
            int Id = (int)StudentComboBox.SelectedValue;
            string Check = classServices.AddClassStudent(currentClass, Id);
            if (Check == "")
                this.Close();
            else if (Check == "In this class") MessageBox.Show("Sinh viên đã có trong lớp này !");
            else
            {
                MessageBox.Show("Sinh viên đã có trong lớp " + Check);
            }
            
            
        }
    }
}
