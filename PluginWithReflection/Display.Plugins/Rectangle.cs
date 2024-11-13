using Display.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.Plugins
{
    public class Rectangle : IPlugin
    {
        public string Name => "Dikdörtgen";

        public void Draw(Graphics g, SolidBrush solidBrush, int x, int y, int width, int height)
        {
            g.FillRectangle(solidBrush, x, y, width, height);
        }
    }
}
