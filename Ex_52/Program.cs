/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

*/

// с методами 
/*
1 - создание массива 
2 - заполнение массива 
3 - печать 
4 -

*/

int[,] CreateArray(int numberArray) // метот который принимает столбцы и строки 
{
    return new int[numberArray, numberArray];
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


double[] Input(int[,] numberArray)
{
    double[] ArrayNumbs = new double[numberArray.GetLength(0)];
    double sum = 0;
    for (int j = 0; j < numberArray.GetLength(1); j++)
    {
        for (int i = 0; i < numberArray.GetLength(0); i++)
        {
            sum += numberArray[i, j];
        }
        ArrayNumbs[j] = sum / numberArray.GetLength(0);
    }
    return ArrayNumbs;
}



void PrintTwo (double[] fillArrayNumbers)
{
    for (int i = 0; i < fillArrayNumbers.Length; i++)
    {
        Console.Write($"{fillArrayNumbers[i]} ");
    }
    Console.WriteLine();
}

void Main()
{

    Console.Clear();

    Console.WriteLine($"\n Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n");


    Console.WriteLine("（╹◡╹） введите размерность двумерного массива - ");


    int numberArray = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = CreateArray(numberArray);

    FillArray(matrix, 10, 20);

    PrintArray(matrix);

    Console.WriteLine();

    Console.WriteLine();
    double[] averageArray = Input(matrix);
    PrintTwo(averageArray);


}

Main();
