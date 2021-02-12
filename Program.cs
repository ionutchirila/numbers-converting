using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] arg)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            bool notZero = true;
            do
            {
                if (num < 0 || num > 3999)
                {
                    Console.WriteLine("Error");
                    notZero = false;
                }
                else if (num / 1000 >= 1)
                {
                    Console.Write("M");
                    num = num - 1000;
                }
                else if (num / 900 >= 1)
                {
                    Console.Write("CM");
                    num = num - 900;
                }
                else if (num / 500 >= 1)
                {
                    Console.Write("D");
                    num = num - 500;
                }
                else if (num / 100 >= 1)
                {
                    Console.Write("C");
                    num = num - 100;
                }
                else if (num / 90 >= 1)
                {
                    Console.Write("XC");
                    num = num - 90;
                }
                else if (num / 50 >= 1)
                {
                    Console.Write("L");
                    num = num - 50;
                }
                else if (num / 40 >= 1)
                {
                    Console.Write("XL");
                    num = num - 40;
                }
                else if (num / 10 >= 1)
                {
                    for (int i = 0; i < (num / 10); i++)
                    {
                        Console.Write("X");
                        num = num - 10;
                    }
                }
                else if (num / 9 >= 1)
                {
                    Console.Write("IX");
                    num = num - 9;
                }
                else if (num / 5 >= 1)
                {
                    Console.Write("V");
                    num = num - 5;
                }
                else if (num / 4 >= 1)
                {
                    Console.Write("IV");
                    num = num - 4;
                }
                else if (num / 1 >= 1)
                {
                    for (int i = 0; i < (num / 1); i++)
                    {
                        Console.Write("I");
                        num = num - 1;
                    }
                }
                else
                {
                    notZero = false;
                }
            }
            while (notZero);
        }
    }
}
