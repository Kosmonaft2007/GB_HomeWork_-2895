/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a = 2;
int b = 3;
int c = 7;

if (a > b && a > c){
    Console.WriteLine ("max = " + a);
}
if (b > a && b > c){
    Console.WriteLine ("max = " + b);
}
if (c > b && c > a){
    Console.WriteLine ("max = " + c);
}

