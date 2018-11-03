using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherenceWithNew
{
    class Program
    {
        public class Point
        {
            public int x = 10;
            public int y = 20;

            public int Sum() => x + y;

            public  String ToString() => $"Point  {x}  {y}"; 
        }

        public class ColorPoint : Point
        {
            public new int x = -30;

            new public String ToString() => $"ColorPoint  {x}  {base.ToString()}"; 

            new public int Sum() => base.x + base.y + x; 
        }


        static void Main(string[] args)
        {
            ColorPoint startPoint = new ColorPoint();
            Console.WriteLine(startPoint);
            Console.WriteLine(startPoint.Sum()); //0
        }
    }
}
