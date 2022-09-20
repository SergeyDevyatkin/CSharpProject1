Console.Clear();
Console.Write("Введите трёхзначное число: "); //например 446.589.997 и т.д
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра введенного числа -> "+stringNumber[1]);
