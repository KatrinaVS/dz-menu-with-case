using System;

namespace dz2
{
    class Program
    {
        private static bool b1;
        private static bool b2;

        static void Main(string[] args)
        {
            Console.WriteLine("Операции сравнения!");

            Console.WriteLine("Введите первую цифру!");
            var variadle = Console.ReadLine(); //вводим первую цифру
            Console.WriteLine("Введите вторую цифру!");
            var variadl = Console.ReadLine(); //вводим вторую цифру

            int x = Int32.Parse(variadle);
            int a = Int32.Parse(variadl);


            if (x == a)
                Console.WriteLine($"Число {x} равно числу {a}");


            if (x != a)
                Console.WriteLine($"Число {x} не равно числу {a}");


            if (x < a)
                Console.WriteLine($"Число {x} меньше числа {a}");


            if (x > a)
                Console.WriteLine($"Число {x} больше числа {a}");

            if (x <= a)
                Console.WriteLine($"Число {x} меньше или равно числу {a}");


            if (x >= a)
                Console.WriteLine($"Число {x} больше или равно числу {a}");

            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("Нельзя выполнить");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) — true");
            if (b1 | b2) Console.WriteLine("bl I b2 - true");
            if (b1 ^ b2) Console.WriteLine("bl ^ b2 — true");

            Console.ReadKey();
        }
    }
}
