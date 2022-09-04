

/*
Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[,] SortSumArray(int[,] inSunArray)

{
    int rows = inSunArray.GetLength(0);
    int columns = inSunArray.GetLength(1);

    int sumColumn = 0;
   int minSumColumn =0;
    int count =0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          sumColumn +=inSunArray[i, j];
          minSumColumn = sumColumn;
        }
    }
    return inSunArray ;
}

int SortMinArray (int[,] inSunArray)
{

    int minSumColumn =0;
    int rowsMin = 0;
    int sumColumn = 0;

    for (int i = 0; i < inSunArray.GetLength(0); i++)
    {
        for (int j = 0; j < inSunArray.GetLength(1); j++)
        {
            sumColumn += inSunArray[i, j];
        }
        if (minSumColumn > sumColumn) 
        {
            minSumColumn = sumColumn;
            rowsMin = i;
        }
        // sumColumn=0;
    }
    return rowsMin;
}

void Main()
{

    Console.Clear();

    Console.WriteLine($"\n Задача 56: Задайте прямоугольный двумерный массив. \n Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n");



    int[,] array = CreateArray(6, 6);
    FillArray(array, 0, 10);
    // PrintArray(array);
    System.Console.WriteLine();

    int[,] ar = SortMinArray(array);
    PrintArray(ar);


    // int[,] arr = SortSumArray(array);
    // PrintArray(arr);

}

Main();

