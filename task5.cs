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
            // Обчислення квадратів сторін трикутника
            double aSquare = a * a;
            double bSquare = b * b;
            double cSquare = c * c;

            // Перевірка на прямокутність
            if (aSquare + bSquare == cSquare || aSquare + cSquare == bSquare || bSquare + cSquare == aSquare)
            {
                Console.WriteLine("Це прямокутний трикутник.");
            }
            // Перевірка на гострокутність
            else if (aSquare + bSquare > cSquare && aSquare + cSquare > bSquare && bSquare + cSquare > aSquare)
            {
                Console.WriteLine("Це гострокутний трикутник.");
            }
            // Якщо жодна з умов не виконується, то це тупокутний трикутник
            else
            {
                Console.WriteLine("Це тупокутний трикутник.");
            }
        }
        else
        {
            Console.WriteLine("Це не трикутник.");
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
