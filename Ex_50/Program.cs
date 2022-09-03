/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

// Без методов черновой 
/*
int m = 3;
int n = 5;
int[,] matrix = new int[m,n];

// new Random().Next(1,  10); 
for (int row = 0; row < m; row++) //  по строчкам 
{
    for (int column = 0; column < n; column++) //  по колонкам  
    {
        matrix[row, column] = new Random().Next(1,  10); 
        System.Console.Write($"{matrix[row, column],3}");
    }
    System.Console.WriteLine();
}
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

(int, string) Input(int[,] numberArray, int columns, int rows)
{

    var numb = 0;
    var text = "good";
    if (columns <= numberArray.GetLength(0) && rows <= numberArray.GetLength(1))
    {
        numb = numberArray[columns, rows];
    }
    else
    {
        text = "error";
    }
    var res = (numb, text);
    return res;
}

void Main()
{

    Console.Clear();

    Console.WriteLine($"\n  Задача 50. Напишите программу, которая на вход принимает позиции элемента в \n двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\n");


    // int m = Input("rows");
    // int n = Input("columns");
    // int[,] matrix = CreateArray(m,n);

    Console.WriteLine("（╹◡╹） введите размерность двумерного массива - ");


    int numberArray = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = CreateArray(numberArray);

    FillArray(matrix, 10, 20);

    PrintArray(matrix);

    // int[,] FillArray = GetFillArrayNumbers(numberArray);
    Console.WriteLine();
    Console.Write("введите столбец искомого числа - ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите строку искомого числа - ");
    int rows = Convert.ToInt32(Console.ReadLine());
    var numberInArray = Input (matrix, columns, rows);
    Console.WriteLine(numberInArray);



}

Main();
