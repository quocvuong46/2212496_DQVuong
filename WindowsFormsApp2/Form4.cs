using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        
        private void cbbChonHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbHinhAnh.Image = imlDemo.Images[cbbChonHinh.SelectedIndex];
        }

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void frm4_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= imlDemo.Images.Count; i++)
            {
                cbbChonHinh.Items.Add("Hình " + i);
            }
        }
    }
}
