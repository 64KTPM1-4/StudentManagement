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
        ClassModel currentClass = new ClassModel();
        public SubjectInClass(ClassModel selectedClass)
        {
            InitializeComponent();
            currentClass = selectedClass;
            
            ClassSubjectGridView.DataSource = JoinTableServices.JoinClassSubject(selectedClass);
           
        }

        private void ClassSubjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClassSubject addClassSubject = new AddClassSubject(currentClass);
            addClassSubject.ShowDialog();
            ClassSubjectGridView.DataSource = JoinTableServices.JoinClassSubject(currentClass);
            ClassSubjectGridView.Update();
            ClassSubjectGridView.Refresh();

        }
    }
}
