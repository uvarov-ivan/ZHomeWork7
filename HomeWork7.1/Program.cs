// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
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
}

int[,] matrix = GenMatrix(4, 4);
PrintMatrix(matrix);

int row = InputInt("Введите номер строки");
int col = InputInt("Введите номер столбца");

if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
{
    System.Console.WriteLine("Такого элемента нет!");
}
else System.Console.WriteLine($"Число на указанной позиции = {matrix[row - 1, col - 1]}");
