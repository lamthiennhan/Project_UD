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
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GUI_Main frm_Main = new GUI_Main();
            frm_Main.Show();   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            picLogin.Image = imgList.Images[0];
        }
    }
}
