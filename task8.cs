using System;

class Program
{
    static void Main()
    {
        // Запит введення року з клавіатури
        Console.Write("Введіть рік: ");
        int year = int.Parse(Console.ReadLine());

        // Перевірка чи є рік високосним
        bool isLeapYear = IsLeapYear(year);

        // Виведення результату на екран
        if (isLeapYear)
        {
            Console.WriteLine($"Рік {year} є високосним.");
        }
        else
        {
            Console.WriteLine($"Рік {year} не є високосним.");
        }

        // Очікування натискання клавіші перед закриттям вікна консолі
        Console.ReadKey();
    }

    // Функція для визначення чи є рік високосним
    static bool IsLeapYear(int year)
    {
        // Рік є високосним, якщо він ділиться на 4, але не ділиться на 100, за винятком тих, що діляться на 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
