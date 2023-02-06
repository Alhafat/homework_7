// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] GetArray()
{
    // int[,] array =
    // {
    //     {1, 4, 7, 2},
    //     {5, 9, 2, 3},
    //     {8, 4, 2, 4}
    // };
    System.Console.WriteLine("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array=new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] >= 0) Console.Write(" " + $"{numbers[i, j]}" + "\t");
            else Console.Write($"{numbers[i, j]}" + " \t");
        }
        Console.WriteLine();
    }
}

float[] FindSummInArray(int[,] numbers)
{
    float[] summArray = new float[numbers.GetLength(1)];
    float summ = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            summ += numbers[j, i];
            summArray[i] += summ / numbers.GetLength(0);
            summ = 0;
        }
    }
    return summArray;
}

void PrintSummInArray(float[] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i] >= 0) Console.Write(" " + $"{result[i]:F2}" + "\t");
        else Console.Write($"{result[i]}" + " \t");
    }
}

void Main()
{
    int[,] numbers = GetArray();
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine();
    float[] result = FindSummInArray(numbers);
    PrintSummInArray(result);
}

Main();