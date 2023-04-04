/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FindNumber(int[,] matr)
{
    int row, column;
    Console.Write($"Введите номер строки элемента: ");
    int.TryParse(Console.ReadLine()!, out row);
    Console.Write($"Введите номер столбца элемента: ");
    int.TryParse(Console.ReadLine()!, out column);
    if (row < 1 || column < 1 || row > matr.GetLength(0) || column > matr.GetLength(1))
    {
        Console.WriteLine($"Такого элемента нет");
    }
    else Console.WriteLine($"Искомый элемент с номером строки {row} и номером столбца {column} равен {matr[row - 1, column - 1]}");
}

int rows, columns;
Console.Write($"Введите количество строк двумерного массива: ");
int.TryParse(Console.ReadLine()!, out rows);
Console.Write($"Введите количество столбцов двумерного массива: ");
int.TryParse(Console.ReadLine()!, out columns);
if (rows < 1 || columns < 1)
{
    Console.WriteLine($"Невозможно создать массив с такими параметрами, пожалуйста перезапустите программу");
    Environment.Exit(0);
}
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
FindNumber(matrix);