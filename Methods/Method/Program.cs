// First Method Ничего не возвращают и не чиге не принимают 

    void Method1()  //("без аргумента")
    {
    System.Console.WriteLine("без аргумента");
    }
    
    // вызов метода, указывается индификатор (имя)
    Method1();

// Second Method Что то принимает но ничего не возвращает 
void Method2(string msg, int count)
{
    int i=0;

    while(i < count)
    {
    System.Console.WriteLine(msg);
    i++;
    }
}

Method2("какойто код", 4);
Method2(msg: "какойто код", count: 4); //вывод именнованых авргкметов 

// Third Method что то возвращает 
int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

// Fourth Method что то принимет и что то возврвщвют 
string Method4(int count, string text )   // строчку S компанкем count раз 
{
    int i=0;
    string res = "";
    //string res = String.Empty; //аналог ""

    while(i < count)
    {
    res = res + text;
    i++;
    }
    return res;
}

string r  = Method4(10, "Result");
System.Console.WriteLine(r + "\t");

//ПРИМЕР 1 калькулятор 


static void NewMethod()
{
    for (int i = 2; i <= 10; i++) //  внешний цикл 
    {
        for (int j = 1; j <= 10; j++) //оператором тела является второй цикл
        {
            System.Console.WriteLine($"{i} * {j} = {i * j}");// интерполяция строк
        }
        System.Console.WriteLine(); //искуственный разрыв

    }
}

NewMethod();

//ПРИМЕР 2, 4 метод,  Змена символа  
string text = " Ошибка сборки. Устраните ошибки сборки и повторите попытку.";

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    // длина текста в массив 
    int length = text.Length;

    for(int i =0; i < length; i++){
        if(text[i] == oldValue) 
        result= result + $"{newValue}";
        else 
        result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

newText = Replace(newText, 'о', 'О');
Console.WriteLine(newText);

//ПРИМЕР 3, Сортировка масиива мак и мини 

int[] arr = {1,6,3,2,8,5,9};

void PrintArray(int[] array){ // array приходит некий мапссив 
    int count = array.Length;
    for (int i=0; i<count; i++){
        System.Console.WriteLine($"{array[i]}");
    }
    System.Console.WriteLine();
}
void SelectionSort (int[] array){
    int count = array.Length;
    for(int i=0; i<count; i++){

        int minPosition = i; // определяем ту позицию на которую смотрим и запоминаем позицию рабочего элемента
        
        for(int j=i+1; j<count; j++){
            if(array[j] < array[minPosition]){
                minPosition = j;
            }
        }

        //меняем местами элемент 
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
//нужно учесть порядок(последовательность,) вывода команд 
// PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);