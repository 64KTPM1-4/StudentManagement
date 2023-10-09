using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Model;
using System.IO;
using Newtonsoft.Json;
using QuanLiSinhVien.Services;

namespace QuanLiSinhVien
{
    public partial class TeacherList : Form
    {
        List<TeacherModel> teacherList;
        TeacherServices teacherServices;
        public TeacherList()
        {
            InitializeComponent();
            teacherServices = new TeacherServices();
            teacherList = teacherServices.TeacherSearch();
            TeacherGridView.DataSource = teacherList;

        }


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
            TeacherGridView.DataSource = teacherServices.TeacherSearch();
            TeacherGridView.Update();
            TeacherGridView.Refresh();
        }

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            teacherServices.DeleteTeacher(TeacherGridView.SelectedCells[0].Value.ToString());
            TeacherGridView.DataSource = teacherServices.TeacherSearch();
            TeacherGridView.Update();
            TeacherGridView.Refresh();
            DeleteTeacherButton.Hide();
        }

        private void TeacherGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var onclick = TeacherGridView.SelectedCells[0].Value.ToString();
            if (e.ColumnIndex == 1 && onclick != "0")
            {
                DeleteTeacherButton.Show();
            }
            else DeleteTeacherButton.Hide();
        }
    }
}
