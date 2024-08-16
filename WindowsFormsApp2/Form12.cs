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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items =this.checkedListBox1.CheckedItems;
            string s = "";
            foreach (object ob in items)
            {
                s+= ob.ToString()+",";
            }
            MessageBox.Show("Danh sach mon hoc: "+s);
        }
    }
}
