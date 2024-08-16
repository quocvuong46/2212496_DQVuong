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
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void ckbMauchu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauchu.Checked)
                this.btnbt.ForeColor = Color.Red;
            else
                this.btnbt.ForeColor = Color.Black;
        }

        private void ckbMaunen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMaunen.Checked)
                this.btnbt.BackColor = Color.LightCyan;
            else
                this.btnbt.BackColor = this.btnbtfl.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnbtfl.FlatStyle = FlatStyle.Flat;
            else
                this.btnbtfl.FlatStyle = FlatStyle.Popup;
        }
    }
}
