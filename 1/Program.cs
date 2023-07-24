
// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetSumPlus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish);

    }
    return array;
}
int[] array = GenerateRandomArray(10, 100, 1000);
Console.WriteLine($"в массиве[{String.Join(",", array)}]");
Console.WriteLine($" количество четных чисел в массиве {GetSumPlus(array)}");