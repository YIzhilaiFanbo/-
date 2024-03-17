using System;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            if (!IsTriangle())
            {
                Console.WriteLine("输入三条边不能构成三角形");
            }
        }

        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        private bool IsTriangle()
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            if (!IsRectangle())
            {
                Console.WriteLine("输入边长不能小于等于0");
            }
        }

        public override double Area()
        {
            return length * width;
        }

        private bool IsRectangle()
        {
            return length > 0 && width > 0;
        }
    }

    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
            if (!IsSquare())
            {
                Console.WriteLine("输入边长不能小于等于0");
            }
        }

        public override double Area()
        {
            return side * side;
        }

        private bool IsSquare()
        {
            return side > 0;
        }
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(string type, params double[] dimensions)
        {
            switch (type.ToLower())
            {
                case "triangle":
                    if (dimensions.Length == 3)
                        return new Triangle(dimensions[0], dimensions[1], dimensions[2]);
                    break;
                case "rectangle":
                    if (dimensions.Length == 2)
                        return new Rectangle(dimensions[0], dimensions[1]);
                    break;
                case "square":
                    if (dimensions.Length == 1)
                        return new Square(dimensions[0]);
                    break;
            }
            throw new ArgumentException("无法创建指定类型的形状对象");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double totalArea = 0;

            for (int i = 0; i < 10; i++)
            {
                int shapeType = random.Next(1, 4);
                Shape shape;
                switch (shapeType)
                {
                    case 1:
                        shape = ShapeFactory.CreateShape("triangle", random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 2:
                        shape = ShapeFactory.CreateShape("rectangle", random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 3:
                        shape = ShapeFactory.CreateShape("square", random.Next(1, 10));
                        break;
                    default:
                        shape = null;
                        break;
                }
                if (shape != null)
                    totalArea += shape.Area();
            }

            Console.WriteLine("所有形状的面积之和为: " + totalArea);
        }
    }
}
