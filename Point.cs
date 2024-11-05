using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD07
{
    public class Point:IComparable
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

    
        public Point()
        {
            x = y = 0;
        }

        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public  override string ToString() 
        {
            return $"({x},{y})";
        }

        public int CompareTo(object? obj)
        {
            Point right = obj as Point;
            //return this.X.CompareTo(right.X);
            return (this.X+this.Y).CompareTo((right.X+right.Y));
        }
    }
}
