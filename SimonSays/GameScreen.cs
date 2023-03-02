using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        int guess;
        Random randNum = new Random();
        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer mistakeSound = new SoundPlayer(Properties.Resources.mistake);
        

        int x = 8;
       

        public GameScreen()
        {
            InitializeComponent();
        }

        private async void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            await Task.Delay(100);
            ComputerTurn();
            //TODO: clear the pattern list from form1
            //TODO: refresh
            //TODO: pause for a bit
            //TODO: run ComputerTurn()
        }

        private async void ComputerTurn()
        {
            await Task.Delay(150);
            int random = randNum.Next(0, 4);

            Form1.pattern.Add(random);

            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                switch (Form1.pattern[i])
                {
                    case 0: //Green
                        greenButton.BackColor = Color.White;
                        await Task.Delay(350);
                        greenButton.BackColor = Color.Green;
                        break;
                    case 1: //red
                        redButton.BackColor = Color.White;
                        await Task.Delay(350);
                        redButton.BackColor = Color.Red;
                        break;
                    case 2: //yellow
                        yellowButton.BackColor = Color.White;
                        await Task.Delay(350);
                        yellowButton.BackColor = Color.Yellow;
                        break;
                    case 3: //blue
                        blueButton.BackColor = Color.White;
                        await Task.Delay(350);
                        blueButton.BackColor = Color.Blue;
                        break;
                }
                await Task.Delay(150);

            }
            guess = 0;
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button

            //TODO: set guess value back to 0
        }

        //TODO: create one of these event methods for each button
        private async void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 0)
            {
                greenButton.BackColor = Color.Lime;
                greenSound.Play();
                Refresh();
                await Task.Delay (350);
                greenButton.BackColor = Color.Green;
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count() == guess)
            {
                ComputerTurn();
            }
            //TODO: is the value in the pattern list at index [guess] equal to a green?
            // change button color
            // play sound
            // refresh
            // pause
            // set button colour back to original
            // add one to the guess variable

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
        }
        private async void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                redButton.BackColor = Color.DarkRed;
                redSound.Play();
                Refresh();
                await Task.Delay(350);
                redButton.BackColor = Color.Red;
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count() == guess)
            {
                ComputerTurn();
            }
        }
        private async void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                yellowButton.BackColor = Color.Gold;
                yellowSound.Play();
                Refresh();
                await Task.Delay (350);
                yellowButton.BackColor = Color.Yellow;
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count() == guess)
            {
                ComputerTurn();
            }
        }
        private async void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                blueButton.BackColor = Color.DarkBlue;
                blueSound.Play();
                Refresh();
                await Task.Delay(350);
                blueButton.BackColor = Color.Blue;
                guess++;
            }            
            else
            {
                GameOver();
            }
            
            if (Form1.pattern.Count() == guess)
            {
                ComputerTurn();
            }

        }

    public async void GameOver()

        { 
           

            Form1.ChangeScreen(this, new GameOverScreen());
            await Task.Delay(150);
        //TODO: Play a game over sound

        //TODO: close this screen and open the GameOverScreen

    }
}
}
