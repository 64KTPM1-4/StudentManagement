using Newtonsoft.Json;
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
using System.IO;

namespace QuanLiSinhVien
{
    public partial class AddTeacher : Form
    {
        TeacherServices teacherServices;
        List<ClassModel> classList;
        public AddTeacher()
        {
            InitializeComponent();
            teacherServices = new TeacherServices();
            classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText("Class.json"));
            ClassListBox.DataSource = classList;
            ClassListBox.DisplayMember = "ClassName";
            ClassListBox.ValueMember = "ClassName";
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            var classId = ClassListBox.SelectedValue.ToString();
            teacherServices.AddTeacher(textBox1.Text, classId);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AddTeacherLabel.Hide();
                if(ClassListBox.SelectedValue != null)
                    AddTeacherButton.Show();
            }
            else
            {
                AddTeacherLabel.Show();
                AddTeacherButton.Hide();
            }
        }
    }
}
