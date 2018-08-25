using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShibaRescue
{

    public partial class introduction : Form
    {

        int counter = 0;
        int len = 0;
        string txt;

        public introduction()
        {
            InitializeComponent();
        }

        public void playTextSound()
        {
            var textSound = new System.Media.SoundPlayer("C:\\Users\\Audio\\radar1.wav");
            textSound.PlayLooping();
        }

        public static string story;

        private void btnScreenA_Click(object sender, EventArgs e)
        {
            screenA screen_A = new screenA();
            screen_A.Show();
            this.Hide();
        }


        public void stopTextSound()
        {
            var textSound = new System.Media.SoundPlayer("C:\\Users\\Audio\\radar1.wav");
            textSound.Stop();
        }

        private void introduction_Load(object sender, EventArgs e)
        {
            string characterChoice = choosePlayer.characterChoice;
            playTextSound();
            txt = lblStoryScroll.Text;
            len = txt.Length;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= len)
            {
                timer1.Enabled = false;
                counter = 0;
                stopTextSound();
            }
            else
            {
                counter++;
                try
                {
                    lblStoryScroll.Text = txt.Substring(0, counter).Trim();
                }
                catch (ArgumentOutOfRangeException)
                {
                    timer1.Stop();
                    stopTextSound();
                }
            }

        }

        int storycounter = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            storycounter++;
            txt = lblStoryScroll.Text;
            switch (storycounter)
            {
                case 1:
                    txt = "And so, it was for many ages the shibas lived day in day out being at one with the surrounding world.  Until one day the shibas awoke to a peculiar smell. It seemed a strange cloud had wafted over the town from the nearby lake. It started like any other day *Unchosen character* awoke and visited the compost pile to see how things were marinating.  That’s when he noticed it.  A smell unlike the usual smell of the waste recycling. A smell that immediately clogged his nose and made his eyes begin to water…..";
                    timer1.Start();
                    playTextSound();
                    break;
                case 2:
                    txt = "That could be the intro for Bombastus or for another character we introduce and kill off.";
                    timer1.Start();
                    playTextSound();
                    break;
                case 3:
                    txt = "The ooze that poured forth from the stygian abyss clung tight to Vulgate Village but previously it had been a place of joy and light.  Shiba Inu after Shiba had lived and loved in Vulgate. Many a compost pile and home were made in the borders of this beautiful land. Maybe one day the village could return to its former greatness.  ";
                    timer1.Start();
                    playTextSound();
                    break;
            }
            counter = 0;
        }

        private void introduction_Close(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}


