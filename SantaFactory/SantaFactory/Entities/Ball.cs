﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SantaFactory.Abstrations;

namespace SantaFactory.Entities
{
    public class Ball : Toy
    {
        

       

        protected override void DrawImage(Graphics g)
        {
           
            g.FillEllipse(
                new SolidBrush(Color.Aquamarine),
                0,
                0,
                Width,
                Height);
        }

       
    }
}
