    // Задача: Написать программу, которая из сформированного массива 
// строк содержащих символы и числа создать массив из строк,
//  в который попадут только символы, не являющиеця цифрами.
// Входные данные можно получить путём ввода с клавиатуры,
//  но лучше сделать автогенерацию данных.

string words = " ";
int size = 20;
char[] letter = ("ABCDEFGHJKLMNOPRSTQUVWXYZ1234567890").ToCharArray();

char[] PrintArray(char[] arr)
{
    for (int i = 0; i < size; i++)
    {
        int c = new Random().Next(0, letter.Length - 1);
        words += letter[c];
    }
    Console.Write(words);
    return arr;
}