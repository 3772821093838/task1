using System;

public class MathProblems
{
    public static void Main(string[] args)
    {
        // Задача 1: Расстояние между автомобилями
        Console.WriteLine("Задача 1: Расстояние между автомобилями");
        Console.Write("Введите скорость первого автомобиля (V1 км/ч): ");
        double V1 = double.Parse(Console.ReadLine());
        Console.Write("Введите скорость второго автомобиля (V2 км/ч): ");
        double V2 = double.Parse(Console.ReadLine());
        Console.Write("Введите начальное расстояние между автомобилями (S км): ");
        double S = double.Parse(Console.ReadLine());
        Console.Write("Введите время (T часов): ");
        double T = double.Parse(Console.ReadLine());

        double distance = S + (V1 + V2) * T;
        Console.WriteLine($"Расстояние между автомобилями через {T} часов: {distance} км");
    }
}