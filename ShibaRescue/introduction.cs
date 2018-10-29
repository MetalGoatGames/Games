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
        int shibaCounter = 0;
        int len = 0;
        string txt;

        public introduction()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblStoryScroll.Location);
            //  label in the text to be transparent
            pos = msgBox.PointToClient(pos);
            lblStoryScroll.Parent = msgBox;
            lblStoryScroll.Location = pos;
            lblStoryScroll.BackColor = Color.Transparent;
            // button to be transparent
            this.btnNext.MouseHover += (s, e) =>
            {
                this.btnNext.BackColor = Color.DeepSkyBlue;
            };

        }

        public void playIntroSound()
        {
            var music = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\Monplaisir.wav");
            music.PlayLooping();
        }

        public void playTextSound()
        {
          //  var textSound = new System.Media.SoundPlayer("C:\\Users\\Sarah\\Desktop\\shibaRescueImages\\homemade_bleep.wav");
          //  textSound.PlayLooping();
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
            //var textSound = new System.Media.SoundPlayer("C:\\Users\\Sarah\\Desktop\\shibaRescueImages\\homemade_bleep.wav");
            //textSound.Stop();
        }

        private void introduction_Load(object sender, EventArgs e)
        {
            string characterChoice = choosePlayer.characterChoice;
            playTextSound();
            label1.Hide();
            label1.BackColor = Color.Transparent;
            playIntroSound();
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
                switch (shibaCounter)
                {
                    case 1:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_1;
                        break;
                    case 5:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_2;
                        break;
                    case 10:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_3;
                        break;
                    case 15:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_4;
                        break;
                    case 20:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_5;
                        break;
                    case 25:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_6;
                        break;
                    case 30:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_7;
                        break;
                    case 35:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_8;
                        break;
                    case 40:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_9;
                        break;
                    case 45:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_10;
                        break;
                    case 50:
                        this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen_01_11;
                        break;
                }
                        shibaCounter++;
                }

        }

        int storycounter = 0;


        public void btnNext_Click(object sender, EventArgs e)
        {
            storycounter++;
            txt = lblStoryScroll.Text;
            switch (storycounter)
            {
                case 1:
                    this.BackgroundImage = ShibaRescue.Properties.Resources.introduction_screen;
                    txt = "And so, it was for many ages the shibas lived day in day out being at one with the surrounding world...";
                    timer1.Start();
                    playTextSound();
                    break;
                case 2:
                    msgBox.Hide();
                    lblStoryScroll.ForeColor = System.Drawing.Color.Red;
                    label1.Show();
                    break;
                case 3:
                    choosePlayer chooseplayer = new choosePlayer();
                    chooseplayer.Show();
                    this.Hide();
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


