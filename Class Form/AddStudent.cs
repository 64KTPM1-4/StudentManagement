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
using Newtonsoft.Json;
using System.IO;

namespace QuanLiSinhVien
{
    public partial class AddStudent : Form
    {
        StudentSevices studentSevices;
        List<ClassModel> classList;
        public AddStudent()
        {
            InitializeComponent();
            studentSevices = new StudentSevices();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() > 0) {
                AddStudentLabel.Hide();
                AddClassButton.Show();
                
            }
            else
            {
                AddStudentLabel.Show();
                AddClassButton.Hide();
            }
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            
            studentSevices.AddStudent(textBox1.Text);
            this.Close();
           
            
        }
    }
}
