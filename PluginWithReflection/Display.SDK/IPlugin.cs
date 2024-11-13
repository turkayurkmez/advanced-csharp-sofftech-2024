﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public interface IPlugin
    {
        string Name { get; }

        void Draw(Graphics g, SolidBrush solidBrush, int x, int y, int width, int height);
    }
}