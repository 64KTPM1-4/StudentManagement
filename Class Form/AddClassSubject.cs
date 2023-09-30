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
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int IdList = (int)SubjectListBox.SelectedValue;
            ClassServices.AddClassSubject(currentClass, IdList);
            this.Close();
        }
    }
}
