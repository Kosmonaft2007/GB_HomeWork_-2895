//          Задача:
//   Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
//          Программма:

int[,] GetFillArrayNumbers (int columns, int rows)
{
    int[,] fillArrayNumbers = new int[columns, rows];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(0, 20);
        }
    }
    return fillArrayNumbers;
}

double[] GetAverageArrayNumbs (int[,] fillArrayNumbers)
{
    double[] averageArrayNumbs = new double[fillArrayNumbers.GetLength(0)]; 
    double summaNumbers = 0;
    for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
    {
        for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
        {
            summaNumbers += fillArrayNumbers[i, j];
        }
        averageArrayNumbs[j] = summaNumbers / fillArrayNumbers.GetLength(0);
    }
    return averageArrayNumbs;
}

void PrintTwoArray (int[,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{fillArrayNumbers[i, j]:d3} ");
        }
        Console.WriteLine();
    }
}

void PrintOneArray (double[] fillArrayNumbers)
{
    for (int i = 0; i < fillArrayNumbers.Length; i++)
    {
        Console.Write($"{fillArrayNumbers[i]} ");
    }
    Console.WriteLine();
}

Console.Write("введите количество столбцов двумерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк двумерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] fillArray = GetFillArrayNumbers(columns, rows);
Console.WriteLine();
PrintTwoArray(fillArray);
Console.WriteLine();
double[] averageArray = GetAverageArrayNumbs(fillArray);
PrintOneArray(averageArray);