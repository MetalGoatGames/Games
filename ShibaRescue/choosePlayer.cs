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

    public partial class choosePlayer : Form
    {
        public static string characterName = "";

        public choosePlayer()
        {
            InitializeComponent();
        }
        public static string characterChoice;

        private void choosePlayer_Load(object sender, EventArgs e)
        {
            playChooseCharacterMusic();
        }

        public void playChooseCharacterMusic()
        {
            var music = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\heroic.wav");
            music.PlayLooping();
        }

        public void stopChooseCharacterMusic()
        {
            var music = new System.Media.SoundPlayer("C:\\Users\\Sarah\\ShibaRescueMedia\\Audio\\heroic.wav");
            music.Stop();
        }


        private void btnBombastus_Click(object sender, EventArgs e)
        {
            choosePlayer.characterChoice = "Bombastus";
            screenA AScreen = new screenA();
            AScreen.Show();
            this.Hide();
            stopChooseCharacterMusic();
        }

        private void btnTellus_Click(object sender, EventArgs e)
        {
            choosePlayer.characterChoice = "Tellus";
            screenA AScreen = new screenA();
            AScreen.Show();
            stopChooseCharacterMusic();
            this.Close();
        }
    }
}
