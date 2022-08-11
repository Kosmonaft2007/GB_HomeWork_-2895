/*
Реверсирование — изменение прямого порядка на обратный.

У класса string нет метода, который изменял бы порядок элементов в строке на обратный, 
но у класса Array такой метод имеется. 
Поэтому необходимо сначала преобразовать строку в символьный массив, 
затем выполнить реверсирование массива и этот массив преобразовать в строку. Нужно сделать следующее:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversalTheString
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     Console.Clear();
        //     Console.WriteLine("Введите текст");
        //     // string s = "Привет, мир!";
        //     string s = Console.ReadLine();
        //     char[] sReverse = s.ToCharArray();
        //     Array.Reverse(sReverse);
        //     s = new string(sReverse);
        //     Console.WriteLine(s);

        // }

        {
            /*
            Для начала небольшая задачка для разогрева. Напишите программу, 
            которая берет введенный пользователем текст и отображает его вертикально.

            Sample Input:

            Привет
            Sample Output:

            П
            р
            и
            в
            е
            т
            */
            Console.Clear();
            Console.WriteLine("Введите текст");

            /* // the first version of the problem

            string[] words = { "Привет", "мир" };
            foreach (var word in words)
            {
                foreach (var letter in word)
                    Console.WriteLine(letter);
                Console.WriteLine();
            }
            */
            string nameSec = Console.ReadLine();
            string[] words = nameSec.Split(' ');

            foreach (string wordd in words)
            {
                for (int j = 0; j < wordd.Length; j++)
                {
                    Console.WriteLine(wordd[j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}


