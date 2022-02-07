using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DForms
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Print()
        {
            Console.WriteLine("X= " + this.X);
            Console.WriteLine("Y= " + this.Y);
        }

        public void Move(int OX, int OY)
        {
            this.X = X + OX;
            this.Y = Y + OY;
        }
    }
}
