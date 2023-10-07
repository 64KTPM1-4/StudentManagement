using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using System.IO;
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    public partial class AddSubjectStudent : Form
    {
        SubjectModel currentSubject;
        List<StudentModel> studentList;
        SubjectServices subjectServices;
        ClassModel currentClass;
        public AddSubjectStudent(ClassModel selectedClass ,SubjectModel selectedSubject)
        {
            InitializeComponent();
            currentClass = selectedClass;
            this.currentSubject = selectedSubject;
            studentList = JsonConvert.DeserializeObject<List<StudentModel>>(File.ReadAllText("Student.json"));
            StudentListBox.DataSource = studentList;
            StudentListBox.DisplayMember = "Name";
            StudentListBox.ValueMember = "Id";
            subjectServices = new SubjectServices();
            int memberCount = StudentListBox.Items.Count;
            if(memberCount > 0 )
            {
                OkButton.Show();
            }
            else OkButton.Hide();
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int Id = (int)StudentListBox.SelectedValue;
            if (subjectServices.AddSubjectStudent(currentSubject, currentClass, Id))
                this.Close();
            else MessageBox.Show("Sinh viên đã tồn tại trong danh sách !");
        }
    }
}
