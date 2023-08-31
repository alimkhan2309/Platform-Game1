using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {

        Player user = new Player();
        bool isGameOver;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { user.GoLeft = true; }
            if (e.KeyCode == Keys.Right) { user.GoRight = true; }
            if (e.KeyCode == Keys.Down) { user.GoDown = true; }
            if ((e.KeyCode == Keys.Up) && user.Jumping == false) { user.Jumping = true; }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { user.GoLeft = false; }
            if (e.KeyCode == Keys.Right) { user.GoRight = false; }
            if (e.KeyCode == Keys.Down) { user.GoDown = false; }
            if (user.Jumping == true) { user.Jumping = false; }

            if (e.KeyCode == Keys.Up && isGameOver == true) { RestartGame(); }
        }

        private void RestartGame()
        {
            user.Jumping = false;
            user.GoRight = false;
            user.GoLeft = false;
            isGameOver = false;
            
            PlatformSide.BackColor = Color.White;
            scoreLabel.Text = "Score " + score;
        }
    }
}
