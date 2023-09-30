using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiSinhVien.Services;
using QuanLiSinhVien.Model;
namespace QuanLiSinhVien
{
    
    public partial class EditClass : Form
    {
        ClassServices classServices;
        ClassModel currentClass;
        public EditClass(ClassModel selectedClass)
        {
            InitializeComponent();
            classServices = new ClassServices();
            currentClass = selectedClass;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) EditClassLabel.Hide();
            else EditClassLabel.Show();
        }

        private void EditClassButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == currentClass.ClassName) MessageBox.Show("Tên lớp mới phải khác tên lớp cũ !");
            else
            {
                if (classServices.EditClassName(currentClass.ClassName, textBox1.Text)) this.Close();
                else MessageBox.Show("Tên lớp đã tồn tại !");
            }
            
            
        }
    }
}
