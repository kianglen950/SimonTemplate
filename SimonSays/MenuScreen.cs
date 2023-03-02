using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
    SoundPlayer menuSound = new SoundPlayer(Properties.Resources._01___Title_Screen);
        public MenuScreen()
        {
            InitializeComponent();
            menuSound.Play();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            Form1.ChangeScreen(this, new GameScreen());
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();
        }
    }
}
