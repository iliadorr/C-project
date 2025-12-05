﻿// StatsApp project

using StatsApp;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Введите числа через пробел:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Ошибка: ничего не введено.");
    return;
}

string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
double[] numbers = new double[parts.Length];

for (int i = 0; i < parts.Length; i++)
{
    if (!double.TryParse(parts[i], out double val))
    {
        Console.WriteLine($"Ошибка: '{parts[i]}' не является числом.");
        return;
    }

    numbers[i] = val;
}

var calc = new StatisticsCalculator();
var result = calc.CalculateAll(numbers);

Console.WriteLine("\nРезультаты:");
Console.WriteLine($"Среднее: {result.Mean}");
Console.WriteLine($"Медиана: {result.Median}");
Console.WriteLine($"Мода: {(result.Mode.HasValue ? result.Mode.Value.ToString() : "нет")}");
Console.WriteLine($"Минимум: {result.Min}");
Console.WriteLine($"Максимум: {result.Max}");

Console.Write("\nВведите имя файла для сохранения: ");
string? fileName = Console.ReadLine();

if (string.IsNullOrWhiteSpace(fileName))
    fileName = "results.txt";

var fm = new FileManager();
fm.SaveResults(fileName, numbers, result);

Console.WriteLine($"Готово! Результаты сохранены в '{fileName}'.");
