using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.EoC_Expert_Roar);
        SoundPlayer endSound = new SoundPlayer(Properties.Resources._44_Moon_Lord);
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private async void GameOverScreen_Load(object sender, EventArgs e)
        {

            //TODO: show the length of the pattern
            int length = Form1.pattern.Count - 1;
            lengthLabel.Text = $"{length}";

            if (length > Form1.highScore)
            {
                Form1.highScore = length;
                highScoreLabel.Text = $"High Score: {Form1.highScore}";
            }
            await Task.Delay(100);
            gameOverSound.Play();
            await Task.Delay(1500);
            gameOverSound.Play();
            await Task.Delay(1500);
            gameOverSound.Play();
            await Task.Delay(150);
            endSound.Play();


        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
