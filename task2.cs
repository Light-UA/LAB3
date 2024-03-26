using System;

class Program
{
    static void Main()
    {
        // Запрошення на введення першого числа
        Console.Write("Введіть перше число: ");
        double num1 = double.Parse(Console.ReadLine());

        // Запрошення на введення другого числа
        Console.Write("Введіть друге число: ");
        double num2 = double.Parse(Console.ReadLine());

        // Запрошення на вибір операції
        Console.WriteLine("Оберіть операцію:");
        Console.WriteLine("1. Додавання (+)");
        Console.WriteLine("2. Віднімання (-)");
        Console.WriteLine("3. Множення (*)");
        Console.WriteLine("4. Ділення (/)");

        // Зчитування введеної операції
        char operation = char.Parse(Console.ReadLine());

        double result = 0; // Змінна для збереження результату операції

        // Виконання відповідної операції залежно від вибору користувача
        switch (operation)
        {
            case '+': // Додавання
                result = num1 + num2;
                break;
            case '-': // Віднімання
                result = num1 - num2;
                break;
            case '*': // Множення
                result = num1 * num2;
                break;
            case '/': // Ділення
                if (num2 != 0) // Перевірка на ділення на нуль
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                    return; // Вихід з програми у випадку помилки
                }
                break;
            default: // Обробка невідомої операції
                Console.WriteLine("Помилка: Невідома операція.");
                return; // Вихід з програми у випадку помилки
        }

        // Виведення результату на екран
        Console.WriteLine($"Результат операції: {result}");
        Console.ReadKey();

    }
    
}
