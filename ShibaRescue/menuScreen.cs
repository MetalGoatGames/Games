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
    public partial class menuScreen : Form
    {
        public menuScreen()
        {
            InitializeComponent();
        }

        private void menuScreen_Load(object sender, EventArgs e)
        {
            var pos = this.PointToScreen(lblEquipment.Location);
            pos = PointToClient(pos);
            lblEquipment.Location = pos;
            lblEquipment.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(lblItem.Location);
            pos1 = PointToClient(pos1);
            lblItem.Location = pos1;
            lblItem.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(lblMoneyDisplay.Location);
            pos2 = PointToClient(pos2);
            lblMoneyDisplay.Location = pos2;
            lblMoneyDisplay.BackColor = Color.Transparent;


            var pos3 = this.PointToScreen(lblSpecial.Location);
            pos3 = PointToClient(pos3);
            lblSpecial.Location = pos3;
            lblSpecial.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(lblStatus.Location);
            pos4 = PointToClient(pos4);
            lblStatus.Location = pos4;
            lblStatus.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(lbXPDisplay.Location);
            pos5 = PointToClient(pos5);
            lbXPDisplay.Location = pos5;
            lbXPDisplay.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(lbCurrency.Location);
            pos6 = PointToClient(pos6);
            lbCurrency.Location = pos6;
            lbCurrency.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(lbExperience.Location);
            pos7 = PointToClient(pos7);
            lbExperience.Location = pos7;
            lbExperience.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(charcterDisplay.Location);
            pos8 = PointToClient(pos8);
            charcterDisplay.Location = pos8;
            charcterDisplay.BackColor = Color.Transparent;

            if ("Bombastus" == choosePlayer.characterChoice)
            {
                charcterDisplay.Image = ShibaRescue.Properties.Resources.bombastus;
            }
            else
            {
                charcterDisplay.Image = ShibaRescue.Properties.Resources.tellus;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
