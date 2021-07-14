using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int brzinaCevi = 8;
        int gravitacija =  5;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            ptica.Top += gravitacija;       // pomera pticu gore dole kada se pritisne taster
            cevGornja.Left -= brzinaCevi;
            donjaCev.Left -= brzinaCevi;
            rezultat.Text = "Score: " + score;

            if(cevGornja.Left < -50)
            {
                cevGornja.Left = 800;
                score++;
            }

            if (donjaCev.Left < -50)
            {
                donjaCev.Left = 950;
                score++;

            }

            if ((ptica.Bounds.IntersectsWith(cevGornja.Bounds)) ||
                (ptica.Bounds.IntersectsWith(donjaCev.Bounds)) ||
                (ptica.Bounds.IntersectsWith(trava.Bounds)))
            {
                endGame();
            }

            if(score >= 5)
            {
                brzinaCevi += 10;
            }

            if (ptica.Top <= -15) endGame();
        }

        private void naDole(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravitacija = 5;
            }
        }

        private void naGore(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitacija = -5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            rezultat.Text = " GAME OVER!!! \n Score: " + score;
        }

        private void rezultat_Click(object sender, EventArgs e)
        {

        }
    }
}
