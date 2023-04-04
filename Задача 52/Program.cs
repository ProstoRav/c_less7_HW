/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void FindRowAverage(int[,] matr)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum += matr[j, i];
        }
        double result = 0;
        result = (sum / matr.GetLength(0));
        if (i < matr.GetLength(1) - 1)
        {
            Console.Write($"{result:F1}; ");
        }
        else Console.Write($"{result:F1}.");
    }
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
FindRowAverage(matrix);