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
        public startScreen()
        {
            InitializeComponent();

        }


        public void playStartSound()
        {
            var bleep = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\PixelRiver.wav");
            bleep.Play();
        }


        public void StopStartSound()
        {
            var bleep = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\PixelRiver.wav");
            bleep.Stop();
        }

        public void playStartButtonSound()
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            StopStartSound();
            playStartButtonSound();
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
