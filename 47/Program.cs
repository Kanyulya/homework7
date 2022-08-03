// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int N = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[M,N];

Random rnd = new Random();

for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            // array[i, j] = rnd.NextDouble(); //этот вариант был на семинаре, но получаются только положительные числа от 0 о 1
            array[i, j] = rnd.Next(-100, 100)/10.0; // так вывод в консоли похож на пример в задании
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();

    }
