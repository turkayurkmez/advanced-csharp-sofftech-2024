using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBagOnWindows
{
    public interface IAttachFormBag
    {
        dynamic FormBag { get; set; }
    }
}
