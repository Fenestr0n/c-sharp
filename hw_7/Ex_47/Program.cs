﻿/*
Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Main();

void Main()
{
    Console.Write("Введите размер m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    CreateArray(m, n); 
}

void CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10.0;
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }    
}