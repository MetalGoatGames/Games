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
    public partial class screenA : Form
    {
        public static string story;

        public screenA()
        {
            InitializeComponent();
        }

        public void playIntroSound()
        {
            var music = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\symphonymysticaltown.wav");
            music.PlayLooping();
        }

        private void screenA_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            playIntroSound();
            timer1.Start();
            picHouse1.BackColor = Color.Transparent;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            menuScreen menu_screen = new menuScreen();
            menu_screen.Show();
        }

        private void picHouse1_Click(object sender, EventArgs e)
        {
            houseZuza zuzaHome = new houseZuza();
            zuzaHome.Show();
        }

        private void wekesaHomepic_Click(object sender, EventArgs e)
        {
            houseWekesa wekesaHome = new houseWekesa();
            wekesaHome.Show();
        }
    }
}
