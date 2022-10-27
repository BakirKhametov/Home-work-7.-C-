// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = NewArray(rows, columns, 0, 9);
PrintArray(array);
MiddleNumber(array);
Console.WriteLine();


int[,] NewArray(int m, int n, int minvalue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minvalue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void MiddleNumber(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sumNumber = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumNumber += arr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {Math.Round(sumNumber / arr.GetLength(0), 1)}  ");
    }
}


