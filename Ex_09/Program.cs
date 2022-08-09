Console.Clear();
Console.WriteLine("Введиte");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 1000)
{
int a = Number%10;

int b = Number/100;

int i = (Number - (Number/100)*100) / 10;

Console.WriteLine("Первое число: " + b);
Console.WriteLine("Второе число: " + i);
Console.WriteLine("Третье число: " + a);
}
if (Number > 0 && Number <= 99 )
{
    Console.WriteLine("Третьего числа нема ");
}
else
    Console.WriteLine("Не верны данные ");

