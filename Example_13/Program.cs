/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


        Console.Clear();
        Console.Write("Введи  число больше 4 символов: ");

        int threeNumber = Convert.ToInt32(Console.ReadLine());
       string stringNumber = Convert.ToString(threeNumber);
       
       if (stringNumber.Length > 2) 
        Console.WriteLine(stringNumber[2]);
       else 
            Console.WriteLine("третьей цифры нет");
    

        
    