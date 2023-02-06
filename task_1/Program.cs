// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int[,] GetArray()
{
    System.Console.WriteLine("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];
    // Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(int.MinValue, int.MaxValue);
        }
    }
    return array;
}

int[,] PrinArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] >= 0) Console.Write(" " + numbers[i, j] + " \t");
            else Console.Write(numbers[i, j] + " " + " \t");
        }
        Console.WriteLine();
    }
    return numbers;
}


// void Main()
// {
//     int[,] numbers = GetArray();
//     PrinArray(numbers);
// }
int[,] numbers = GetArray();
PrinArray(numbers);

// Main();