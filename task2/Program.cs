// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)



    Console.Clear();
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] array = NewArray(rows, columns, 0, 9);
    PrintArray(array);
    int number = SearchNumber();



int[,] NewArray(int m, int n, int minvalue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minvalue, maxValue+1);
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

int SearchNumber()
{
    Console.Write("Введите индекс строки массива: ");
    int numberRow = int.Parse(Console.ReadLine());
    Console.Write("Введите индекс столбца массива: ");
    int numberColumn = int.Parse(Console.ReadLine());
    if (numberRow > rows && numberColumn > columns)
    {
        Console.WriteLine($"такой позиции нет");
    }
    else
    {  
        Console.WriteLine($"{array.GetValue(numberRow-1, numberColumn-1)}");
    }
    return SearchNumber();
}


