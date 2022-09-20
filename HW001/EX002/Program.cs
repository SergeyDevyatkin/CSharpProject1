var a = 2;
var b = 3;
var c = 7;
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