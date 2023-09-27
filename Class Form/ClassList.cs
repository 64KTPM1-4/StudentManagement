using QuanLiSinhVien.Class;
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
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.Show();
            
        }
    }
}
