//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  m = 3, n = 4.

//  0,5 7 -2 -0,2

//  1 -3,3 8 -9,9

//  8 7,8 -7,1 9


int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
Random rand = new Random();

double[,] matrix = new double[a,b];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
            
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
            matr[i, j] = rand.NextDouble();
            
            matr[i, j] = Math.Round(rand.Next(1, 100) * 0.1, 2);
        }
        
    }
    
}

Console.Write($"Кол-во строк -> {a}. Кол-во столбцов -> {b}");

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

