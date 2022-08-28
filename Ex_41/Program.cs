// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] FillArray(int size)
{
    Random rend = new Random(2022);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rend.Next(-10, 10);
    }
    return array;
}

void MMArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] > 0)
            max = max + i;
        // max++;

    }
    System.Console.WriteLine($"Сумма элементов в массиве с положительными числами {max} ");
}

void PrintArray(int[] array)
{
    int sum = 0;
    int index = 0;


    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");

        if (array[i] > 0) sum = array[i];

        // sum += index;
        sum++;

    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество положительных чисел массива {sum} ");
    System.Console.WriteLine();

}

void Main()
{
    int size = 10;

    Console.Clear();

    Console.WriteLine($"\nЗадача 41.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");

    // MMArray(FillArray(size));
    PrintArray(FillArray(size));


}

Main();