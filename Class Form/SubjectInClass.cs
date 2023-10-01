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
        public SubjectInClass(ClassModel selectedClass)
        {
            InitializeComponent();
            currentClass = selectedClass;
            ClassNameLabel.Text = "Danh sách học phần của lớp " + currentClass.ClassName;
            joinTableServices = new JoinTableServices(currentClass);
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject();
            addClassSubject = new AddClassSubject(currentClass);
            classServices = new ClassServices();

        }

        private void ClassSubjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClassSubject_Click(object sender, EventArgs e)
        {
           
            addClassSubject.ShowDialog();
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject();
            ClassSubjectGridView.Update();
            ClassSubjectGridView.Refresh();

        }

        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            classServices.DeleteClass(currentClass.ClassName);
            this.Close();
        }

        private void EditClass_Click(object sender, EventArgs e)
        {
            EditClass editClass = new EditClass(currentClass);
            editClass.ShowDialog();
            currentClass = classServices.ClassSearch().FirstOrDefault(x => x.ClassId == currentClass.ClassId);
            ClassSubjectGridView.DataSource = joinTableServices.JoinClassSubject();
            ClassSubjectGridView.Update();
            ClassSubjectGridView.Refresh();
            ClassNameLabel.Text = "Danh sách học phần của lớp " + currentClass.ClassName;


        }
    }
}
