using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Rectangle : Figure
    {
         

        public override string Name { get; set; }

        private Point[] container;

        public Rectangle()
        {
            container = new Point[4];
           Name = "Rectangle";
        }

      
       

        public override string ToString() => "Name: " + Name + "\nPoint 1: " + container[0] + "\nPoint 2: " + container[1] + "\nPoint 3: " + container[2] + "\nPoint 4: " + container[3];

        public override void InsertInfo()
        {
            for (int i = 0; i < container.Length; i++)
            {
                int x;
                int y;
                int z;
                string name;
                Console.WriteLine("Enter Point {0} info:", i + 1);
                Console.Write("Enter X: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Z: ");
                z = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Point pnt = new Point(x, y, z, name);
                try
                {
                    container[i] = pnt;
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "", ex);
                    throw argEx;
                }
            }
        }

        public override void InsertInfo(Point[] _cnt) =>   container = _cnt;
        
        public override Point[] GetContainer() =>   container;
        

        public override void WriteToFile(string fileName)
        {
            var stream = new StreamWriter(fileName);
            try
            {
                stream.WriteLine("Overriden method for rectangle called");
                stream.WriteLine(this);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Write to file failed: " + ex.Message);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
