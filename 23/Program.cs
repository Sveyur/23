using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _23
{
    class Program
    {
        static public int x;
        static int factorial = 1;
        static void ArrayFactorial(int x)
        {
            Console.WriteLine("Метод ArrayFactorial начал работу!\n");            
            for (int a = 1; a <= x; a++)
            {
                Console.WriteLine("Выводится последовательность чисел: "+a+"\n");
                Thread.Sleep(100);
            }
            Console.WriteLine("Метод ArrayFactorial вывел последовательность чисел на консоль!\n");
        }
        static int Factorial(int x)
        {
            Console.WriteLine("Расчет факториала методом Factorial начался!\n");
            for (int a = 1; a <= x; a++)
            {
                factorial = factorial * a;
                Console.WriteLine("Последовательный расчет факториала : "+factorial+"\n");
                Thread.Sleep(400);
            }
            Console.WriteLine("Факториал числа " +x+"! равен " + factorial+"\n");
            return (factorial);
        }
        static async void Async()
        {
            await Task.Run(() => ArrayFactorial(x));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число, факториал которого надо вычислить:  ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Async();
            Factorial(x);
            Console.WriteLine("Метод Main окончил работу!!!");            
            Console.ReadKey();
        }

    }
}
