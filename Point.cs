using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public struct Point
    {
        private float x = 0;
        private float y = 0;
        private bool boolean = true;
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(bool b)
        {
            this.boolean = b;
        }
        public static Point operator +(Point p1,Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator /(Point p1, Point p2)
        {
           if(p1.y ==0 || p2.y==0) throw new DivideByZeroException();
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }
        public static bool operator >=(Point p1,Point p2)
        {
            if (p1.x >= p2.x && p1.y >= p2.y) return true;
            return false;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            if (p1.x <= p2.x && p1.y <= p2.y) return true;
            return false;
        }
        public static Point operator &(Point p1,Point p2)
        {
            if (p1.boolean && p2.boolean) return new Point(true);
            return new Point(false);
        }
        public static Point operator |(Point p1, Point p2)
        {
            if (p1.boolean || p2.boolean) return new Point(true);
            return new Point(false);
        }
        public void GetPoint()
        {
            Console.WriteLine($"x = {x}\ny = {y}\n--------------------");
        }
        public void GetBool()
        {
            Console.WriteLine($"Bool is {boolean}");
        }
    }
}
