//************************
// практическая работа №8*
// выполнил: Ханов Артур *
//************************
using System;

namespace PR_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, x, c, c1, sum;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
                Console.WriteLine("здравствуйте! \nвведите любые числа");
                i = Convert.ToInt32(Console.ReadLine());
                x = i;
                c = 1;
                c1 = 0;
                sum = 0;

                do
                {
                    c++;
                    c1 += i;
                    for (int v = i; v <= i; v++)
                    {
                        sum += i * i;
                    }
                    if (i < x) x = i;
                    i = Convert.ToInt32(Console.ReadLine());
                }
                while (i != 0);
                Console.WriteLine($"введено чисел {c}");
                Console.WriteLine($"общая сумма чисел {c1}");
                Console.WriteLine($"сумма квадратов {sum}");

            }
            catch (Exception e)
            {
                Console.WriteLine("что-то пошло не так " + e.Message);
            }
            Console.ReadLine();

        }
    }
}
