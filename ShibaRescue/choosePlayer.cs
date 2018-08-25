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
        public choosePlayer()
        {
            InitializeComponent();
        }
        public static string characterChoice;

        private void choosePlayer_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hero... Think twice before choosing your destiny...", "Beware, you don't want them to follow you...");
        }

        private void btnBombastus_Click(object sender, EventArgs e)
        {
            choosePlayer.characterChoice = "Bombastus";
            screenA AScreen = new screenA();
            AScreen.Show();
            this.Hide();
        }

        private void btnTellus_Click(object sender, EventArgs e)
        {
            choosePlayer.characterChoice = "Tellus";
            screenA AScreen = new screenA();
            AScreen.Show();
            this.Close();
        }
    }
}
