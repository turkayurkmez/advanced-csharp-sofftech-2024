using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicKeyword
{
    public class ReportingData
    {
        public dynamic DataSource { get; set; }

        public dynamic GetValues(bool isCollection)
        {
            return isCollection ? new string[] { "A", "B", "C" } :
                                  42;
        }
    }
}
