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
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = lbds.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbdschon.Items.Add(lbds.SelectedItems[i]);
                lbds.Items.Remove(lbds.SelectedItems[i]);
                // lstDanhsach.Items.RemoveAt(lstDanhsach.SelectedIndices[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = lbdschon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbdschon.Items.RemoveAt(lbdschon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
