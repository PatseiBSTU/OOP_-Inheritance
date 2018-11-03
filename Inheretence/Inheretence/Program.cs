using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure rnct1 = new Rectangle();
            Point[] cont = new Point[4];
            cont[0] = new Point(1, 1, 1, "A");
            cont[1] = new Point(2, 2, 2, "B");
            cont[2] = new Point(3, 3, 3, "C");
            cont[3] = new Point(4, 4, 4, "D");
            rnct1.InsertInfo(cont);
            Console.WriteLine(rnct1);   // display info
            rnct1.WriteToFile("rectangle.txt"); // print to file
            Console.WriteLine("----------");
            IControl btn = new  Button();
            btn.Click();
            Console.WriteLine(btn);     // check overriden method

          
            Console.ReadKey();
        }

    }
    }

