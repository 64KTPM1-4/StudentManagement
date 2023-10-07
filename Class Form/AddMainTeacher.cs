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
    public partial class AddMainTeacher : Form
    {
        TeacherServices teacherServices;
        ClassServices classServices;
        ClassModel currentClass;
        int teacherId;
        public AddMainTeacher(ClassModel selectedClass)
        {
            InitializeComponent();
            currentClass = selectedClass;
            teacherServices = new TeacherServices();
            TeacherComboBox.DataSource = teacherServices.TeacherSearch();
            TeacherComboBox.DisplayMember = "TeacherName";
            TeacherComboBox.ValueMember = "TeacherId";
            int MemberCount = TeacherComboBox.Items.Count;

            if (MemberCount > 0) OkButton.Show();
            else OkButton.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            classServices = new ClassServices();
            teacherId = (int)TeacherComboBox.SelectedValue;
            classServices.AddMainTeacher(currentClass, teacherId);
            this.Close();
        }
        public int TeacherId()
        {
            return teacherId;
        }
    }
}
