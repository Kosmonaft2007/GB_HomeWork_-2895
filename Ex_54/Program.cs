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

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            array[row, column] = new Random().Next(minValue, maxValue);
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

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

void Main()
{
    // int size = 10;

    Console.Clear();

    Console.WriteLine($"\n Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");

    // MMArray(FillArray(size));
    SortArray(PrintArray(FillArray(3,4)));


}

Main();