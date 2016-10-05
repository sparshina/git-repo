/*Дано натуральное число п. Получить число, записанное теми же цифрами, переставленными в обратном порядке. 
Палиндром – это сочетание символов, которые читаются одинаково туда и обратно. 
Написать программу, которая определяет, является ли заданное число палиндромом.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сакод_ЛБ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            int c = 0, b=a; 
            while(a>0)
            {
                c = c * 10 + a % 10;
                a /= 10;
            }
            if(c==b)
                Console.WriteLine("{0} - это полиндром", b);
            else
                Console.WriteLine("{0} -это не полиндром", b);

        }
    }
}
