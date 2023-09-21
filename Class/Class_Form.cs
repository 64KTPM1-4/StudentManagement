using QuanLiSinhVien.Class;
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
    public partial class Class_Form : Form
    {
        public Class_Form()
        {
            InitializeComponent();
        }


        private void Show_Class_Click(object sender, EventArgs e)
        {
            ClassList studentForm = new ClassList();
            this.Hide();
            studentForm.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Class_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            this.Hide();
            addClass.ShowDialog();
            this.Show();
        }

        private void Delete_Class_Click(object sender, EventArgs e)
        {
            DeleteClass delClass = new DeleteClass();
            this.Hide();
            delClass.ShowDialog();
            this.Show();
        }
    }
}
