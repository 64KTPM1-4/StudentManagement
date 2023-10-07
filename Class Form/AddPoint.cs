using Newtonsoft.Json;
using QuanLiSinhVien.Model;
using QuanLiSinhVien.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class AddPoint : Form
    {
        NoteServices notesServices;
        SubjectModel subject;
        string className;
        public AddPoint(SubjectModel currentSubject, string ClassName)
        {
            InitializeComponent();
            notesServices = new NoteServices();
            subject = currentSubject;
            className = ClassName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var points = double.Parse(textBox1.Text);
            var Id = JsonConvert.DeserializeObject<List<ClassModel>>(File.ReadAllText(@"Class.json")).FirstOrDefault(x => x.ClassName == className);
            notesServices.AddPoint(points, , Id.ClassId);
        }
    }
}
