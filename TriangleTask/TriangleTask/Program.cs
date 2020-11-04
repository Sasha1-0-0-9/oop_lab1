using System;

namespace TriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle();
            Triangle.Output(abc.SideA, abc.SideB, abc.SideC);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose the side you want to change(1 = side A, 2 = side B, 3 = side C)");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Input new length for side A");
                    abc.SideA = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Input new length for side B");
                    abc.SideB = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Input new length for side C");
                    abc.SideC = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadKey();
        }
    }
}
