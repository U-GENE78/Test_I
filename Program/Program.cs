// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array, string caption)
{
    Console.WriteLine($"\n{caption}\n\n");

    int length = array.Length;
    string temp;

    if(length == 0) 
    {
    Console.WriteLine("The array contains NO elements");
    return;
    }

    Console.WriteLine($"Number\tElement");

    for (int i = 0; i < array.Length; i++)
    {
        temp = (array[i] == string.Empty) ? "=empty=" : array[i];
        Console.Write($"{i:00}\t{temp}\n");
    }
    Console.WriteLine();
}

string[] RemoveLongElements(string[] array, int maxLength)
{
    int length = array.Length;    
    string[] tempArray = new string[length];
    int count = 0;

    for(int i = 0; i < length; i++)
    {
        if(array[i].Length < maxLength + 1)
        {
            tempArray[count] = array[i]; 
            count++;
        };
        
    }

    string[] newArray = new string[count];

    for(int i = 0; i < count; i++)
    {
        newArray[i] = tempArray[i];
    }

    return newArray;
}

/// MAIN

Console.Clear();

int numberOfElements;

Console.Write("Enter the number of elements in array: ");
do
{
    numberOfElements = int.Parse(Console.ReadLine()!);
} while (numberOfElements < 1);

string[] myArray = new string[numberOfElements];

Console.Clear();

for (int i = 0; i < numberOfElements; i++)
{
    Console.Write($"Enter element {i} of the array: ");
    myArray[i] = Console.ReadLine()!;
}

PrintArray(myArray, "ORIGINAL ARRAY");

string[] newArray = RemoveLongElements(myArray, maxLength: 3);

PrintArray(newArray, "NEW ARRAY");