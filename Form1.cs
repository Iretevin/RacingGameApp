using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAPP
{
    public partial class Form1 : Form
    {
        // Delaring variables for the Game to function.

        int RoadSpeed;
        int TrafficSpeed;
        int Score = 0;
        int PlayerSpeed = 10;
        int CarImage;

        // This helps us to get a random car
        Random rand = new Random();

        // This helps us to get The car position so that the game will be Dynamic as we play.
        Random CarPosition = new Random();

        //This boolen Variable will help us to move the car left and right.
        bool goLeft,goRight;    
        public Form1()
        {
            InitializeComponent();

            //Calling the resetGame Method .
            resetGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            // When we press the key left or right we are changing it to true.
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            // When we release the key we changing it to false.

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            lblscore.Text = "Score" + Score;
            Score++;

            if(goLeft == true && player.Left > 48)
            {
                player.Left -= PlayerSpeed;
            }
            if(goRight == true && player.Left < 721)
            {
                player.Left += PlayerSpeed;
            }

            RoadTrack1.Top += RoadSpeed;
            RoadTrack2.Top += RoadSpeed;

            if (RoadTrack2.Top > 320)
            {
                RoadTrack2.Top = -320;
            }

            if (RoadTrack1.Top > 320)
            {
                RoadTrack1.Top = -320;
            }
            A1.Top +=TrafficSpeed;
            A2.Top += TrafficSpeed;

            if(A1.Top > 410)
            {
                // A1.Top = -20;

                changA1Cars(A1);
            }


            if (A2.Top > 410)
            {
                changA1Cars(A2);
            }
            if(player.Bounds.IntersectsWith(A1.Bounds) || player.Bounds.IntersectsWith(A2.Bounds))
            {
                gameOver();
            }
            if(Score >40 && Score > 800)
            {
                Award.Image = Properties.Resources.bronze;
            }

            if (Score > 800 && Score < 3000)
            {
                Award.Image = Properties.Resources.silver;
                TrafficSpeed = 24;
                RoadSpeed = 22;
            }

            if (Score > 3000)
            {
                Award.Image = Properties.Resources.gold;
                TrafficSpeed = 27;
                RoadSpeed = 25;
            }
        }

        //Creating methods or functions to handle each part of the game.

        public void changA1Cars(PictureBox tempCar)
        {

            CarImage = rand.Next(1,18);
            switch (CarImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                   
                    break;


                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    
                    break;


                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    
                    break;


                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                   

                    break;


                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    
                    break;


                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                   
                    break;


                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    
                    break;


                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    
                    break;


                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                   
                    break;

               

                


            }

            tempCar.Top = CarPosition.Next(200, 400) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = CarPosition.Next(31, 390);
            }

            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = CarPosition.Next(431, 738);
            }
        }

        public void gameOver()
        {
            playSound();
            GameTimer.Stop();
            Explosion.Visible = true;

            player.Controls.Add(Explosion);
            Explosion.Location = new Point(-8, 5);
            Explosion.BackColor = Color.Transparent;

            Award.Visible = true;
            Award.BringToFront();
            btnStart.Enabled = true;
        }

        public void resetGame()
        {

            btnStart.Enabled = false;
            Explosion.Visible = false;  
            Award.Visible = false;
            goLeft = false; 
            goRight = false;
            Score = 0;
            Award.Image = Properties.Resources.bronze;
            RoadSpeed = 13;
            TrafficSpeed = 15;

            A1.Top = CarPosition.Next(200, 500) * -1;
            A1.Left = CarPosition.Next(31,390);

            A2.Top = CarPosition.Next(200, 500) * -1;
            A2.Left = CarPosition.Next(431,738);

            GameTimer.Start();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RoadTrack1_Click(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        public void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
    }
}
