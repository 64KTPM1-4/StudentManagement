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

        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            teacherServices.AddTeacher(textBox1.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                AddTeacherLabel.Hide();
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
