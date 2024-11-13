using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    /// <summary>
    /// Bu interface'in ilk amacı, bir sınıfın plugin olduğunu belirtmek yani o sınıfı işaretlemektir (tıpkı bir inek gibi).
    /// İkinci amacı ise Plugin'e Name özelliği kazandırmak ve ana işlev olan Draw fonksiyonunu eklemek olacaktır.
    /// </summary>
    public interface IPlugin
    {
        string Name { get; }

        void Draw(Graphics g, SolidBrush solidBrush, int x, int y, int width, int height);
    }
}
