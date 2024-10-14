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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close(); 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 15;
            doroga.Top += speed;
            doroga2.Top += speed;

            if(doroga.Top >= 650)
            {
                doroga.Top = 0;
                doroga2.Top = -650;
            }
        }
    }
}
