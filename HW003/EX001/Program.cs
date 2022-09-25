Console.Write("Введите число: ");
string number = Console.ReadLine();

void Number(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($" число: {number} - палиндром.");
    }
    else Console.WriteLine($" число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    Number(number);
}
else Console.WriteLine($"Введите правильное число");

