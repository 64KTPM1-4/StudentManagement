using QuanLiSinhVien.Class;
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
    public partial class ClassList : Form
    {
        private ClassServices classServices;
        public ClassList()
        {
            classServices = new ClassServices();
           // dataGridView1 = new DataGridView();
            var classList = new List<ClassModel> { };
            classList = classServices.ClassSearch();
            //dataGridView1.DataSource = classList;
            InitializeComponent();
        }


    }
}
