using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay8
{
    using System;

    public class Location
    {
        private double x;
        private double y;

        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }
    }

    public abstract class Shape
    {
        protected Location location;

        protected double area;
        protected double perimeter;

        public Shape(Location location)
        {
            this.location = location;
            this.area = 0;
            this.perimeter = 0;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Location: ({location.GetX()}, {location.GetY()}), Area: {GetArea()}, Perimeter: {GetPerimeter()}";
        }
    }

    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;

        public Rectangle(double side1, double side2, Location location)
            : base(location)
        {
            this.side1 = side1;
            this.side2 = side2;
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            area = side1 * side2;
            perimeter = 2 * (side1 + side2);
        }

        public override double GetArea()
        {
            return area;
        }

        public override double GetPerimeter()
        {
            return perimeter;
        }
    }

    public class Circle : Shape
    {
        protected double radius;

        public Circle(double radius, Location location)
            : base(location)
        {
            this.radius = radius;
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            area = Math.PI * radius * radius;
            perimeter = 2 * Math.PI * radius;
        }

        public override double GetArea()
        {
            return area;
        }

        public override double GetPerimeter()
        {
            return perimeter;
        }
    }

    class Program
    {
        static void Main()
        {
            Location location1 = new Location(21, 15);
            Location location2 = new Location(3, 85);

            Rectangle rectangle = new Rectangle(15, 10, location1);
            Circle circle = new Circle(7, location2);

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(circle.ToString());
        }
    }
}
