
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("0/1");
Farey(0, 1, 1, 1, n);
Console.WriteLine("1/1");

static void Farey(int a, int b, int c, int d, int n)
{
    if (b + d > n)
        return;

    Farey(a, b, a + c, b + d, n);
    Console.WriteLine((a + c) + "/" + (b + d));
    Farey(a + c, b + d, c, d, n);
}
