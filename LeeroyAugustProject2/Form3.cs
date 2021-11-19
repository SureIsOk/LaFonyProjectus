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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Shown(object sender, EventArgs e)
        {
            Random klaarTijd = new Random();

            timerKlaar.Interval = klaarTijd.Next(1, 2) * 1000;

            timerKlaar.Enabled = true;
            timerLoading.Enabled = true;
            timerNieuweTip.Enabled = true;
            do
            {
                geselecteerd = tips[nieuweTel.Next(0, tips.Length)];
            }
            while (geselecteerd == txtTipInhoud.Text);
            txtTipInhoud.Text = geselecteerd;
        }

        int tel = 0;
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            tel += 1;
            if (tel <= 3)
            {
                lblLoad.Text += ".";
            }
            else
            {
                tel = 0;
                lblLoad.Text = "Loading";
            }
        }

        Random nieuweTel = new Random();
        String geselecteerd;
        String[] tips = new String[] {"Als je een fout maakt word het knopje rood", "Als je een juist antwoord geeft wordt het knopje groen","Klik op de knopjes om antwoorden in te geven","Tips zijn lastig om te verzinnen","Je kunt deze game niet in het Spaans zetten in de instellingen tab","Je hebt 10 levens totdat je kan verliezen","Als je het woord kan raden win je","Is een laadscherm overbodig? (ja dat is het)","er zijn niet zoveel tips die ik kan verzinnen"};
         private void timerNieuweTip_Tick(object sender, EventArgs e)
         {
            do
            {
                geselecteerd = tips[nieuweTel.Next(0, tips.Length)];
            }
            while (geselecteerd == txtTipInhoud.Text);
            txtTipInhoud.Text = geselecteerd;
         }

        private void timerKlaar_Tick(object sender, EventArgs e)
        {
            lblLoad.Text = "Done!";
            timerDone.Enabled = true;
        }


        frmGalgje frmSpel = new frmGalgje();
        private void timerDone_Tick(object sender, EventArgs e)
        {
            frmSpel.Show();
            this.Close(); //Sluit Moet later nog vervangen worden(?)
        }
    }
}
