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

namespace QuanLiSinhVien.Class
{
    public partial class AddClass : Form
    {
        private ClassServices classServices;
        public AddClass()
        {
            classServices = new ClassServices();
            InitializeComponent();
        }

        private void AddClassLabel_MouseHover(object sender, EventArgs e)
        {
            AddClassLabel.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AddClassLabel.Hide();
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            //classServices.AddClass(textBox1.Text);
            if (classServices.AddClass(textBox1.Text))
                this.Close();
            else MessageBox.Show("Lớp đã tồn tại !");
        }

        private void AddClassButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                AddClassButton_Click(sender, e);
            }
        }
    }
}
