// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Hello, World!");


ulong GetResNumb (ulong numb1, ulong numb2)
{
    if (numb1 == 0)
    {
        return numb2 +1;
    }
    else if (numb1 > 0 && numb2 == 0)
    {
        return GetResNumb(numb1 -1, 1);
    }
    else if (numb1> 0 && numb2 > 0)
    {
        return GetResNumb(numb1-1, GetResNumb(numb1, numb2 - 1));
    }
    return numb2+1;
}

Console.Write("введите начальное значение функции Аккермана М - ");
ulong number1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("введите конечное значение функции Аккермана Н - ");
ulong number2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("число функции Аккермана - ");
Console.WriteLine(GetResNumb(number1, number2));