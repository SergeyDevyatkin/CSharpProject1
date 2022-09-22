Console.Clear();
int[] array =  {10, 20, 30, 40, 50, 60, 70};
int n = array.Length;
int sum = 0;
for (int i = 0; i < n; i++)
sum = sum + array[i];
int sr = sum / array.Length ;
Console.WriteLine("Среднее арифметическое");
Console.WriteLine(sr);


