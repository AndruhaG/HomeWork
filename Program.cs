using System;

namespace ConsoleApp
{
    class Program
    {
         static void Main(string[] args)
        {
         /*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
                a = 5; b = 7 -> max = 7
                a = 2 b = 10 -> max = 10
                a = -9 b = -3 -> max = -3
         */
         /*  Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine($"число {first} больше, а число {second} меньше");
            }
            else
            {
                Console.WriteLine($"число {second} больше, а число {first} меньше");
            }
         */

         /*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                 2, 3, 7 -> 7
                 44 5 78 -> 78
                 22 3 9 -> 22
         */

           /*   Console.WriteLine("Введите первое число");
                int one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int two = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int three = Convert.ToInt32(Console.ReadLine());
                int max = 0;

                if (one > two) {max = one;}
                else {max = two;}
                if (max > three) {max = max;}
                else {max = three;}
                Console.WriteLine($"максимальное число {max}");
          */

        /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            4 -> да
            -3 -> нет
            7 -> нет
        */

            /*  Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0) 
                {
                  Console.WriteLine($"число {number} четное");
                }
                else
                {
                  Console.WriteLine($"число {number} нечетное");
                }
            */

          /*  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                5 -> 2, 4
                8 -> 2, 4, 6, 8
          */

                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine()); 
                int count = 1;

                while (count <= number)
                {
                if (count % 2 == 0) 
                
                 Console.Write(count + " ");
                 count++;
                }
                
                


















        }

        
    }
}