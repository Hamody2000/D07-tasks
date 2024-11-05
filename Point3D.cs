using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD07
{
    public class Point3D:ICloneable,IComparable
    {
        int p1;
        int p2;
        int p3;

        public int P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public int P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public int P3
        {
            get
            {
                return p3;
            }

            set
            {
                p3 = value;
            }
        }

        public Point3D()
        {
            
        }
        public Point3D(int _p1,int _p2,int _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }

        public override string ToString() 
        {
            return $"{p1}:{p2},{p3}";
        }

        public object Clone()
        {
            return new Point3D { P1 = p1, P2 = p2, P3 = p3 };
        }

        public int CompareTo(object? obj)
        {
            Point3D right = obj as Point3D;
            return (P1+P2 +P3).CompareTo(right.P1+ right.P2+ right.P3) ;
        }

        public static explicit operator string(Point3D p) 
        {
            return p.ToString();
        }
    }
}
