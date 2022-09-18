

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.




void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void Main()
{

    Console.Clear();

    Console.WriteLine($"\nЗадача 41.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");
    string[] array1;
    Console.WriteLine("Enter strings:");
    string stroka = Console.ReadLine();
    array1 = stroka.Split(' ');
    string[] array2 = new string[array1.Length];

    SecondArrayWithIF(array1, array2);
    PrintArray(array2);



}

Main();


