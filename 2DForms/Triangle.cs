using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DForms
{
    class Triangle
    {
        public Point a { get; set; } = new Point(0, 0);
        public Point b { get; set; } = new Point(0, 0);
        public Point c { get; set; } = new Point(0, 0);

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Print()
        {
            Console.WriteLine($"a {this.a.X}{this.a.Y}");
            Console.WriteLine($"b {this.b.X}{this.b.Y}");
            Console.WriteLine($"a {this.c.X}{this.c.Y}");  
        }

        public void Move(int OX, int OY)
        {
            this.a.X = this.a.X + OX;
            this.a.Y = this.a.Y + OY;
            this.b.X = this.b.X + OX;
            this.b.Y = this.b.Y + OY;
            this.c.X = this.c.X + OX;
            this.c.Y = this.c.Y + OY;
        }
    }
}
