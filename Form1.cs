using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneGame
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dvig, lose;
        private int coins = 0;

      
        public Form1()
        {
            InitializeComponent();

            doroga.MouseDown += MouseClickDown;
            doroga.MouseUp += MouseClickUp;
            doroga.MouseMove += MouseClickMove;
            doroga2.MouseDown += MouseClickDown;
            doroga2.MouseUp += MouseClickUp;
            doroga2.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true; 
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dvig = true;
            pos.X = e.X; 
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dvig = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if(dvig)
            {
                Point bobPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point (bobPoint.X - pos.X, bobPoint.Y - pos.Y + doroga.Top);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            doroga.Top += speed;
            doroga2.Top += speed;

            int blaspeed = 7;
            enemy1.Top += blaspeed;
            enemy2.Top += blaspeed;

            coin.Top += speed;

            if (doroga.Top >= 650)
            {
                doroga.Top = 0;
                doroga2.Top = -650;
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);
            }

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 300);
            }

            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                Random rand = new Random();
                enemy2.Left = rand.Next(300, 560);
            }

            if (Player.Bounds.IntersectsWith(enemy1.Bounds)
                || Player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
            }

            if(Player.Bounds.IntersectsWith(coin.Bounds))
            {
                coins++;
                labelCoin.Text = "Монеты: " + coins.ToString();
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 300);
            }
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;

            int speed = 10;

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 50)
                Player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Player.Right < 750)
                Player.Left += speed;

        }

      

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -190;
            enemy2.Top = -400;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            coins = 0;
            labelCoin.Text = "Монеты: 0";
            coin.Top = -500;
        }
    }
}
