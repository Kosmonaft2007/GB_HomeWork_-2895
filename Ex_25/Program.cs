// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



System.Console.WriteLine("Введите число");

int x = Convert.ToInt32(Console.ReadLine()); ;

System.Console.WriteLine("Введите число");

int y = Convert.ToInt32(Console.ReadLine());
int sum = x;
int count = 1;

while (count < y)
{
    sum = sum * x;
    count++;
}
System.Console.WriteLine(sum);



