// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12]-> 19
// [-4, -6, 89, 6]-> 0


int GetSumPlus(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


int[] GenerateRandomArray(int size, int number_A, int number_B)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(number_A, number_B);

    }
    return array;
}
int[] array = GenerateRandomArray(5, 1, 1000);
Console.WriteLine($" [{String.Join(",", array)}]");
Console.WriteLine($" Сумма элементов, стоящих на нечетных позициях: {GetSumPlus(array)}");