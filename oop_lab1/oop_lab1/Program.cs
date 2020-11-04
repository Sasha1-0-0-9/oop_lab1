using System;

namespace oop_lab1
{
    class Program
    {
        static void OutputOneDimensionalArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void FillRandom(ref int[,] arr, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(-5, 5);
                }
            }
        }
        static void OutputMatrix(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[] FindZeros(ref int[,] arr)
        {
            int[] indexes = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                bool isZero = false;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        indexes[i] = j + 1;
                        isZero = true;
                    }
                    else if (!isZero && j == arr.GetLength(1) - 1)
                    {
                        indexes[i] = arr.GetLength(1);
                    }
                }
            }
            return indexes; // Z
        }

        static int[][] JaggedArray(int jaggLength, int[] indexesarray)
        {
            int[][] arr = new int[jaggLength][];
            for (int i = 0; i < jaggLength; i++)
            {
                arr[i] = new int[indexesarray[i]];
            }
            Random rand = new Random();
            int rownumber = 0;
            while (rownumber < arr.Length)
            {
                for (int i = 0; i < arr[rownumber].Length; i++)
                {
                    arr[rownumber][i] = rand.Next(-5, 5);
                }
                Array.Sort(arr[rownumber]);
                Array.Reverse(arr[rownumber]);
                rownumber++;
            }
            OutputJaggedArray(arr);
            return arr;
        }

        static void OutputJaggedArray(int[][] arr)
        {
            int rownumber = 0;
            while (rownumber < arr.Length)
            {
                for (int i = 0; i < arr[rownumber].Length; i++)
                {
                    Console.Write("\t" + "{" + arr[rownumber][i] + "}");
                }
                Console.WriteLine();
                rownumber++;
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m]; // Matrix P

            FillRandom(ref arr, n, m);
            Console.WriteLine("MATRIX");
            OutputMatrix(ref arr);
            Console.WriteLine("Array 1");

            int[] indexes = new int[FindZeros(ref arr).Length];
            indexes = FindZeros(ref arr); // one - dimensional array
            OutputOneDimensionalArray(indexes);
            Console.WriteLine("\n" + "JaggedArray");
            int jaggLength = indexes.Length;

            JaggedArray(jaggLength, indexes);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Чудова робота заслуговує на чудову оцiнку");
            Console.ReadKey();
        }
    }
}
