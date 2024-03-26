using System;

class Program
{
    static void Main()
    {
        // Запит введення кількості поїздок з клавіатури
        Console.Write("Введіть кількість поїздок: ");
        int n = int.Parse(Console.ReadLine());

        // Вартість та кількість поїздок кожного типу квитків
        int cost1 = 8, trips1 = 1;
        int cost23 = 145, trips23 = 23;
        int cost62 = 390, trips62 = 62;

        // Ініціалізація змінних для кількості квитків кожного виду
        int tickets1 = 0, tickets23 = 0, tickets62 = 0;

        // Перевірка можливих комбінацій квитків
        for (int i = 0; i <= n / trips62; i++)
        {
            for (int j = 0; j <= n / trips23; j++)
            {
                int remainingTrips = n - i * trips62 - j * trips23;

                if (remainingTrips % trips1 == 0)
                {
                    int k = remainingTrips / trips1;

                    if (tickets1 + tickets23 + tickets62 == 0 ||
                        i + j + k < tickets1 + tickets23 + tickets62)
                    {
                        tickets1 = k;
                        tickets23 = j;
                        tickets62 = i;
                    }
                }
            }
        }

        // Виведення результату на екран
        Console.WriteLine($"Кількість квитків на 1 поїздку: {tickets1}");
        Console.WriteLine($"Кількість квитків на 23 поїздки: {tickets23}");
        Console.WriteLine($"Кількість квитків на 62 поїздки: {tickets62}");

        // Очікування натискання клавіші перед закриттям вікна консолі
        Console.ReadKey();
    }
}
