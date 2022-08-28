// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void MMArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) max += 1;

    }
    System.Console.WriteLine($"Сумма  {max} ");
}

void PrintArray(int[] array)
{
    int sum = 0;
    int index = 0;


    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");

        if (array[i] > 0) index = i;

        sum += index;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество положительных элементов массива {sum} ");
    System.Console.WriteLine();

}

void Main()
{
    int size = 10;

    Console.Clear();

    Console.WriteLine($"\nЗадача 41.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");


    // PrintArray(FillArray(size));
    MMArray(FillArray(size));

}

Main();