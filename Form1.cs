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
        private bool dvig;

      
        public Form1()
        {
            InitializeComponent();

            doroga.MouseDown += MouseClickDown;
            doroga.MouseUp += MouseClickUp;
            doroga.MouseMove += MouseClickMove;
            doroga2.MouseDown += MouseClickDown;
            doroga2.MouseUp += MouseClickUp;
            doroga2.MouseMove += MouseClickMove;
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
            int speed = 25;
            doroga.Top += speed;
            doroga2.Top += speed;

            if(doroga.Top >= 650)
            {
                doroga.Top = 0;
                doroga2.Top = -650;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 150)
                Player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Player.Right < 750)
                Player.Left += speed;

        }

      
    }
}
