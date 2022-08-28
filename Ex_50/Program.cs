/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int [,] CreateArray(int rows, int сolumns) // метот который принимает столбцы и строки 
{
    return new int [rows,  сolumns];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
   
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++) //  по строчкам 
    {
        for (int column = 0; column < columns; column++) //  по колонкам  
        {
            array[row, column] = new Random().Next(minValue,  maxValue); 
        }
        
    }
}

void PrintArray (int [,] array)
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
    while( !f ) //цикл пока не фолс
    {
        System.Console.WriteLine(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}

void Main ()
{

    Console.Clear();

    Console.WriteLine($"\nЗадача 50. Напишите программу, которая на вход принимает позиции элемента в \n двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\n");


     int m = Input("rows");
    int n = Input("columns");
    // int[,] matrix = CreateArray(m,n);

if (m>= 0 && n >=0)
{int [,] matrix = CreateArray( n,m);
FillArray(matrix, 10, 20);
PrintArray(matrix);


}

}

Main();
