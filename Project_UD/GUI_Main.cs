using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UD
{
    public partial class GUI_Main : Form
    {
        public GUI_Main()
        {
            InitializeComponent();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_CV frm_CV = new GUI_CV();
            frm_CV.MdiParent = this;
            frm_CV.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_PB frm_PB = new GUI_PB();
            frm_PB.MdiParent = this;
            frm_PB.Show();
        }
    }
}
