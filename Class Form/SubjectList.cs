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
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    public partial class SubjectList : Form
    {
        SubjectServices subjectServices;
        ClassModel currenntClass;
        List<ClassModel> currentClassList;
        public SubjectList(List<ClassModel> classList ,ClassModel selectedClass)
        {
            InitializeComponent();
            subjectServices = new SubjectServices(classList, selectedClass);
            SubjectGridView.DataSource = subjectServices.SubjectsSearch();
            currenntClass = classList.FirstOrDefault(x => x == selectedClass);
            currentClassList = classList;
            

            if(currenntClass.Subjects.Count > 0)
            {
                SubjectGridView.DataSource = subjectServices.SubjectsSearch();
                int height = 35;
                foreach(DataGridViewRow row in SubjectGridView.Rows)
                {
                    if(row.Visible) height += row.Height;
                }
                SubjectGridView.Height = height;
            }
            else
            {
                SubjectGridView.Hide();
                EmptyClassList.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject(currentClassList, currenntClass);
            addSubject.ShowDialog();
            SubjectGridView = new DataGridView();
            this.SubjectGridView.DataSource = subjectServices.SubjectsSearch();
            SubjectGridView.Update();
            SubjectGridView.Refresh();
            
        }
    }
}
