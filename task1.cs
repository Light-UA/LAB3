using System;

class Program
{
    static void Main()
    {
        // Запит введення цілого числа від користувача
        Console.Write("Введіть ціле число: ");
        int number = int.Parse(Console.ReadLine());

        // Перевірка на парність або непарність
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне.");
        }
        else
        {
            Console.WriteLine("Число непарне.");
        }

        // Перевірка на додатність або від'ємність
        if (number > 0)
        {
            Console.WriteLine("Число додатнє.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число від'ємне.");
        }
        else
        {
            Console.WriteLine("Число нуль.");
        }

        Console.ReadKey();
    }
}
