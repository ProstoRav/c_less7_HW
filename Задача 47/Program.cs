/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:F1} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
        }
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
double[,] matrix = new double[rows, columns];
FillArray(matrix);
PrintArray(matrix);