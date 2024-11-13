using Display.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.Plugins
{
    public class Circle : IPlugin
    {
        public string Name => "Daire";

        public void Draw(Graphics g, SolidBrush solidBrush, int x, int y, int width, int height)
        {
            g.FillEllipse(solidBrush, x, y, width, width);
        }
    }
}
