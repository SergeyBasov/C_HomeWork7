/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void PrtMatrixNumber(int[,] matrix, int m, int n)
{
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
        Console.WriteLine(matrix[m, n] + " -> значение элемента массива");
    else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
}

int[,] GenerateMatrix(int rows, int col, int fist, int last)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(fist, last);
            Console.Write("{0,3}", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

// Получить от пользователя позиции элемента в двумерном массиве.
int m = GetNum("Введите позицию элемента по строке : ");
int n = GetNum("Введите позицию элемента по столбцу : ");

// Сгенерировать массив заполнить его случайными числами, вывести массив на экран.
int[,] matrix = GenerateMatrix(3, 4, 0, 10);

// Вывести число по заданным позициям или 
PrtMatrixNumber(matrix, m, n);