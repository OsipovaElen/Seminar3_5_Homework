//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Массив трехзначных чисел положительных числел: ");
int[] array = new int[10];
GetArray();
PrintArray(array);
int CountEven = GetCountEven(array);

void GetArray()
{
    for (int i = 0; i < 10; i++)
    {
       array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}

int GetCountEven(int[] array)
{
    int CountEven = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] % 2 == 0)
        {
            CountEven++;
        }
    }
    return CountEven;
}

Console.WriteLine($"Четных чисел в массиве = {CountEven}");