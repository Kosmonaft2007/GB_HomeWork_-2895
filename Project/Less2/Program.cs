/*
Дано два целых числа одинаковой длины. 
Учитывая, что метод Console.ReadLine( ) всегда возвращает строку,
а строка - это массив символов, напишите программу, которая должна пройти по всем элементам этих чисел и 
сравнить их. Первый элемент первого числа сравнивается с первым элементом второго, и т.д. В консоль должен
быть выведен ответ :
"Совпадение n элементов", где n - количество совпавших элементов.

Пример:
13456 
23550

У этих чисел одинаковые 2ой и 4ый элемент, следовательно ответ:

"Совпадение 2 элементов"

Sample Input:

13456
23550
Sample Output:

Совпадение 2 элементов
*/
// Console.Clear();
// Console.WriteLine("Введи первые числа: ");

namespace ConsoleApplication3
{

    class Program
    {

        static void Main(string[] args)
        {
            // string[] MyArray_1 = new string[] { "один", "два", "три", "четыре" };
            // string[] MyArray_2 = new string[] {"один","один", "один", "один", "два", "два", "два", "три", "три"};


            Console.Write("Введи первые 5 чисел : ");
            
            string nameSec = Console.ReadLine();
            string[] MyArray_1 = nameSec.Split(' ');

            Console.Write("Введи вторые 5 чисел : ");
           
            string nameSec2 = Console.ReadLine();
            string[] MyArray_2 = nameSec2.Split(' ');
            int Count = 0;

            for (int i = 0; i < MyArray_1.Length; i++)
            {
                for (int j = 0; j < MyArray_2.Length; j++)
                {
                    if (MyArray_1[i] == MyArray_2[j])
                        Count++;
                }
                Console.WriteLine("Элемент массива MyArray_1: '{0}' повторяются в массиве MyArray_2 {1} раз", MyArray_1[i], Count);

                Console.WriteLine("Совпадение {1} элементов", MyArray_1[i], Count);
                Count = 0;
            }


            Console.ReadKey(true);
        }
    }
}