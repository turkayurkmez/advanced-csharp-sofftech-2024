using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static double GetSquare(this int value) => Math.Pow(value, 2);
        public static double GetPower(this int value, int power) => Math.Pow(value, power);

        public static char NextChar(this Random random, bool isUpper)
        {
            return isUpper ? (char)random.Next(65, 91)
                           : (char)random.Next(97, 123);
        }

        public static string NextString(this Random random, int length)
        {
            var randomlyUpper = Convert.ToBoolean(random.Next(0, 1));
            string output = string.Empty;
            for (int i = 0; i < length; i++)
            {
                output += random.NextChar(randomlyUpper);
            }
            return output;
        }

        public static int TotalWorkDays(this DateTime dateTime, params DateTime[] holidays)
        {
            var firstDate = new DateTime(dateTime.Year, 1, 1);
            var endDate = new DateTime(dateTime.Year, 12, 31);
            var total = 0;
            for (DateTime current = firstDate; current <= endDate; current=current.AddDays(1))
            {
                if (!(current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday) )
                {                  

                    var isAny = holidays.ToList().Any(x=>x.Month == current.Month && x.Day == current.Day);
                    if (!isAny)
                    {
                        total++;
                    }
                }
            }
            return total;
        }


    }
}
