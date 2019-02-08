using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk4
{
    class Program

    {

        static void Main(string[] args)

        {

            string s = "[*]";  //  один пример  треугольника

            int a = int.Parse(Console.ReadLine());  //  Ввод число

            for (int i = 1; i <= a; i++)  //      используем loop в loop

            {                               //  

                for (int j = 1; j <= i; j++)  //  

                {

                    Console.Write(s);  // вывод возрастающее каждой итерацией треугольника

                }

                Console.WriteLine();   //  переход в следующую строку

            }

            Console.ReadLine();  //  чтобы окно консоль не закрывалось

        }

    }

}