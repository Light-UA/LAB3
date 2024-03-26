using System;

class Program
{
    static void Main()
    {
        // Запит введення значення швидкості (V) та часу подорожі (T)
        Console.Write("Введіть швидкість байкера (км/год): ");
        int V = int.Parse(Console.ReadLine());
        Console.Write("Введіть час подорожі (год): ");
        int T = int.Parse(Console.ReadLine());

        // Визначення початкового кілометра для КАД (109 км - остання позначка)
        int startKm = 109;

        // Обчислення позначки, на якій зупиниться байкер
        int currentKm = startKm + (V * T);
        int finalKm = currentKm % startKm; // Використання оператора модуля для перевірки позначки на КАД

        // Виведення результату на екран
        Console.WriteLine($"Байкер зупиниться на позначці номер {finalKm}");

        // Очікування натискання клавіші перед закриттям вікна консолі
        Console.ReadKey();
    }
}
