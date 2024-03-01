using MyLinkedList;
using System.Collections.Generic;
MyLinkedList<int> lst = new MyLinkedList<int>();

for (int i = 0; i < 5; i++)
    lst.AddLast(i);

Console.WriteLine(lst);
Console.WriteLine("есть ли 1: " + lst.Contains(1));
Console.WriteLine("кол-во 0: " + lst.CountOfValue(0));
Console.WriteLine("кол-во элементов: " + lst.Count());
lst.RemoveAtIndex(2);
Console.WriteLine("удалил элемент под 2 индексом: " + lst);
lst.Clear();
Console.WriteLine("очищенный: " + lst);

MyLinkedList<string> lst2 = new MyLinkedList<string>();

lst2.AddLast("a");
lst2.AddLast("b");
lst2.AddLast("c");
lst2.AddLast("d");
Console.WriteLine(lst2);
Console.WriteLine("есть ли а: " + lst2.Contains("a"));
Console.WriteLine("кол-во b: " + lst2.CountOfValue("b"));
Console.WriteLine("кол-во элементов: " + lst2.Count());
lst2.Clear();
Console.WriteLine("очищенный: " + lst2);