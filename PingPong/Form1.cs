using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 5;
        private int speed_horizontal = 5;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = Field.Bottom - Field.Bottom / 10;
            loser.Top = (Field.Height / 2)-(loser.Height/2);
            loser.Left = (Field.Width / 2)- (loser.Width/2);

            loser.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.R)
            {
                gameBall.Left = 70;
                gameBall.Top = 60;
                speed_horizontal = 5;
                speed_vertical = 5;
                score = 0;
                loser.Visible = false;
                ScoreLabel.Text = "Score: 0";
                timer.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);
            gameBall.Left += speed_horizontal;
            gameBall.Top += speed_vertical;

            if (gameBall.Bottom >= Field.Bottom)
            {
                timer.Enabled = false;
                loser.Visible = true;
            }
            if (gameBall.Top<=Field.Top)
                speed_vertical *= -1;
            if (gameBall.Left <= Field.Left)
                speed_horizontal *= -1;
            if (gameBall.Right >= Field.Right)
                speed_horizontal *= -1;

            if(gameBall.Left>=gamePanel.Left&&gameBall.Right<=gamePanel.Right
                &&gameBall.Bottom >= gamePanel.Top&&gameBall.Bottom<=gamePanel.Bottom)
            {
                speed_vertical += 1;
                speed_vertical *= -1;
                score += 1;
                ScoreLabel.Text = "Score: " + score.ToString();
                Random colour_rnd = new Random();
                int red = colour_rnd.Next(150, 255);
                int green = colour_rnd.Next(150, 255);
                int blue = colour_rnd.Next(150, 255);
                Field.BackColor = Color.FromArgb(red,green,blue);
            }


        }
    }
}
