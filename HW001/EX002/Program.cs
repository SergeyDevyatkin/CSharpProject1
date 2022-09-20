int a = 2;
int b = 3;
int c = 7;
if (c > a && a > b)
{
    Console.WriteLine("a=max");
}
if (c < b && b > a)
{
    Console.WriteLine("b=max");
}
if (a < c && c > b)
{
    Console.WriteLine("c=max");
}