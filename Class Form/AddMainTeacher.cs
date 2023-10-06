using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    public partial class AddMainTeacher : Form
    {
        TeacherServices teacherServices;
        ClassServices classServices;
        int classId;
        public AddMainTeacher(int currentClassId)
        {
            InitializeComponent();
            teacherServices = new TeacherServices();
            TeacherListBox.DataSource = teacherServices.TeacherSearch();
            TeacherListBox.Text = "Chọn GVCN";
            TeacherListBox.DisplayMember = "TeacherName";
            TeacherListBox.ValueMember = "TeacherId";
            classId = currentClassId;
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            classServices = new ClassServices();
            int TeacherId = (int)TeacherListBox.SelectedValue;
            classServices.AddMainTeacher(classId, TeacherId);
            this.Close();
        }
    }
}
