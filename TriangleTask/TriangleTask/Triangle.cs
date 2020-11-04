using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleTask
{
    class Triangle
    {
        protected int a;
        protected int b;
        protected int c;

        public Triangle()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }

        public int SideA
        {
            get
            {
                return a;
            }
            set
            {
                if (isTriangleExist(value, b, c))
                {
                    a = value;
                    Output(value, b, c);
                }
                else
                {
                    Console.WriteLine("A triangle with sides A = {0} cm   B = {1} cm   C= {2} cm doesn't exist", value, b, c);
                }
            }
        }

        public int SideB
        {
            get
            {
                return b;
            }
            set
            {
                if (isTriangleExist(a, value, c))
                {
                    b = value;
                    Output(a, value, c);
                }
                else
                {
                    Console.WriteLine("A triangle with sides A = {0} cm   B = {1} cm   C= {2} cm doesn't exist", a, value, c);
                }
            }
        }

        public int SideC
        {
            get
            {
                return c;
            }
            set
            {
                if (isTriangleExist(a, b, value))
                {
                    c = value;
                    Output(a, b, value);
                }
                else
                {
                    Console.WriteLine("A triangle with sides A = {0} cm   B = {1} cm   C= {2} cm doesn't exist", a, b, value);
                }
            }
        }

        public bool isTriangleExist(int a, int b, int c)
        {
            bool isExist = true;
            if (a + b <= c || b + c <= a || b >= a + c)
            {
                isExist = false;
                return isExist;
            }
            else
            {
                return isExist;
            }
        }
        static int Perimeter(int a, int b, int c)
        {
            return a + b + c;

        }

        static double Square(int a, int b, int c)
        {
            double halfPer = (double)Perimeter(a, b, c) / 2.0;
            return Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
        }

        public static void Output(int a, int b, int c)
        {
            Console.WriteLine("A = {0} cm   B = {1} cm   C= {2} cm", a, b, c);
            Console.WriteLine(" Perimetr: {0}", Perimeter(a, b, c));
            Console.WriteLine("Square: {0}", Square(a, b, c));
            Console.WriteLine();

        }

    }
}
