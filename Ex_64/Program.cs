// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Hello, World!");

int[] GetNumbs(int numb1, int numb2)
{
    int[] arrayNumbers = new int[(numb2 - numb1) + 1];
    for (int i = 0; numb1 <= numb2; i++, numb1++)
    {
        arrayNumbers[i] = numb1;
    }
    return arrayNumbers;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Enter strings: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите конечное значение натуральных чисел Н - ");
int number2 = Convert.ToInt32(Console.ReadLine());
int[] arrayNub = GetNumbs(number1, number2);
Print(arrayNub);