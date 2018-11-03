using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    sealed class Button : IControl
    {
        private string _name { get; }
        private int _X_pos { get; }
        private int _Y_pos { get; }
        private string _color { get; }

       public Button()
        {
            _name = "";
            _X_pos = 0;
            _Y_pos = 0;
            _color = "";
        }

        public Button(int x, int y, string name, string color)
        {
            _name = name;
            _color = color;
            _X_pos = x;
            _Y_pos = y;
        }

        void IControl.Click() =>     Console.WriteLine("Button clicked");
     
        void IControl.Move() =>      Console.WriteLine("Button moved");
        

        public override string ToString() => "Name: " + _name + " X: " + _X_pos + " Y: " + _Y_pos + " Color: " + _color;
    }
}
