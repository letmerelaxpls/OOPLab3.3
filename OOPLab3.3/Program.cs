using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3._3
{
    public class Point
    {
        string point;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return point;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Enter a letter of Point:");
            this.point = Console.ReadLine();
            Console.WriteLine("Enter X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }

    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("enter number of verticles of your figure");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length-1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure("figure");
            Console.WriteLine("Enter the name of your figure");
            Console.ReadLine();
            Console.WriteLine(figure.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
