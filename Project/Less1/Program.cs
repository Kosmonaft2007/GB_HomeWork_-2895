// See https://aka.ms/new-console-template for more information

Console.Clear();

// Заполняем Рандомными числами массив array
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }    
}

// Выводи на печать заполненый массив 
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int post = 0;

    while(post < count)
    {
        Console.WriteLine(coll[post]);
        post++;
    }
}

//
int IndexOf (int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int post = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            post = index; // куда складываем инднес 
            break;
        }
        index++;
    }
    return post;
}

// сам массив для работы 
int[] array = new int[10];

//запускаем программу 
FillArray(array);
PrintArray(array);


Console.WriteLine("Hello, World!");

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);