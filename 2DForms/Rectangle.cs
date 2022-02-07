using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DForms
{
    public class Rectangle
    {
        public Point a { get; set; } = new Point(0, 0);
        public Point b { get; set; } = new Point(0, 0);
        public Point c { get; set; } = new Point(0, 0);
        public Point d { get; set; } = new Point(0, 0);

        public int Lungime { get; set; }
        public int Latime { get; set; }

        public Rectangle(Point a, int lungime, int latime)
        {
            this.a = a;
            this.Lungime = Lungime;
            this.Latime = Latime;
            
        }
        public void Print()
        {
            Console.WriteLine($"a {this.a.X}{this.a.Y}");
            Console.WriteLine($"b {this.b.X}{this.b.Y}");
            Console.WriteLine($"a {this.c.X}{this.c.Y}");
            Console.WriteLine($"a {this.d.X}{this.d.Y}");
        }
        
        public void Move(int OX, int OY)
        {
            this.a.X = this.a.X + OX;
            this.a.Y = this.a.Y + OY;
            this.b.X = this.b.X + OX;
            this.b.Y = this.b.Y + OY;
            this.c.X = this.c.X + OX;
            this.c.Y = this.c.Y + OY;
            this.d.X = this.d.X + OX;
            this.d.Y = this.d.Y + OY;
        }
    }

}
