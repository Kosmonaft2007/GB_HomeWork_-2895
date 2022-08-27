/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

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

void PrintArray(int[] array)
{
    int sum = 0;
    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) sum += array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чисел, стоящих на четной позиции, соcтаваляет {sum} ");
    System.Console.WriteLine();
}

PrintArray(FillArray(size));