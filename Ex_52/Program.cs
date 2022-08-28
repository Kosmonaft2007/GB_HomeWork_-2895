/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.s
*/


// Console.Write("Введите строку:");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец:");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; // размер массива
// int m = 7; // размер массива
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив:");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] =  random.Next(10, 99);
//         Console.Write("{0} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }
// if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayWhole[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца № {i + 1} {arithmeticMean}");
}

int[,] TransformationArrayWhole(double[,] array)
{
    int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
        }
    }
    return arrayWhole;
}

void WriteArrayInt(int[,] arrayWhole)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayWhole[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();

    Console.WriteLine($"\nЗадача 52.\n");

}
Main();