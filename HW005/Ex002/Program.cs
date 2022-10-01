// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 10;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void Search(int[] array)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 > 0) sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"The sum of numbers standing in an odd position  {sum} ");
    Console.WriteLine();
}

Search(FillArray(size));

