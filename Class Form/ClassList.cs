using QuanLiSinhVien.Class;
using QuanLiSinhVien;
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
        private List<ClassModel> classList;
        public ClassList()
        {
            InitializeComponent();
            classServices = new ClassServices();
            classList = new List<ClassModel> { };
            classList = classServices.ClassSearch();
            if (classList.Count > 0)
            {
                this.dataGridView1.DataSource = classList;

                int height = 35;
                foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                {
                    if (dataGridViewRow.Visible) height += dataGridViewRow.Height;
                }
                dataGridView1.Height = height;
            }
            else
            {

                dataGridView1.Hide();
                EmptyClassList.Show();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var onclick = dataGridView1.SelectedCells[0].Value.ToString();
                var selectedClass = classList.FirstOrDefault(x => x.ClassName == onclick);
                SubjectList subjectList = new SubjectList(classList, selectedClass);
                this.Hide();
                subjectList.ShowDialog();
                this.Show();
                
                
                
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Add_Class_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
            dataGridView1.DataSource = classServices.ClassSearch();
            dataGridView1.Update();
            dataGridView1.Refresh();
            
        }
    }
}
