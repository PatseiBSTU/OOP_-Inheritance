using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrinaryInherence
{
    class Program
    {
        public class Point
        {
            private int X { get; set; } = 10;
            public int Y { get; set; } = 20;
            public int Sum() => X + Y; 
        }
        public class ColorPoint : Point
        {
            public int color = 78;
        }
        private static void Main(string[] args)
        {

            ColorPoint cPoint = new ColorPoint();

            Console.WriteLine(cPoint.Sum());//30
                                           //  вызов методов по типу ссылки
        }
    }
}
