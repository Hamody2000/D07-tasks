using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD07
{
    public class HiringDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public HiringDate()
        {
            
        }

        public HiringDate(int _day, int _month, int _year)
        {
            Year = _year;
            Month = _month;
            Day = _day;
        }

        public override string ToString() { 
        
            return $"{Day} /{Month} /{Year}";
        }
    }
}
