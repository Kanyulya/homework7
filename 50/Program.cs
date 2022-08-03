// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите строку элемента"); // для заданного в условии массива
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец элемента");
// int N = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[,]{
// {1,4,7,2},
// {5,9,2,3},
// {8,4,2,4}};
// if (M >= array.GetLength(0) || N >= array.GetLength(1))
//     Console.WriteLine("Элемента с такой позицией не существет в данном массиве");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (M == i && N == j)
//         { Console.WriteLine(array[i, j] + " - элемент на указанной позиции "); }

//     }
// }

Console.WriteLine("Введите количество строк"); // для массива с задаваемым размером и случайными числами
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку элемента");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента");
int j0 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M, N];
Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

if (i0 >= M || j0 >= N || i0 < 0 || j0 < 0)
    Console.WriteLine("Элемента с такой позицией не существет в данном массиве");
else
{
    Console.WriteLine("{0} - элемент на указанной позиции ", array[i0, j0]);
}
