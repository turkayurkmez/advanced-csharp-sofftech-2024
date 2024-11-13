using Display.SDK;
using System.Drawing;

namespace Display.Plugins
{
    public class Square : IPlugin
    {
        public string Name => "Kare";

        public void Draw(Graphics g, SolidBrush solidBrush, int x, int y, int width, int height)
        {
           g.FillRectangle(solidBrush, x, y, width, width);
        }
    }
}
