// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

double[] ArithmeticMeanRow(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] += matrix[i, j];  // Пытался сюда вставить "/matrix.GetLength(0)", но почему-то программа округляля результат и выдавала целые числа
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        array[i] /= matrix.GetLength(0);
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Средние арифметические значения столбцов:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
    System.Console.WriteLine();
}

// int row = new Random().Next(1, 10);
// int col = new Random().Next(1, 10);
int[,] matrix = GenMatrix(new Random().Next(1, 10), new Random().Next(1, 10));
PrintMatrix(matrix);
PrintArray(ArithmeticMeanRow(matrix));
