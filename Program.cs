using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace ДЗ__1_Легкова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int l = 0;
            int l1 = 0;

            do
            {
                n = GetTableSize("Введите размерность таблицы: ");
            }
            while (n < 1 || n > 6);

            l1 = 40 - n - n;

            var sb = new StringBuilder();

            while (true)
            {
                Console.WriteLine("Введите произвольный текст: ");
                string dln = Console.ReadLine();
                if (dln.Length <= 0 || dln.Length > l1)
                {
                    //Console.WriteLine("Введите произвольный текст: ");
                }
                else
                {
                    l = dln.Length + n + n;
                    sb.Append(dln.ToString());
                    break;
                }

            }
            int i = n - 1;
            int l2 = l - 2;

            //Console.WriteLine("высота: " + n + ", ширина: " + l);
            Console.WriteLine(new string('+', l));

            if (i > 0)
            {
                for (int c = 0; c < i; c++)
                {
                    Console.Write("+");
                    Console.Write(new string(' ', l2));
                    Console.WriteLine("+");
                }
                Console.Write("+");
                Console.Write(new string(' ', i));
                Console.Write(sb);
                Console.Write(new string(' ', i));
                Console.WriteLine("+");
                for (int c = 0; c < i; c++)
                {
                    Console.Write("+");
                    Console.Write(new string(' ', l2));
                    Console.WriteLine("+");
                }

            }
            else
            {
                Console.Write("+");
                Console.Write(sb);
                Console.WriteLine("+");
            }
            Console.WriteLine(new string('+', l));


            int l4 = n + n - 2;
            for (int f = 0; f < l4;)
            {

                int N = l;
                if (N % 2 == 0)
                {
                    N = N - 2;
                    N = N / 2;
                    int[] Array = new int[N];
                    for (int y = 0; y < Array.Length; y++)
                    {
                        Console.Write("+");
                        Console.Write(" ");
                    }
                    Console.Write("+");
                    Console.WriteLine("+");
                    f = f + 1;
                }

                else
                {
                    N = N - 1;
                    N = N / 2;
                    int[] Array = new int[N];
                    for (int z = 0; z < Array.Length; z++)
                    {
                        Console.Write("+");
                        Console.Write(" ");
                    }
                    Console.WriteLine("+");
                    f = f + 1;
                }

                int N2 = l;
                if (N2 % 2 == 0)
                {
                    N2 = N2 - 2;
                    N2 = N2 / 2;
                    int[] Array = new int[N2];
                    Console.Write("+");
                    for (int y = 0; y < Array.Length; y++)
                    {
                        Console.Write("+");
                        Console.Write(" ");
                    }
                    Console.WriteLine("+");
                    f = f + 1;

                }

                else
                {
                    N2 = N2 - 3;
                    N2 = N2 / 2;
                    int[] Array = new int[N2];
                    Console.Write("+");
                    for (int z = 0; z < Array.Length; z++)
                    {
                        Console.Write("+");
                        Console.Write(" ");
                    }
                    Console.Write("+");
                    Console.WriteLine("+");
                    f = f + 1;
                }

            }
            int N3 = l;
            if (N3 % 2 == 0)
            {
                N3 = N3 - 2;
                N3 = N3 / 2;
                int[] Array = new int[N3];
                for (int y = 0; y < Array.Length; y++)
                {
                    Console.Write("+");
                    Console.Write(" ");
                }
                Console.Write("+");
                Console.WriteLine("+");
            }

            else
            {
                N3 = N3 - 1;
                N3 = N3 / 2;
                int[] Array = new int[N3];
                for (int z = 0; z < Array.Length; z++)
                {
                    Console.Write("+");
                    Console.Write(" ");
                }
                Console.WriteLine("+");
            }
            Console.WriteLine(new string('+', l));

            int sideLength = l;
            for (int row = 1; row <= sideLength; row++)
            {
                for (int col = 1; col <= sideLength; col++)
                {
                    if (col == 1)
                        Console.Write('+');
                    else if (col == row)
                        Console.Write('+');
                    else if (col == sideLength - row)
                        Console.Write('+');
                    else if (col == sideLength)
                        Console.Write('+');
                    else if (row == sideLength)
                        Console.Write('+');
                    else
                        Console.Write(' ');
                }

                Console.WriteLine(' ');
            }

            static int GetTableSize(string v)
            {
                while (true)
                {
                    Console.WriteLine(v);
                    var str = 0;

                    if (Int32.TryParse(Console.ReadLine(), out str))
                    {
                        return str;
                    }
                    else
                    {
                        Console.WriteLine(v);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}