using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractClass
{
    partial class Program
    {

        static void Main(string[] args)
        {

            //  Person father = new Person();  // объект абстрактного класса создавать нельзя
          //  Employee worker = new Employee(); //abstract class
           Person cProgrammer = new Programmer();
           Console.WriteLine(cProgrammer.ToString());
            cProgrammer.speak();
           
            Employee javaProgrammer = new Programmer();
            Console.WriteLine(javaProgrammer.ToString());
            javaProgrammer.speak();

        }
    }
}
