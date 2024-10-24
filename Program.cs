using System;

public class MathProblems
{
    public static void Main(string[] args)
    {
        // ... (код для задач 1 и 2)

        // Задача 3: Вычисление функции
        Console.WriteLine("\nЗадача 3: Вычисление функции");
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double term1 = 1; // Начальное значение для (x - 3)^6
        double term2 = 1; // Начальное значение для (x - 3)^3
        double y = 0;

        for (int i = 0; i < 6; i++)
        {
            term1 *= (x - 3); // Умножаем на (x - 3) 6 раз для (x - 3)^6
        }

        for (int i = 0; i < 3; i++)
        {
            term2 *= (x - 3); // Умножаем на (x - 3) 3 раз для (x - 3)^3
        }

        y = 4 * term1 - 7 * term2 + 2;
        Console.WriteLine($"Значение функции y = {y}");
    }
}

