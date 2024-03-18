using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public abstract class Shape
    {
        public abstract double calculate();
        public abstract bool isLegal();
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override bool isLegal()
        {
            return width != 0 && height != 0 && width != height;
        }
        public override double calculate()
        {
            if (isLegal())
            {
                return width * height;
            }
            return 0;
        }

    }

    public class Square : Shape
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public override bool isLegal()
        {
            return sideLength != 0;
        }
        public override double calculate()
        {
            if(isLegal())
            {
                return sideLength * sideLength;
            }
            return 0;
            
        }
    }

    public class Triangle : Shape
    {
        private double width;
        private double height;

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override bool isLegal()
        {
            return width != 0 && height != 0;
        }
        public override double calculate()
        {
            if (isLegal())
            {
                return width * height / 2;
            }
            return 0;
        }
    }

    public class Factory
    {
        public static Shape CreateShape(string type)
        {
            Shape shape = null;
            switch(type)
            {
                case "rectangle":
                    shape= new Rectangle(10,20);
                    shape.calculate();
                    break;
                case "square":
                    shape = new Square(10);
                    shape.calculate();
                    break;
                case "triangle":
                    shape = new Triangle(20,10);
                    shape.calculate();
                    break;
                default:
                    break;

            }
            return shape;

        }
    }

    class Assignment3
    {
         static void Main(string[] args)
        {
            double area = 0;
            Random r = new Random();
            string[] types = { "triangle", "square", "rectangle" };
            for(int i=0;i<10;i++)
            {
                string type = types[r.Next(types.Length)];
                Shape shape = Factory.CreateShape(type);
                area += shape.calculate();
            }
            Console.WriteLine("面积之和为" + area);
        }

    }
}
