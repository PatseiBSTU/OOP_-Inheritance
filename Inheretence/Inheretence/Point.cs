using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Point
    {

        public string Name {get;set;}

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
       public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
            Name = "";
        }

        public Point(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
            Name = "";
        }

        public Point(int _x, int _y, int _z, string _name)
        {
            X = _x;
            Y = _y;
            Z = _z;
            Name = _name;
        }

        public override string ToString() => " Point: " + Name + "\nX: " + X + "\nY: " + Y + "\nZ: " + Z; 
        public override bool Equals(Object _pnt) // override by Object
        {
            if (_pnt == null)
            {
                return false;
            }
            Point pnt = _pnt as Point;
            if (pnt != null)
            {
                return ((X == pnt.X) && (Y == pnt.Y) && (Z == pnt.Z));
            }
            else return false;
        }

         public override int GetHashCode() =>  X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode();
        
    }
}

