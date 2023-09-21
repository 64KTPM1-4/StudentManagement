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
        public AddClass()
        {
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.Close();
            }
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
