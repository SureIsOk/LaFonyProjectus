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
    public partial class frmGalgje : Form
    {
        public frmGalgje()
        {
            InitializeComponent();
        }

        Random galgjeRandom = new Random();
        String[] woorden = new String[] {"appelsien","kersentaart"};
        String[] appelsien = new string[] { "a", "p", "p", "e", "l", "s", "i", "e", "n" };
        String[] kersentaart = new string[] { "k", "e", "r", "s", "e", "n", "t", "a", "a","r","t"}; //altijd in kleine letters woorden toevoegen GEEN SPELFOUTEN
        String[] inhoudtext = new string[100];

        int woordnr;
        int score; //houd bij hoeveel letters van het woord dat je al hebt (omgekeerd  start van bv 9 en gaat naar 0) 
        int strike = 0; //Kijkt hoeveel fouten je hebt gemaakt, bij 10 is het game over.



        //woordnr dient zodat we weten welk woord je moet zoeken in de var woorden.
        private void frmGalgje_Load(object sender, EventArgs e)
        {
            woordnr = galgjeRandom.Next(0, woorden.Length); //kiest een random woord
            score = woorden[woordnr].Length;

            for (int tel = 0; tel < woorden[woordnr].Length; tel++) 
            {
                inhoudtext[tel] = "*";
                lblWoorden.Text += "*";
            }
        }


        //checkt of de letter in het woord zit.
        public static bool isInWoord(String letter, String[] woord) 
        {
            bool check = false;
            for (int tel = 0; tel < woord.Length; tel++) 
            {
                if (woord[tel] == letter) 
                {
                    check = true;
                }
            }
            return check;
        }

        public static int hoeveelKeer(String letter, String[] woord)
        {
            int hvl = 0;
            for (int tel = 0; tel < woord.Length; tel++)
            {
                if (woord[tel] == letter)
                {
                    hvl += 1;
                }
            }
            return hvl;
        }

        public static string[] positie(String letter, String[] woord, String[] posities)
        {
            String[] pos = new string[100];
            for (int tel = 0; tel < woord.Length; tel++)
            {
                if (woord[tel] == letter)
                {
                    pos[tel] = letter;
                }
                else 
                {
                    if (posities[tel] == "*") //checkt of het teken in de orginele een teken was of een letter
                    {
                        pos[tel] = "*";
                    }
                    else 
                    {
                        pos[tel] = posities[tel];
                    }
                }
            }
            return pos;
        }

        public void buttonHide()
        {
            btnA.Hide();
            btnB.Hide();
            btnC.Hide();
            btnD.Hide();
            btnE.Hide();
            btnF.Hide();
            btnG.Hide();
            btnH.Hide();
            btnI.Hide();
            btnJ.Hide();
            btnK.Hide();
            btnL.Hide();
            btnM.Hide();
            btnN.Hide();
            btnO.Hide();
            btnP.Hide();
            btnQ.Hide();
            btnR.Hide();
            btnS.Hide();
            btnT.Hide();
            btnU.Hide();
            btnV.Hide();
            btnW.Hide();
            btnX.Hide();
            btnY.Hide();
            btnZ.Hide();
            lblWoorden.Hide(); //voor het woord te verstoppen
        }

        public void gameOver()
        {
            timerGameOverAnimatie.Enabled = true;
            buttonHide();
        }

        public void achtergrond(int i) 
        {
            switch (i) 
            {
                case 1: this.BackgroundImage = Properties.Resources.Strike1; break;
                case 2: this.BackgroundImage = Properties.Resources.Strike2; break;
                case 3: this.BackgroundImage = Properties.Resources.Strike3; break;
                case 4: this.BackgroundImage = Properties.Resources.Strike4; break;
                case 5: this.BackgroundImage = Properties.Resources.Strike5; break;
                case 6: this.BackgroundImage = Properties.Resources.Strike6; break;
                case 7: this.BackgroundImage = Properties.Resources.Strike7; break;
                case 8: this.BackgroundImage = Properties.Resources.Strike8; break;
                case 9: this.BackgroundImage = Properties.Resources.Strike9; break;
                case 10: this.BackgroundImage = Properties.Resources.Strike10; gameOver(); break; //zie lijn 1088
                default: break;
            }
        }

        public void checkScore() //kijkt of je hebt gewonnen
        {
            if (score == 0)
            {
                buttonHide();
                this.BackgroundImage = Properties.Resources.placeHolderProject2Win;//tijdelijke placeholder
                timerWinEnd.Enabled = true; //zoke hoedat je een geluidseffect kan afspelen
                //toont dat je hebt gewonnen
            }
        }

        //COPY PASTE TIMMMEEEEEE (ik heb het gemaakt zodat je alleen de button naam en de String letter moet veranderen in ieder deel va nde code)
        private void btnA_Click(object sender, EventArgs e)
        {
            clickA();
        }

        public void clickA()
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "a";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnA.BackColor = Color.Green;
                btnA.BackgroundImage = null;
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnA.BackgroundImage = null;
                btnA.BackColor = Color.Green;
            }


            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnA.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            clickB();
        }

        public void clickB()
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "b";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnB.BackColor = Color.Green;
                btnB.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnB.BackgroundImage = null;
                btnB.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnB.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            clickC();
        }

        public void clickC() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "c";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnC.BackColor = Color.Green;
                btnC.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnC.BackgroundImage = null;
                btnC.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnC.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            clickD();
        }

        public void clickD() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "d";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnD.BackColor = Color.Green;
                btnD.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnD.BackgroundImage = null;
                btnD.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            clickE(); 
        }

        public void clickE() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "e";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnE.BackColor = Color.Green;
                btnE.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnE.BackgroundImage = null;
                btnE.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnE.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            clickF();   
        }

        public void clickF() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "f";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnF.BackColor = Color.Green;
                btnF.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnF.BackgroundImage = null;
                btnF.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnF.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            clickG();
        }

        public void clickG() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "g";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnG.BackColor = Color.Green;
                btnG.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnG.BackgroundImage = null;
                btnG.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnG.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            clickH();
        }

        public void clickH() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "h";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnH.BackColor = Color.Green;
                btnH.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnH.BackgroundImage = null;
                btnH.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnH.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            clickI(); 
        }

        public void clickI() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "i";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnI.BackColor = Color.Green;
                btnI.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnI.BackgroundImage = null;
                btnI.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnI.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            clickJ();
        }

        public void clickJ() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "j";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnJ.BackColor = Color.Green;
                btnJ.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnJ.BackgroundImage = null;
                btnJ.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            clickK();
        }

        public void clickK() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "k";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnK.BackColor = Color.Green;
                btnK.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnK.BackgroundImage = null;
                btnK.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnK.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            clickK();
        }

        public void clickL() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "l";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnL.BackColor = Color.Green;
                btnL.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnL.BackgroundImage = null;
                btnL.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnL.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            clickM();
        }

        public void clickM() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "m";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnM.BackColor = Color.Green;
                btnM.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnM.BackgroundImage = null;
                btnM.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnM.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            clickN();
        }

        public void clickN() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "n";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnN.BackColor = Color.Green;
                btnN.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnN.BackgroundImage = null;
                btnN.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnN.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            clickO();
        }

        public void clickO() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "o";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnO.BackColor = Color.Green;
                btnO.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnO.BackgroundImage = null;
                btnO.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnO.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            clickP();
        }

        public void clickP() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "p";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnP.BackColor = Color.Green;
                btnP.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnP.BackgroundImage = null;
                btnP.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnP.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            clickQ();
        }

        public void clickQ() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "q";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnQ.BackColor = Color.Green;
                btnQ.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnQ.BackgroundImage = null;
                btnQ.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnQ.Enabled = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            clickR();
        }

        public void clickR() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "r";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnR.BackColor = Color.Green;
                btnR.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnR.BackgroundImage = null;
                btnR.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnR.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            clickS();
        }

        public void clickS() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "s";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnS.BackColor = Color.Green;
                btnS.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnS.BackgroundImage = null;
                btnS.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            clickT();
        }

        public void clickT() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "t";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnT.BackColor = Color.Green;
                btnT.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnT.BackgroundImage = null;
                btnT.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnT.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            clickU();
        }

        public void clickU() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "u";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnU.BackColor = Color.Green;
                btnU.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();

            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnU.BackgroundImage = null;
                btnU.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnU.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            clickV();
        }

        public void clickV() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "v";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnV.BackColor = Color.Green;
                btnV.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnV.BackgroundImage = null;
                btnV.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnV.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            clickW();
        }

        public void clickW() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "w";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnW.BackColor = Color.Green;
                btnW.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnW.BackgroundImage = null;
                btnW.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnW.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            clickX();
        }

        public void clickX() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "x";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnX.BackColor = Color.Green;
                btnX.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnX.BackgroundImage = null;
                btnX.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnX.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            clickY();
        }

        public void clickY() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "y";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnY.BackColor = Color.Green;
                btnY.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnY.BackgroundImage = null;
                btnY.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnY.Enabled = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            clickZ();
        }

        public void clickZ() 
        {
            lblWoorden.Text = ""; //maakt de tekst leeg voor nieuwe tekst
            bool ok = false;
            int hoeveel = 0;
            String letter = "z";
            switch (woordnr)
            {
                case 0: ok = isInWoord(letter, appelsien); hoeveel = hoeveelKeer(letter, appelsien); inhoudtext = positie(letter, appelsien, inhoudtext); break;
                case 1: ok = isInWoord(letter, kersentaart); hoeveel = hoeveelKeer(letter, kersentaart); inhoudtext = positie(letter, kersentaart, inhoudtext); break;
                default: break;
            }

            for (int tel = 0; tel < woorden[woordnr].Length; tel++)
            {
                lblWoorden.Text += inhoudtext[tel];
            }

            if (ok) //maakt knop groen
            {
                score -= hoeveel;
                btnZ.BackColor = Color.Green;
                btnZ.BackgroundImage = null; // verander later background naar coole tekening
                checkScore();
            }
            else //maakt knop rood en verandert achtergrond
            {
                strike += 1;
                achtergrond(strike);
                btnZ.BackgroundImage = null;
                btnZ.BackColor = Color.Red;
            }

            MessageBox.Show(strike + " " + score); //voor bugfixing delete later
            btnZ.Enabled = false;
        }

        int tel = 0;
        private void TimerGameOverAnimatie_Tick(object sender, EventArgs e)
        {
            tel++;
            if (tel == 1)
            {
                MessageBox.Show("gameOver");
            }
            else if (tel == 2)
            {
                sluiten(); // gebeurt na de animatie
                timerGameOverAnimatie.Enabled = false; //gebeurt na de animatie 
            }
        }

        public void sluiten()
        {
            this.Close(); //eventuele aanpassing      
        }

        private void TimerWinEnd_Tick(object sender, EventArgs e)
        {
            sluiten();
            timerWinEnd.Enabled = false;
        }

        private void TxtHidden_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkedKeyboard)
            {
                if (e.KeyValue == (char)Keys.A)
                {
                    clickA();
                }
                else if (e.KeyValue == (char)Keys.B)
                {
                    clickB();
                }
                else if (e.KeyValue == (char)Keys.C)
                {
                    clickC();
                }
                else if (e.KeyValue == (char)Keys.E)
                {
                    clickE();
                }
                else if (e.KeyValue == (char)Keys.D)
                {
                    clickD();
                }
                else if (e.KeyValue == (char)Keys.F)
                {
                    clickF();
                }
                else if (e.KeyValue == (char)Keys.G)
                {
                    clickG();
                }
                else if (e.KeyValue == (char)Keys.H)
                {
                    clickH();
                }
                else if (e.KeyValue == (char)Keys.I)
                {
                    clickI();
                }
                else if (e.KeyValue == (char)Keys.J)
                {
                    clickJ();
                }
                else if (e.KeyValue == (char)Keys.K)
                {
                    clickK();
                }
                else if (e.KeyValue == (char)Keys.L)
                {
                    clickL();
                }
                else if (e.KeyValue == (char)Keys.M)
                {
                    clickM();
                }
                else if (e.KeyValue == (char)Keys.N)
                {
                    clickN();
                }
                else if (e.KeyValue == (char)Keys.O)
                {
                    clickO();
                }
                else if (e.KeyValue == (char)Keys.P)
                {
                    clickP();
                }
                else if (e.KeyValue == (char)Keys.Q)
                {
                    clickQ();
                }
                else if (e.KeyValue == (char)Keys.R)
                {
                    clickR();
                }
                else if (e.KeyValue == (char)Keys.S)
                {
                    clickS();
                }
                else if (e.KeyValue == (char)Keys.T)
                {
                    clickT();
                }
                else if (e.KeyValue == (char)Keys.U)
                {
                    clickU();
                }
                else if (e.KeyValue == (char)Keys.V)
                {
                    clickV();
                }
                else if (e.KeyValue == (char)Keys.W)
                {
                    clickW();
                }
                else if (e.KeyValue == (char)Keys.X)
                {
                    clickX();
                }
                else if (e.KeyValue == (char)Keys.Y)
                {
                    clickY();
                }
                else if (e.KeyValue == (char)Keys.Z)
                {
                    clickZ();
                }
            }
        }

        Boolean checkedKeyboard = false;
        private void CheckBoxKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkedKeyboard)
            {
                txtHidden.Focus();
                checkedKeyboard = true;
            }
            else
            {
                checkedKeyboard = false;
                //verder werken (door de foutcontrole werkt het niet echt)
            }
        }

        private void txtHidden_Leave(object sender, EventArgs e)
        {
            txtHidden.Update();
            txtHidden.Focus();
        }
    }
}
