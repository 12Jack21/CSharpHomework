using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    //抽象形状类
    public abstract class Shape
    {
        public abstract double getArea();
    }

    public class Circle:Shape
    {
        const double PI = 3.1415926;
        double radius;
        public Circle()
        {
            Console.WriteLine("Please enter the length of radius of the circle:");
            this.radius = Convert.ToDouble(Console.ReadLine());
        }
        public override double getArea()
        {
            return PI * radius * radius;
        }
    }

    public class Rectangle:Shape
    {
        double height, width;
        public Rectangle()
        {
            Console.WriteLine("Please enter the length of height and width of the rectangle:");
            this.height = Convert.ToDouble(Console.ReadLine());
            this.width = Convert.ToDouble(Console.ReadLine());
        }
        public override double getArea()
        {
            //throw new NotImplementedException();
            return height * width;
        }
    }
    
    public class Square:Shape
    {
        double edge;
        public Square()
        {
            Console.WriteLine("Please enter the length of edge of the square:");
            this.edge = Convert.ToDouble(Console.ReadLine());
        }

        public override double getArea()
        {
            return edge * edge;
        }
    }

    public class Triangle:Shape
    {
        double edge1, edge2, edge3;
        public Triangle()
        {
            Console.WriteLine("Please enter the length of three edges of the triangle:");
            this.edge1 = Convert.ToDouble(Console.ReadLine());
            this.edge2 = Convert.ToDouble(Console.ReadLine());
            this.edge3 = Convert.ToDouble(Console.ReadLine());
        }

        public override double getArea()
        {
            //海伦公式计算三角形面积
            double temp = (edge1 + edge2 + edge3) / 2.0;
            return Math.Sqrt(temp * (temp - edge1) * (temp - edge2) * (temp - edge3));
        }
    }
    //工厂类
    public class ShapeFactory
    {
        public static Shape GetShape(string shapeType)
        {
            Shape shape = null;
            if(shapeType == "circle")
            {
                shape = new Circle();
            }
            else if(shapeType == "rectangle")
            {
                shape = new Rectangle();
            }
            else if(shapeType == "square")
            {
                shape = new Square();
            }
            else
            {
                shape = new Triangle();
            }
            return shape;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which type of shape do you want to create :（rectangle,square,triangle,circle）");
            string shapeType = Convert.ToString(Console.ReadLine());
            Shape shape = ShapeFactory.GetShape(shapeType);
            Console.WriteLine("The area of the " + shapeType + " is " + shape.getArea());
        }
    }
}
