﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaFactory.Entities
{
    public class Ball : Label
    {
        public Ball()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Ball_Paint;

        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            Brush ecset = new SolidBrush(Color.Aquamarine); 
            g.FillEllipse(
                ecset,
                0,
                0,
                Width,
                Height);
        }

        public void MoveBall()
        {
            Left++;
        }
    }
}
