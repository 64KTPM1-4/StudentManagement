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
            classList = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText("Class.json"));
            ClassListBox.DataSource = classList;
            ClassListBox.DisplayMember = "ClassName";
            ClassListBox.ValueMember = "ClassId";
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() > 0) {
                AddStudentLabel.Hide();
                if (ClassListBox.SelectedValue != null)
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
            var ClassId = (int)ClassListBox.SelectedValue;
            studentSevices.AddStudent(textBox1.Text);
            this.Close();
           
            
        }
    }
}
