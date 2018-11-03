using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractClass
{
    class Programmer : Employee
    {
        public override void speak() =>        Console.WriteLine("Bla Bla Bla");
        public override string ToString() => " Programme";
        
    }
}
