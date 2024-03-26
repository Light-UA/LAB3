using System;

class Program
{
    static void Main()
    {
        // Запит введення годин з клавіатури
        Console.Write("Введіть години (0-23): ");
        int hours = int.Parse(Console.ReadLine());

        // Запит введення хвилин з клавіатури
        Console.Write("Введіть хвилини (0-59): ");
        int minutes = int.Parse(Console.ReadLine());

        // Перевірка коректності введених значень
        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
        {
            Console.WriteLine("Некоректний ввід часу.");
            return;
        }

        // Перетворення часу в 12-годинний формат
        string result = ConvertTo12HourFormat(hours, minutes);

        // Виведення результату на екран
        Console.WriteLine($"Час у 12-годинному форматі: {result}");

        // Очікування натискання клавіші перед закриттям вікна консолі
        Console.ReadKey();
    }

    static string ConvertTo12HourFormat(int hours, int minutes)
    {
        string timePeriod; // Перемінна для збереження AM або PM

        // Перевірка годин для визначення AM або PM
        if (hours < 12)
        {
            timePeriod = "AM";
        }
        else
        {
            timePeriod = "PM";
        }

        // Перетворення годин у 12-годинний формат
        int hours12h = (hours == 0 || hours == 12) ? 12 : hours % 12;

        // Повернення рядка з 12-годинним форматом та AM/PM
        return $"{hours12h}:{minutes:D2} {timePeriod}";
    }
}
