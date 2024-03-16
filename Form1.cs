using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool isPlayer1 = true;
        public Form1()
        {
            InitializeComponent();
            ResetGame();

        }

        void ResetGame ()
        {
            short pbIdx = 1;
            foreach (Control control in gbGame.Controls)
            {
                if (control is PictureBox pb)
                {
                    // Set inital pictures
                    pb.Image = Resources.question_mark_96;
                    pb.Name = $"pb{pbIdx}";
                    pbIdx++;

                    // Subscribe all picture boxes to the click event
                    pb.Click += pictureBox_Click;
                    pb.Tag = "notFliped";
                }
            }
        }

        void hasPlayerWon ()
        {

        }

        private void gbGame_Paint(object sender, PaintEventArgs e)
        {/*
            Color White = Color.FromArgb(255, 255, 255, 0);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 600, 100, 100, 200);
        */}

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox currentPicture = (PictureBox)sender;
            if (currentPicture.Tag == "Fliped")
            {
                // The error message dialog comes here:
                return;
            }

            if (isPlayer1)
            {
                currentPicture.Image = Resources.X;
            } else
            {
                currentPicture.Image = Resources.O;
            }

            currentPicture.Tag = "Fliped";
            isPlayer1 = !isPlayer1;

            hasPlayerWon();
        }
    }
}
