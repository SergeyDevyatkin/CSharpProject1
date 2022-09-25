//Задача 21
//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numAY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int numAZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numBY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int numBZ = Convert.ToInt32(Console.ReadLine());

double LengthLine(int ax, int ay, int az, int bx, int by, int bz)
{
    if (ax == bx && ay == by && az == bz) return 0;
    int x = bx - ax;
    int y = by - ay;
    int z = bz - az;
    return Math.Sqrt(x * x + y * y + z * z);
}
double lengthAB = LengthLine(numAX, numAY, numAZ, numBX, numBY, numBZ);
double length = Math.Round(lengthAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({numAX}, {numAY}, {numAZ}); B ({numBX}, {numBY}, {numBZ}) -> {length}");