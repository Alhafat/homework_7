// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray()
{
    int[,] array = 
    {
        {1,4,7,2},
        {5,9,2,3},
        {8,4,2,4}
    };
    // int[,] array = new int[new Random().Next(0, int.MaxValue / 100000), new Random().Next(0, int.MaxValue / 100000)];
    // Random rand = new Random();
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         array[i, j] = rand.Next(int.MinValue, int.MaxValue);
    //     }
    // }
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

void FindNumberInArray(int[,] numbers, int row, int line)
{
            if ((row < numbers.GetLength(0)) && (line < numbers.GetLength(1))) System.Console.WriteLine("Искомая позиция содержит следующее значение: " + numbers[row, line]);
            else System.Console.WriteLine($"Введенные параметры выходят за границы массива");
}

void Main()
{
    int[,] numbers = GetArray();
    
    System.Console.WriteLine("Количество строк массива:" + numbers.GetLength(0));  
    System.Console.WriteLine("Введите искомую позицию строки массива: ");
    int row = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Количество столбцов массива:" + numbers.GetLength(1));
    System.Console.WriteLine("Введите искомую позицию столбца массива: ");
    int line = int.Parse(Console.ReadLine()!);
    // Console.WriteLine();                             
    // PrintArray(numbers);                             //не включать при работе с рандомной сборкой
    Console.WriteLine();
    FindNumberInArray(numbers, row, line);
}

Main();