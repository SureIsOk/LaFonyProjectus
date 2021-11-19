using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeeroyAugustProject2
{
    public partial class frmFrontPage : Form
    {
        public frmFrontPage()
        {
            InitializeComponent();
        }

        frmLoad frmLaden = new frmLoad();
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmLaden.Show();
        }

        frmAuteurs frmAuteur = new frmAuteurs();
        private void BtnAuteurs_Click(object sender, EventArgs e)
        {
            frmAuteur.Show();
        }
    }
}
