static int Fib(int n)
{
    if (n < 3)
    {
        return 1;
    }

    return Fib(n - 2) + Fib(n - 1);
}

static void List(int n, List<int> lst)
{
    for (int i = 0; i < n; i++)
    {
        lst.Add(Fib(i));
    }
    foreach (var e in lst)
    {
        Console.WriteLine(e);
    }
}

List<int> lst = new List<int>();
List(15, lst);
