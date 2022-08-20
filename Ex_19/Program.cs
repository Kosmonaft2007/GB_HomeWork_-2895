/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/
// Console.WriteLine("Hello, World!");

    
    
        Console.Clear();
        System.Console.WriteLine();


        System.Console.WriteLine("ВВедите число");
        string str = Console.ReadLine();
        // int Number = Convert.ToInt32(str);
        // int[] count = new int[Number];
        int count = str.Lengrh;
        // string str = Convert.ToString(Number);


        // int d = 0;
        // bool f = isPalidrom(str);
        // if (d == count)
        //     System.Console.WriteLine("1");
        // else 
        // System.Console.WriteLine("0");
        // System.Console.WriteLine(isPalidrom);
   void NumberArray (){
    /*
    1 какой метод войт или инт??
    2 как реализовать проверку на количество индексов?? 
    */
    }

    bool isPalidrom() //(int str)
    {
        // Boolean f = 1;
        
        // int count = Number.Length;
        for (int i = 0; i < count; i++)
        {
            while (str[i] != str[count - 1 - i])
            {
                // d++;
                // f = 0;
                return false;
                break;
            }
            
        }
        return true;
    }
    // isPalidrom(args);
    // Main (args);
    int[] res = isPalidrom( $"{str}");
    // System.Console.WriteLine(res);

// PS: Ну ни ХуЯ не пойму!!! 