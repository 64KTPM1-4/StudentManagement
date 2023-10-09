using Newtonsoft.Json;
using QuanLiSinhVien.Model;
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
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    
    public partial class SubjectInClass : Form
    {
        AddClassSubject addClassSubject;
        ClassModel currentClass;
        ClassServices classServices;
        JoinTableServices joinTableServices;
        int currentSubjectId;
        public SubjectInClass(ClassModel selectedClass, int SubjectId = -5)
        {
            InitializeComponent();
            currentClass = selectedClass;
            joinTableServices = new JoinTableServices(currentClass);
            currentSubjectId = SubjectId;
            
            ClassNameLabel.Text = "Danh sách học phần của lớp " + currentClass.ClassName;
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject(SubjectId);
            addClassSubject = new AddClassSubject(currentClass);
            classServices = new ClassServices();
            if (SubjectId != -5) AddClassSubjectButton.Hide();
            
        }

        private void ClassSubjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = ClassSubjectGridView.SelectedCells[0].Value.ToString();
            if(e.ColumnIndex == 1 && onclick != "0" && currentSubjectId == -5)
            {
                DeleteClassSubjectButton.Show();
                ShowSubjectStudent.Show();
            }
            else if (e.ColumnIndex == 1 && onclick != "0" && currentSubjectId != -5)
            {
                
                ShowSubjectStudent.Show();
            }
            else
            {
                DeleteClassSubjectButton.Hide();
                ShowSubjectStudent.Hide();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClassSubject_Click(object sender, EventArgs e)
        {
            addClassSubject.ShowDialog();
            joinTableServices = new JoinTableServices(currentClass);
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject();
            ClassSubjectGridView.Update();
            ClassSubjectGridView.Refresh();

        }

        private void DeleteClassSubjectButton_Click(object sender, EventArgs e)
        {
            joinTableServices.DeleteClassSubject(ClassSubjectGridView.SelectedCells[0].Value.ToString());
            joinTableServices = new JoinTableServices(currentClass);
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject();
            ClassSubjectGridView.Update();
            ClassSubjectGridView.Refresh();
            DeleteClassSubjectButton.Hide();
            ShowSubjectStudent.Hide();
        }

        private void ShowSubjectStudent_Click(object sender, EventArgs e)
        {
            var subjectList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText("Subject.json"));
            StudentInSubject studentInSubject = new StudentInSubject(subjectList.FirstOrDefault(x => x.SubjectName == ClassSubjectGridView.SelectedCells[0].Value.ToString()), currentClass, currentSubjectId);
            this.Hide();
            studentInSubject.ShowDialog();
            this.Show();
            DeleteClassSubjectButton.Hide();
            ShowSubjectStudent.Hide();
        }

        private void SubjectInClass_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteClassSubjectButton.Hide();
            ShowSubjectStudent.Hide();
        }
    }
}
