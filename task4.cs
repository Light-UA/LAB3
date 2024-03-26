using System;

class Program
{
    static void Main()
    {
        // Запит введення сторін трикутника з клавіатури
        Console.Write("Введіть довжину сторони a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони c: ");
        double c = double.Parse(Console.ReadLine());

        // Перевірка чи існує трикутник за заданими сторонами
        if (IsTriangleExist(a, b, c))
        {
            // Обчислення півпериметра
            double p = (a + b + c) / 2;

            // Обчислення площі трикутника за формулою Герона
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Виведення результату на екран
            Console.WriteLine($"Площа трикутника: {square}");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }

        // Очікування натискання клавіші перед закриттям вікна консолі
        Console.ReadKey();
    }

    static bool IsTriangleExist(double a, double b, double c)
    {
        // Перевірка умови існування трикутника
        return a + b > c && a + c > b && b + c > a;
    }
}
