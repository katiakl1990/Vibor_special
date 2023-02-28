// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма.

string[] StringArrayInput(string step, int size) 
{
    string[] newStringArray = new string[size];
    newStringArray = step.Split(" ");
    return newStringArray;
}

void PrintArray (string [] arrayToPrint) 
{
     Console.Write($"[{String.Join("; ", arrayToPrint)}]");
     Console.WriteLine();
}

string[] SelectThreeSymbolElements(string[] stringArray)
{
    int size = stringArray.Length;
    int newSize = 0;
    int k = 0;
    
    string[] newStringArray = new string[newSize];

    for (int i = 0; i < size; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref newStringArray, newSize);
            newStringArray[k] = stringArray[i];
            k++;

        }
    }
    return newStringArray;
}

void Main()
{
    Console.Clear();
    Console.Write("Введите элементы массива через пробел: ");
    string elements = Console.ReadLine()!;
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    
    
    if (size > 0)
    {
        string[] stringArray = StringArrayInput(elements, size);
        Console.Write("Введенный массив: ");
        PrintArray(stringArray);
        
        string[] newStringArray = SelectThreeSymbolElements(stringArray);
        Console.Write("Отсортированный массив: ");
        PrintArray(newStringArray);
    }
    
    else
    {
        Console.WriteLine("Ошибка. Введенное значение не соответствует требованиям.");
    }
}
Main();

