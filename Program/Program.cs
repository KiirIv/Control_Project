/* Написать программу, которая из имеющегося массива строк, 
формирует массив из строк, 
длина которых меньше либо равна 3 символа. */

string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

string[] Arr(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("такого массива нет");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void Print(string[] array)
{
    Console.WriteLine("Массив:");
    PrintArray(array);
    string[] shortArray = Arr(array);
    Console.WriteLine($"Результат:");
    PrintArray(shortArray);
    Console.WriteLine();
}

Print(arr1);
Print(arr2);
Print(arr3);