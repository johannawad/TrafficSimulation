﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TrafficSimulation
{
    [Serializable()]
    public class Grid : Control
    {
        public List<Rectangle> Placeholders { get; set; }
        
        public Grid()
        {
            Placeholders = new List<Rectangle>();

            Placeholders.Add(new Rectangle(0, 0, 200, 200));
            Placeholders.Add(new Rectangle(200, 0, 200, 200));
            Placeholders.Add(new Rectangle(400, 0, 200, 200));
            Placeholders.Add(new Rectangle(600, 0, 200, 200));

            Placeholders.Add(new Rectangle(0, 200, 200, 200));
            Placeholders.Add(new Rectangle(200, 200, 200, 200));
            Placeholders.Add(new Rectangle(400, 200, 200, 200));
            Placeholders.Add(new Rectangle(600, 200, 200, 200));

            Placeholders.Add(new Rectangle(0, 400, 200, 200));
            Placeholders.Add(new Rectangle(200, 400, 200, 200));
            Placeholders.Add(new Rectangle(400, 400, 200, 200));
            Placeholders.Add(new Rectangle(600, 400, 200, 200));

        }

    }
}
