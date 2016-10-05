//3.	Дано натуральное число. Найти число, получаемое в результате приписывания по двойке в начало и конец записи исходного числа.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходное число:");
            int a = int.Parse(Console.ReadLine());
            int count = 0; //число цифр исходного числа
            double b = a;
            while (a > 0)
            {
                a /= 10;
                count++;
            }
            b += 2 * Math.Pow((double)10,(double)count);
            b = b * 10 + 2;
            Console.WriteLine(b);
        }
    }
}
