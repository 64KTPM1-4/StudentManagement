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
    public partial class SetPoint : Form
    {
        int studentId;
        JoinSubjectStudent joinSubjectStudent;
       
        public SetPoint(ClassModel currentClass, SubjectModel currentSubject, int studentId)
        {
            InitializeComponent();
            joinSubjectStudent = new JoinSubjectStudent(currentClass, currentSubject);
            this.studentId = studentId;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }

        private void dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                double dt = double.Parse(dtTextBox.Text);
                double dqt = double.Parse(dqtTextBox.Text);
                if (dt < 0 || dqt < 0 || dt > 10 || dqt > 10) MessageBox.Show("Số điểm phải trong khoảng 0 - 10");
                else
                {
                    joinSubjectStudent.AddPoint(dqt, dt, studentId);
                    this.Close();
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Số điểm phải là số thực");
            }
        }
    }
}
