using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    
        abstract class Figure
        {
           
        abstract public string Name { get; set; }

        abstract public void InsertInfo();
            abstract public void InsertInfo(Point[] _cnt);
            abstract public Point[] GetContainer();
            public abstract void WriteToFile(string fileName);
        }
    }
