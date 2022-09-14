// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().NextDouble()*new Random().Next(-100, 101);
//         Console.Write(Math.Round(matrix[i, j], 2) + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.WriteLine("Задайте массив!");
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(-19, 20);
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите строку искомого числа: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец искомого числа: ");
// int column = Convert.ToInt32(Console.ReadLine());

// void FindNumber(int row, int column)
// {
//     if(row<rows && column<columns) Console.Write(matrix[row-1, column-1]);
//     else Console.Write("Такого элемента нет!");
// }

// FindNumber(row, column);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте массив!");
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows, columns];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j]+ "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
void AverageColumns()
{
    
    for(int j=0; j<columns; j++)
    {
        double sumAverage=0;
        for(int i=0; i<rows; i++)
        {
            sumAverage +=matrix[i, j];
            // Console.WriteLine(matrix[i, j]);
        }
        Console.WriteLine("Среднее арифметическое элементов в(о) " + (j+1) + " столбце: " + (Math.Round((sumAverage/rows), 2)));
        Console.WriteLine();
    }
}
AverageColumns();

