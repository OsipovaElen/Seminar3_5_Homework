//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Массив случайных двузначных чисел: ");
int LengthArray = 10;
int[] array = new int[LengthArray];
GetArray(LengthArray);
PrintArray(array);
int SumNotEvenPosishion = GetSumNotEvenPosishion(array);

void GetArray(int LengthArray)
{
    for (int i = 0; i < LengthArray; i++)
    {
       array[i] = new Random().Next(-99, 100);
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

int GetSumNotEvenPosishion(int[] array)
{
    int SumNotEvenPosishion = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        SumNotEvenPosishion = SumNotEvenPosishion + array[i];
    }
    return SumNotEvenPosishion;
}

Console.WriteLine($"Сумма чисел нечетных позиций = {SumNotEvenPosishion}");