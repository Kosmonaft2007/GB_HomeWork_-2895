/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/
Console.WriteLine("Hello, World!");

int[,,] CreateArray(int rows, int сolumns, int lines) // метот который принимает столбцы и строки 
{
    return new int[rows, сolumns, lines];
}

void FillArray(int[,,] array, int rowValue, int сolValue, int lineValue)
{
    // Random rend = new Random(2022);
    Random rend = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int lines = array.GetLength(2);
    int numbers = 10;

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            for (int line = 0; line < lines; line++)
            {
                // array[row, column, line] = rend.Next(rowValue, сolValue, lineValue);
                array[row, column, line] = numbers;
                numbers++;
            }
        }

    }
}


void PrintArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int lines = array.GetLength(2);

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            for (int line = 0; line < lines; line++)
            {
                Console.Write($"{array[row, column, line],3}- {row}, {column}, {line}");

            }
        }
        Console.WriteLine();
    }
}


void Main()
{

    Console.Clear();

    Console.WriteLine($"\n Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \n Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\n");



    int[,,] array = CreateArray(6, 6, 5);
    FillArray(array, 0, 10, 10);
    PrintArray(array);
    System.Console.WriteLine();


}

Main();




