/*Составить программу перевода натурального числа из системы счисления с основанием m в систему счисления с основанием n, 
 используя десятичную систему счисления: m=9;  n=4;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            int num = -1, c = 0;
                double b = 0;
            while (a>0)
            {
                c = a%10; //последняя цифра
                if (c == 9) break;
                num++;
                b += c*Math.Pow((double)9, (double)num);
                a /= 10;
            }

            if (b == 0)
                Console.WriteLine("Число введено неправильно");
            else
            {
                Console.WriteLine("Введенное число в 10-чной СС: " + b);

                List<int> mod = new List<int>(num);
                num = 0;
                int d = 0;
                int m = 0; //результат - сумма элементов листа
                while (b >=1)
                {
                        d = (int)b % 4;
                        num++;
                        mod.Add((int)(d * Math.Pow((double)10, (double)(num-1))));
                        b /= 4;
                  
                }
                for(int i = 0; i<mod.Count; i++)
                {
                    m = mod.Sum();                    
                }
                Console.WriteLine(m);

            }
        }
    }
}
