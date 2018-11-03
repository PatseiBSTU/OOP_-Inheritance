using System;

namespace AbstaractClass
{
    
        public abstract class Employee : Person  //abstract class
        {
            public  void work() =>   Console.WriteLine("I am working");
             public override string ToString() =>   "Employee";
        
    }

}
