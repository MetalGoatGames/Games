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
    public partial class startScreen : Form
    {
        // PixelRiver.wav Copy right goes to Trevor Lentz. Available at: https://opengameart.org/content/pixel-river
        public startScreen()
        {
            InitializeComponent();

        }


        public void playStartSound()
        {
            var bleep = new System.Media.SoundPlayer("Audio\\PixelRiver.wav");
            bleep.Play();
        }


        public void StopStartSound()
        {
            var bleep = new System.Media.SoundPlayer("Audio\\PixelRiver.wav");
            bleep.Stop();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            StopStartSound();
            introduction intro = new introduction();
            intro.Show();
            this.Hide();
            

        }

        private void startScreen_Load(object sender, EventArgs e)
        {
            playStartSound();
        }

        private void startScreen_Close(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
