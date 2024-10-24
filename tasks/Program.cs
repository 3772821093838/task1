using System;

public class MathProblems
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nЗадача 2: Преобразование температуры");
        Console.Write("Введите температуру по Фаренгейту (TF): ");
        double TF = double.Parse(Console.ReadLine());

        double TC = (TF - 32) * 5 / 9;
        Console.WriteLine($"Температура по Цельсию: {TC} °C");
    }
}