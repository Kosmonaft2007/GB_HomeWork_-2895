// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Hello, World!");

int GetSummaNumbers (int numb1, int numb2)
{
    int resNumb = 0;
    for (int i = 0; numb1 <= numb2; i++, numb1++)
    {
        resNumb += numb1;
    }
    return resNumb;
}

void Print (int numb)
{
    Console.WriteLine($"{numb}");
}

Console.Write("введите начальное значение натуральных чисел М - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите конечное значение натуральных чисел Н - ");
int number2 = Convert.ToInt32(Console.ReadLine());
int summaNub = GetSummaNumbers(number1, number2);
Console.Write("сумма натуральных чисел - ");
Print(summaNub);
