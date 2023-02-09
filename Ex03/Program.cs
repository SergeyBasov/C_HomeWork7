/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

double[] CalcMatrix(int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int rows = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    double[] result = new double[col];
    for (int j = 0; j < col; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            result[j] += matrix[i, j];
        }
        result[j] /= rows;
        Console.Write(Math.Round(result[j], 1) + "; ");
    }
    return result;
}

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(" {0,4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rows, int col, int startRange, int endRange)
{
    int[,] res = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            res[i, j] = new Random().Next(startRange, endRange);
        }
    }
    return res;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

// Получить от пользователя размеры массива
int m = GetNum("Введите количество строк : ");
int n = GetNum("Введите количество столбцов : ");

// Сгенерировать массив и заполнить его случайными целыми числами, вывести массив на экран.
int[,] matrix = GenerateMatrix(m, n, 0, 9);
ShowMatrix(matrix);

// Сделать подсчет среднего арифметического каждого столбца, вывести результат на экран.
CalcMatrix(matrix);