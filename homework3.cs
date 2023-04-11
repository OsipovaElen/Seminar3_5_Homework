//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Массив случайных вещественных чисел: ");
int LengthArray = 10;
double[] array = new double[LengthArray];
GetArray(LengthArray);
PrintArray(array);
double minArray = GetMinArray(array);
double maxArray = GetMaxArray(array);
double diffMaxMin = maxArray - minArray;

void GetArray(int LengthArray)
{
    for (int i = 0; i < LengthArray; i++)
    {
        array[i] =   new Random().NextDouble() * 100;
        array[i] = Math.Round(array[i], 2);
    }
}

void PrintArray(double[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine(array[^1] + "}");
}

double GetMinArray(double[] array)
{
    double minArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minArray)
        {
            minArray = array[i];
        }
    }
    return minArray;
}

double GetMaxArray(double[] array)
{
    double maxArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxArray)
        {
            maxArray = array[i];
        }
    }
    return maxArray;
}

Console.WriteLine($"Разница между max и min элементами массива = {diffMaxMin}");