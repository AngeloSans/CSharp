using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Poo
{
    class AbstractMethod
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(Color.Black,13, 14);
            Console.WriteLine($"A area do retangulo é {rec.Area()}");
        }
    }

    abstract class Shape {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }

    class Rectangle : Shape
    {
        public double height;
        public double width;
        public Rectangle(Color color, double height, double widht) : base(color)
        {
            this.height = height;
            this.width = widht;
        }

        public override double Area()
        {
            return height + width;
        }
    }

    enum Color { 
        Black,
        Red,
        Green
    }

}
