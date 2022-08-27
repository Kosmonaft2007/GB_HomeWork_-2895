// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();


int size = 5;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void MMArray(int[] array)
{
int max=0;
for (int i = 0; i < array.Length; i++)
{
       if (i > max) max = array[i];
    
}
System.Console.WriteLine($"Сумма чисел, стоящих на четной позиции, соcтаваляет {max} ");
}
void PrintArray(int[] array)
{
    int sum = 0;
    int max = 0;
    int min = 0;

    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        // System.Console.Write(array[i] + " ");
        sum = array[i];
        if (array[i] > max) max = array[i];
        if ( min > array[i] ) min = array[i];
        sum = max + min;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чиселсоcтаваляет {sum} ");
    System.Console.WriteLine();
}
PrintArray(FillArray(size));

