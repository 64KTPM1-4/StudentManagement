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
using QuanLiSinhVien.Model;
using Newtonsoft.Json;
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    public partial class AddClassSubject : Form
    {
        List<SubjectModel> subjecList;
        ClassServices ClassServices;
        ClassModel currentClass = new ClassModel();
        public AddClassSubject(ClassModel selectedClass)
        {
            InitializeComponent();
            subjecList = JsonConvert.DeserializeObject<List<SubjectModel>>(File.ReadAllText(@"Subject.json"));
            SubjectListBox.DataSource = subjecList;
            SubjectListBox.DisplayMember = "SubjectName";
            SubjectListBox.ValueMember = "SubjectId";
            ClassServices = new ClassServices();
            currentClass = selectedClass;
            int MemberCount = SubjectListBox.Items.Count;

            if (MemberCount > 0) OkButton.Show();
            else OkButton.Hide();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            int Id = (int)SubjectListBox.SelectedValue;
            if (ClassServices.AddClassSubject(currentClass, Id))
                this.Close();
            else MessageBox.Show("Môn học đã tồn tại !");
        }
    }
}
