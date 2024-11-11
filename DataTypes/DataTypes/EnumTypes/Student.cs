using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public StudentState State { get; set; } = StudentState.Unknown;
    }
}
