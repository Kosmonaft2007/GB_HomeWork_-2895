/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

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

int Input(string text)
{

    // int Parse(); //  преобразовать строку в число 
    // int.TryParse(); // я попробую преобразовать, если получится лили не получится я сообщу 
    bool f = false;
    int number = 0;
    while (!f) //цикл пока не фолс
    {
        System.Console.WriteLine(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}

void Main()
{
     Console.Clear();

    Console.WriteLine($"\nЗадача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.\n");


    int m = Input("rows");
    int n = Input("columns");
    // int[,] matrix = CreateArray(m,n);

    if (m >= 0 && n >= 0)
    {
        int[,] matrix = CreateArray(n, m);
        FillArray(matrix, 10, 20);
        PrintArray(matrix);

    }

}

Main();
