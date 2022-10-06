// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел для проверки: "); 
int volume = Convert.ToInt32(Console.ReadLine());             
int count = 0;

while (volume > 0)
{
   Console.Write("Введите число:   ");
    int number =Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
    volume--;
}

Console.WriteLine($"Количество чисел больше 0: {count}");