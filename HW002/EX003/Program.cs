Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: "); //понедельник - 1, вторник - 2, среда -3, четверг - 4, пятница - 5, суббота - 6, воскресенье - 7.
int numberDay = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int numberDay) {
  if (numberDay == 6 || numberDay == 7) {
  Console.WriteLine(" выходной день ");
  }
  else Console.WriteLine(" рабочий день ");
}
DayOfTheWeek(numberDay);