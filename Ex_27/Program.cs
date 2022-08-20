// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine()); ;

int number = 0;

while (x > 0)
{
    int digit = x % 10;
    number = number + digit;
    x = x / 10;
}

System.Console.WriteLine(number);