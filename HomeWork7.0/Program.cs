// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenMatrix(int row, int col)
{
    double[,] matrix = new double[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

int row = InputInt("Введите количество строк");
int col = InputInt("Введите количество столбцов");
double[,] matrix = GenMatrix(row, col);
PrintMatrix(matrix);
