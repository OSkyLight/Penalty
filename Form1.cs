using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penalty
{
    public enum direction
    {
        standby = 0,
        num1 = 1,
        num2 = 2,
        num3 = 3,
        num4 = 4,
        num5 = 5,
        num6 = 6,
        num7 = 7,
        num8 = 8,
        num9 = 9
    };
    
    public partial class Form1 : Form
    {
        Bitmap backBuffer;
        Bitmap backGround;
        Bitmap ballS;
        Bitmap power;
        Bitmap replay;
        Graphics graphics;
        AnimSprite ball;
        Value var;
        int ellasped = 0;
        Random rnd;
        int intRandom;
        int score = 0;
        int unScore = 0;
        int numP = 1;

        void scoreBoardN()
        {
            if (score == 0 && unScore == 0)
            {
                MessageBox.Show("No Goal!!! \n0-0");
            }
            else if (score == 1 && unScore ==0)
            {
                MessageBox.Show("No Goal!!! \n1-0");
            }
            else if (score == 2 && unScore == 0)
            {
                MessageBox.Show("No Goal!!! \n2-0");
            }
            else if (score == 3 && unScore ==0)
            {
                MessageBox.Show("No Goal!!! \n3-0");
            }
            else if (score == 4 && unScore == 0)
            {
                MessageBox.Show("No Goal!!! \n4-0");
            }
            else if (score == 5 && unScore == 0)
            {
                MessageBox.Show("No Goal!!! \n5-0");
            }
            else if (score == 0 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n0-1");
            }
            else if (score == 0 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n0-2");
            }
            else if (score == 0 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n0-3");
            }
            else if (score == 0 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n0-4");
            }
            else if (score == 0 && unScore == 5)
            {
                MessageBox.Show("No Goal!!! \n0-5");
            }
            else if (score == 1 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n1-1");
            }
            else if (score == 1 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n1-2");
            }
            else if (score == 1 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n1-3");
            }
            else if (score == 1 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n1-4");
            }
            else if (score == 1 && unScore == 5)
            {
                MessageBox.Show("No Goal!!! \n1-5");
            }
            else if (score == 2 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n2-1");
            }
            else if (score == 2 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n2-2");
            }
            else if (score == 2 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n2-3");
            }
            else if (score == 2 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n2-4");
            }
            else if (score == 2 && unScore ==5 )
            {
                MessageBox.Show("No Goal!!! \n2-5");
            }
            else if (score == 3 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n3-1");
            }
            else if (score == 3 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n2-4");
            }
            else if (score == 3 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n3-3");
            }
            else if (score == 3 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n3-4");
            }
            else if (score == 3 && unScore == 5)
            {
                MessageBox.Show("No Goal!!! \n3-5");
            }
            else if (score == 4 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n4-1");
            }
            else if (score == 4 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n4-2");
            }
            else if (score == 4 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n4-3");
            }
            else if (score == 4 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n4-4");
            }
            else if (score == 4 && unScore == 5)
            {
                MessageBox.Show("No Goal!!! \n4-5");
            }
            else if (score == 5 && unScore == 1)
            {
                MessageBox.Show("No Goal!!! \n5-1");
            }
            else if (score == 5 && unScore == 2)
            {
                MessageBox.Show("No Goal!!! \n5-2");
            }
            else if (score == 5 && unScore == 3)
            {
                MessageBox.Show("No Goal!!! \n5-3");
            }
            else if (score == 5 && unScore == 4)
            {
                MessageBox.Show("No Goal!!! \n5-4");
            }
        }

        void scoreBoardY()
        {
            if (score == 0 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n0-0");
            }
            else if (score == 1 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n1-0");
            }
            else if (score == 2 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n2-0");
            }
            else if (score == 3 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n3-0");
            }
            else if (score == 4 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n4-0");
            }
            else if (score == 5 && unScore == 0)
            {
                MessageBox.Show("Goal!!! \n5-0");
            }
            else if (score == 0 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n0-1");
            }
            else if (score == 0 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n0-2");
            }
            else if (score == 0 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n0-3");
            }
            else if (score == 0 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n0-4");
            }
            else if (score == 0 && unScore == 5)
            {
                MessageBox.Show("Goal!!! \n0-5");
            }
            else if (score == 1 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n1-1");
            }
            else if (score == 1 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n1-2");
            }
            else if (score == 1 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n1-3");
            }
            else if (score == 1 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n1-4");
            }
            else if (score == 1 && unScore == 5)
            {
                MessageBox.Show("Goal!!! \n1-5");
            }
            else if (score == 2 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n2-1");
            }
            else if (score == 2 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n2-2");
            }
            else if (score == 2 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n2-3");
            }
            else if (score == 2 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n2-4");
            }
            else if (score == 2 && unScore == 5)
            {
                MessageBox.Show("Goal!!! \n2-5");
            }
            else if (score == 3 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n3-1");
            }
            else if (score == 3 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n2-4");
            }
            else if (score == 3 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n3-3");
            }
            else if (score == 3 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n3-4");
            }
            else if (score == 3 && unScore == 5)
            {
                MessageBox.Show("Goal!!! \n3-5");
            }
            else if (score == 4 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n4-1");
            }
            else if (score == 4 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n4-2");
            }
            else if (score == 4 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n4-3");
            }
            else if (score == 4 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n4-4");
            }
            else if (score == 4 && unScore == 5)
            {
                MessageBox.Show("Goal!!! \n4-5");
            }
            else if (score == 5 && unScore == 1)
            {
                MessageBox.Show("Goal!!! \n5-1");
            }
            else if (score == 5 && unScore == 2)
            {
                MessageBox.Show("Goal!!! \n5-2");
            }
            else if (score == 5 && unScore == 3)
            {
                MessageBox.Show("Goal!!! \n5-3");
            }
            else if (score == 5 && unScore == 4)
            {
                MessageBox.Show("Goal!!! \n5-4");
            }
        }

        void drawMenu()
        {
            timer1.Stop();
            graphics.DrawImage(GameResources.football_penalty_stadium_742350, 0, 0, this.Width, this.Height);
            graphics.DrawImage(GameResources.playbutton__1_, 245, 80, 160, 100);
            graphics.DrawImage(GameResources.Help, 245, 170, 160, 100);
            graphics.DrawImage(GameResources.penalty, 190, 290, 410, 83);
        }

        void gkFly()
        {
                ellasped += timer1.Interval;
                if (intRandom == 1)
                {
                    graphics.DrawImage(GameResources.LeftDown_Pre_, 200, 140, 240, 240);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.LefDown_Complete_, 80, 220, 250, 130);
                    }
                }
                if (intRandom == 2)
                {
                    graphics.DrawImage(GameResources.LeftDown_Pre_, 200, 130, 240, 240);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.LefDown_Complete_, 80, 150, 250, 130);
                    }
                }
                if (intRandom == 3)
                {
                    graphics.DrawImage(GameResources.LeftDown_Pre_, 200, 130, 240, 240);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.Left_Up_Complete_, 70, 180, 250, 150);
                    }
                }
                if (intRandom == 4)
                {
                    graphics.DrawImage(GameResources.RightDown_Pre_, 250, 180, 180, 180);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.RightDown_Complete_, 320, 250, 250, 110);
                    }
                }
                if (intRandom == 5)
                {
                    graphics.DrawImage(GameResources.RightDown_Pre_, 250, 165, 180, 180);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.RightDown_Complete_, 320, 170, 250, 110);
                    }
                }
                if (intRandom == 6)
                {
                    graphics.DrawImage(GameResources.RightDown_Pre_, 270, 165, 180, 180);
                    if (ellasped >= 100)
                    {
                        graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                        graphics.DrawImage(GameResources.RightUp_Complete_, 380, 160, 180, 180);
                    }
                }
                if (intRandom == 7)
                {
                    if (var.intDr == 2)
                    {
                        graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
                        if (ellasped >= 100)
                        {
                            graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                            graphics.DrawImage(GameResources.Down, 210, 190, 170, 170);
                        }
                    }
                    else if (var.intDr == 5)
                    {
                        graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
                        if (ellasped >= 100)
                        {
                            graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                            graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
                        }
                    }
                    else if (var.intDr == 8)
                    {
                        graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
                        if (ellasped >= 100)
                        {
                            graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                            graphics.DrawImage(GameResources.Up, 220, 190, 150, 180);
                        }
                    }
                    else
                    {
                        graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
                    }
                }
             }

        void checkGoal()
        {
            if (intRandom == 1 && var.intDr == 1)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 2 && var.intDr == 4)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 3 && var.intDr == 7)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 4 && var.intDr == 3)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 5 && var.intDr == 6)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 6 && var.intDr == 9)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 7 && var.intDr == 2)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 7 && var.intDr == 5)
            {
                unScore++;
                scoreBoardN();
            }
            else if (intRandom == 7 && var.intDr == 8)
            {
                unScore++;
                scoreBoardN();
            }
            else
            {
                score++;
                scoreBoardY();
            }
                drawBasic();
                var.intDr = 0;
                x = 290;
                y = 380;
                intRandom = rnd.Next(1, 8);
                timer1.Start();
        }
        
        public Form1()
        {
            InitializeComponent();
            backBuffer = new Bitmap(this.Width, this.Height);
            backGround = new Bitmap(GameResources.goal_ani);
            ballS = new Bitmap(GameResources.BallS);
            power = new Bitmap(GameResources.Power_ani);
            
            this.DoubleBuffered = true;
            this.BackgroundImage = backBuffer;
            graphics = Graphics.FromImage(backBuffer);
            drawBasic();
            drawMenu();
            ball = new AnimSprite(45, 45, 0, 0, 45, 45, GameResources.ball_ani);
            ball.offsetX = 0;
            ball.offsetY = 0;
            ball.totalNoOfFrame = 8;
            var = new Value();
            rnd = new Random();
            intRandom = rnd.Next(1, 8);
           
        }

        private void drawBasic()
        {
            graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
            graphics.DrawImage(GameResources.BallS, 290, 380, 45, 45);
            graphics.DrawImage(GameResources.Stand_1, 260, 180, 130, 170);
        }
        int x = 290, y = 380;
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (var.intDr == 1)
                {
                    graphics.Clear(Color.AliceBlue);
                    x -= 10;
                    y -= 4;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 80 && y == 380 - (4 * 21))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 2)
                {
                    graphics.Clear(Color.AliceBlue);
                    x -= 0;
                    y -= 5;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 && y == 290)
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 3)
                {
                    graphics.Clear(Color.AliceBlue);
                    x += 10;
                    y -= 4;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 + 210 && y == 380 - (4 * 21))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 4)
                {
                    graphics.Clear(Color.AliceBlue);
                    x -= 10;
                    y -= 7;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 80 && y == 380 - (7 * 21))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 5)
                {
                    graphics.Clear(Color.AliceBlue);
                    x -= 0;
                    y -= 5;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 && y == 250)
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 6)
                {
                    graphics.Clear(Color.AliceBlue);
                    x += 10;
                    y -= 7;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 + 210 && y == 380 - (7 * 21))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 7)
                {
                    graphics.Clear(Color.AliceBlue);
                    x -= 10;
                    y -= 10;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 - 220 && y == 380 - (10 * 22))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 8)
                {
                    graphics.Clear(Color.AliceBlue);
                    x += 0;
                    y -= 5;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 && y == 180)
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                else if (var.intDr == 9)
                {
                    graphics.Clear(Color.AliceBlue);
                    x += 10;
                    y -= 10;
                    Rectangle destRect = new Rectangle(x, y, 50, 50);
                    graphics.DrawImage(GameResources.goal_ani, 0, 0, this.Width, this.Height);
                    gkFly();
                    ball.draw(graphics, timer1.Interval, destRect);
                    if (x == 290 + 220  && y == 380 - (10* 22))
                    {
                        timer1.Stop();
                        checkGoal();
                        numP++;
                    }
                }
                if (numP == 10)
                {
                    drawMenu();
                    numP = 1;
                }
                if (score == 5)
                {
                    drawMenu();
                    score = 0;
                    unScore = 0;
                    numP = 1;
                    MessageBox.Show("You win");
                }
                if (unScore == 5)
                {
                    drawMenu();
                    unScore = 0;
                    score = 0;
                    numP = 1;
                    MessageBox.Show("You lose");
                }

                
                this.Refresh();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (var.intDr == 0)
            {
                if (e.KeyCode == Keys.NumPad1)
                {
                    var.intDr = (int)direction.num1;
                    timer1.Start();
                }
                else if (e.KeyCode == Keys.NumPad2)
                {
                    var.intDr = (int)direction.num2;
                }
                else if (e.KeyCode == Keys.NumPad3)
                {
                    var.intDr = (int)direction.num3;
                }
                else if (e.KeyCode == Keys.NumPad4)
                {
                    var.intDr = (int)direction.num4;
                }
                else if (e.KeyCode == Keys.NumPad5)
                {
                    var.intDr = (int)direction.num5;
                }
                else if (e.KeyCode == Keys.NumPad6)
                {
                    var.intDr = (int)direction.num6;
                }
                else if (e.KeyCode == Keys.NumPad7)
                {
                    var.intDr = (int)direction.num7;
                }
                else if (e.KeyCode == Keys.NumPad8)
                {
                    var.intDr = (int)direction.num8;
                }
                else if (e.KeyCode == Keys.NumPad9)
                {
                    var.intDr = (int)direction.num9;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= 245 && e.X <=405  && e.Y >= 80   && e.Y <=180 )
            {
                timer1.Start();
                numP = 1;
                drawBasic();
            }
            if (e.X >= 245 && e.X < 405 && e.Y >= 170 && e.Y <= 270)
            {
                MessageBox.Show("HELP: \n You will have 9 turn to shoot.\n If you have 5 goal, you win.\n If the goal keeper catch 5 shoot, you lose\n Socre board is: Your score - GK score\nYou press keys on your Keyboard's Numpad to chose your shoot direction");
            }
        }



        
    }
}
