int[] CreateArrayInt(int size)
{
    return new int[size];
}

int FillArray(int[] array)
{
    int temp = 0;
    int maxInTime = -1;
    int i = 0;
    while (i < 15)
    {
        array[i] = new Random().Next(0, 101);
        if (temp < array[i])
        {
            temp = array[i];
            maxInTime = i;
        }
        i++;
    }
    return (maxInTime);
}

int SumPeople(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < 15)
    {
        sum = sum + array[i];
        i++;
    }
    return sum;
}

void PrintArray(int[] array1, int peopleInDay)
{
    Console.WriteLine();
    int i = 0;
    while (i < 15)
    {

        Console.WriteLine("\tWith " + (i + 8) + "hour. " + (i + 9) + "Hour. The store was buyers " + array1[i]);
        i++;
    }
    Console.WriteLine();
}

int[] shop = CreateArrayInt(15);
int maxInTime = FillArray(shop);
int resultPeople = SumPeople(shop);
PrintArray(shop, resultPeople);
Console.WriteLine("\t maximum number of buyers ( " + shop[maxInTime] + " ) from " + resultPeople + " The came during the day with " +
 (maxInTime + 8) + " hour.on " + (maxInTime + 9) + " hour.");
Console.WriteLine();






