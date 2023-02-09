/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void ShowMatrix(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(" {0,6}", Math.Round(matrix[i, j], 1));
        }
        Console.WriteLine();
    }
}

double[,] GenerateMatrix(int rows, int col, int startRange, int endRange)
{
    double[,] mtrx = new double[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            mtrx[i, j] = new Random().NextDouble() * (startRange - endRange) + endRange;
        }
    }
    return mtrx;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
// Получить значения от пользователя.
int m = GetNum("Введите количество строк : ");
int n = GetNum("Введите количество столбцов : ");

// Сгенерировать массив, заполнить его случайными вещественными числами и вывести на экран.
double[,] matrix = GenerateMatrix(m, n, -10, 10);
ShowMatrix(matrix);