/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
Console.WriteLine("Hello, World!");

int[,] CreateArray(int rows, int сolumns) // метот который принимает столбцы и строки 
{
    return new int[rows, сolumns];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    // Random rend = new Random(2022);
     Random rend = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            // array[row, column] = rend.Next(minValue, maxValue);
            array[row, column] = rend.Next(minValue, maxValue);
        }

    }
}


void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            Console.Write($"{array[row, column],3}");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] inArray)

{
    int rows = inArray.GetLength(0);
    int columns = inArray.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < columns - 1; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (inArray[i, j] > inArray[i, k])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
    return inArray;
}

void Main()
{

    Console.Clear();

    Console.WriteLine($"\n Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");


    int[,] array = CreateArray(6, 6);

    FillArray(array, 0, 10);

    int[,] arr = SortArray(array);
    PrintArray(arr);
    // System.Console.WriteLine();
    // PrintArray(array);
}

Main();