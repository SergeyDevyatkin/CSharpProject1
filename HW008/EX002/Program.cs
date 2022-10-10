//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] prod = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix2.GetLength(0); ++j)
        
            for (int k = 0; k < matrix2.GetLength(1); ++k)
                      
            prod[i, k] += matrix1[i, j] * matrix2[j, k];
        
    }
    return prod;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int row = 2;
int col = 2;

int[,] matrix1 = CreateMatrix(row, col, 1, 10);
int[,] matrix2 = CreateMatrix(row, col, 10, 20);
int[,] prod = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(matrix1);
Console.WriteLine("~~~~~~");
PrintMatrix(matrix2);
Console.WriteLine("~~~~~~");
PrintMatrix(prod);
