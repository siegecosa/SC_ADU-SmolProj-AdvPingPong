using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElarcosaPingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();
            
        }
        int start = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            player.Location = new Point(100, 250);
            enemy.Location = new Point(this.Width-100, 250);
            ball.Location = new Point(390, 290);

            scoreblue.Location = new Point(300, 100);
            scorered.Location = new Point(this.Width - 300, 100);

            label1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Player
            if (playerDir.Equals("up"))         { player.Location = new Point(player.Location.X, player.Location.Y-10);}
            else if (playerDir.Equals("down"))  { player.Location = new Point(player.Location.X, player.Location.Y + 10);}

            //Enemy
            if (enemyDir.Equals("up"))          { enemy.Location = new Point(enemy.Location.X, enemy.Location.Y - 10);}
            else if (enemyDir.Equals("down"))   { enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + 10);}
        }


        String playerDir = "";
        String enemyDir = "";
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Player
            if (e.KeyCode.ToString().Equals("W"))       { playerDir = "up";}
            else if (e.KeyCode.ToString().Equals("S"))  { playerDir = "down";}

            //Enemy
            if (e.KeyCode.ToString().Equals("O"))       { enemyDir = "up";}
            else if (e.KeyCode.ToString().Equals("L"))  { enemyDir = "down";}


            if(player.Location.Y <= 0) {player.Location = new Point(player.Location.X, 10);}
            if (player.Location.Y + player.Height >= this.Height) 
            { player.Location = new Point(player.Location.X, this.Height -100); }

            if (enemy.Location.Y <= 0) { enemy.Location = new Point(enemy.Location.X, 10); }
            if (enemy.Location.Y + enemy.Height >= this.Height)
            { enemy.Location = new Point(enemy.Location.X, this.Height - 100); }

            if (e.KeyCode.ToString().Equals("P"))
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;

                panel1.Visible = true;
                exit.Enabled = true;
                resume.Enabled = true;

                timerball.Enabled = false;

                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString().Equals("W")) || (e.KeyCode.ToString().Equals("S")))   { playerDir = "";}
            if ((e.KeyCode.ToString().Equals("O")) || (e.KeyCode.ToString().Equals("L")))   { enemyDir = "";}
        }

        int xDir = 10;
        int yDir = 10;
        private void timerball_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + xDir, ball.Location.Y + yDir);

            //VERTICAL
            if (ball.Location.Y <= 0)                               { yDir = 10;}
            else if (ball.Location.Y + ball.Height >= this.Height)  { yDir = -10;}

            //HORIZONTAL
            if (ball.Location.X <= 0)
            {
                ball.Location = new Point(390, 290);
                xDir = 10;
                int score = Int32.Parse(scorered.Text);
                score++; scorered.Text = score + "";
            }
            else if (ball.Location.X + ball.Width >= this.Width)
            {
                ball.Location = new Point(390, 290);
                xDir = -10;
                int score = Int32.Parse(scoreblue.Text);
                score++; scoreblue.Text = score + "";
            }


            //BALL BOUNCE TO PLAYER/ENEMY
            if (player.Location.X + player.Width >= ball.Location.X)
            {

                if (ball.Location.X + ball.Width < player.Location.X)
                {
                    xDir = -10;
                }
                else if(((ball.Location.Y + ball.Height >= player.Location.Y)
                    & (ball.Location.Y + ball.Height <= player.Location.Y + player.Height))
                    ||
                    ((ball.Location.Y + ball.Height >= player.Location.Y + player.Height)
                    & (ball.Location.Y <= player.Location.Y + player.Height)))
                {
                    xDir = 10;
                }
                
            }


            if (ball.Location.X + ball.Width > enemy.Location.X + enemy.Width)
            {
                xDir = 10;
            }
            if (ball.Location.X + ball.Width >= enemy.Location.X)
            {
                if (((ball.Location.Y + ball.Height >= enemy.Location.Y)
                    & (ball.Location.Y + ball.Height <= enemy.Location.Y + enemy.Height))
                    ||
                    ((ball.Location.Y + ball.Height >= enemy.Location.Y + enemy.Height)
                    & (ball.Location.Y <= enemy.Location.Y + enemy.Height)))
                {
                    xDir = -10;
                }
            }
        }

        private void timerai_Tick(object sender, EventArgs e)
        {
            if(ball.Location.Y + (ball.Height/2) >= enemy.Location.Y + (enemy.Height / 2))
            {
                enemyDir = "down";
            }
            else if (ball.Location.Y + (ball.Height / 2) <= enemy.Location.Y + (enemy.Height / 2))
            {
                enemyDir = "up";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "GAMEMODE: PLAYER VS PLAYER";
            label3.Visible = true;
            if (timerai.Enabled = true)
            {
                timerai.Enabled = false;
                enemyDir = "";
                player.Location = new Point(100, 250);
                enemy.Location = new Point(this.Width - 100, 250);
                ball.Location = new Point(390, 290);
                playervsplayer.Enabled = false;
                label1.Visible = true;
                label2.Visible = false;
                panel1.Visible = false;

                //Undo Button
                this.Focus();
                ((Button)sender).Enabled = false;

                playervsai.Enabled = true;
                exit.Enabled = true;
                resume.Enabled = true;

                timerball.Enabled = true;

                start = 1;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            panel1.Visible = false;

            if (start == 1)
            {
                timerball.Enabled = true;
            }
            else if (start == 2)
            {
                timerball.Enabled = true;
                timerai.Enabled = true;
            }

            this.Focus();
            ((Button)sender).Enabled = false;
        }

        private void playervsai_Click(object sender, EventArgs e)
        {
            label3.Text = "GAMEMODE: PLAYER VS AI";
            label3.Visible = true;
            player.Location = new Point(100, 250);
            enemy.Location = new Point(this.Width - 100, 250);
            ball.Location = new Point(390, 290);

            playervsai.Enabled = false;
            label1.Visible = true;
            label2.Visible = false;
            panel1.Visible = false;

            //Undo Button
            this.Focus();
            ((Button)sender).Enabled = false;
            playervsplayer.Enabled = true;
            
            exit.Enabled = true;
            resume.Enabled = true;

            timerball.Enabled = true;
            timerai.Enabled = true;

            start = 2;
        }
    }
}
