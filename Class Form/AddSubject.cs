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
using QuanLiSinhVien.Model;

namespace QuanLiSinhVien
{
    public partial class AddSubject : Form
    {
        List<ClassModel> classList;
        ClassModel currentClass;
        SubjectServices subjectServices;
        public AddSubject(List<ClassModel> classes, ClassModel currentClass)
        {
            InitializeComponent();
            classList = classes;
            this.currentClass = currentClass;
            subjectServices = new SubjectServices(classList, currentClass);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) AddSubjectLabel.Hide();
            else AddSubjectLabel.Show();
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            
            subjectServices.AddedSubject(textBox1.Text);
            this.Close();
        }
    }
}
