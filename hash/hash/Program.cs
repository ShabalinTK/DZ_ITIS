

using System;
using System.Text;

namespace HashExel
{
    public class Program
    {
        public static void Main()
        {
            var a = new HashExel.Hash();
            a.Insert("Коля", 4);
            a.Insert("Радмир", 16);
            a.Insert("Андрей", 74);
            a.Insert("Женя", 4234);
            a.Insert("Артур", 42);
            a.Insert("Никита", 14);
            a.Insert("Тагир", 16);
            a.Insert("Тимофей", 74);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.getIndex("Андрей"));
            Console.WriteLine(a.getIndex("Тимофей"));
            a.Delete("Артур");
            Console.WriteLine(a.Search("Женя"));
            Console.WriteLine(a.ToString());
            
        }
    }

    public class Hash
    {
        public static int size = 5;
        public LinkedList<LinkedItem>[] indexList = new LinkedList<LinkedItem>[size];
        public int count = 0;

        public void Insert(string name, int value)
        {
            var item = new LinkedItem { Name = name, Value = value };
            int index = Math.Abs(name.GetHashCode()) % size; // Добавляем Math.Abs для обработки отрицательных хэш-кодов
            if (indexList[index] == null)
            {
                indexList[index] = new LinkedList<LinkedItem>();
            }

            if (count != size)
            {
                indexList[index].AddLast(item);
                count++;
            }
            else
            {
                size *= 2;
                LinkedList<LinkedItem>[] newList = new LinkedList<LinkedItem>[size];
                Rehash(newList);
                indexList = newList;
                Insert(name, value); // Повторно вызываем Insert, чтобы добавить элемент в новый массив
            }
        }

        public void Rehash(LinkedList<LinkedItem>[] newList)
        {
            for (int i = 0; i < indexList.Length; i++)
            {
                if (indexList[i] != null)
                {
                    foreach (var item in indexList[i])
                    {
                        if (item != null)
                        {
                            int newIndex = Math.Abs(item.Name.GetHashCode()) % size;
                            if (newList[newIndex] == null)
                                newList[newIndex] = new LinkedList<LinkedItem>();

                            newList[newIndex].AddLast(item);
                        }
                    }
                }
            }
        }

        public int getIndex(string name)
        {
            int hash = Math.Abs(name.GetHashCode()) % size;

            if (indexList[hash] == null)
            {
                return -1;
            }
            foreach (var item in indexList)
            {
                foreach (var str in indexList[hash])
                {
                    if (str.Name.Equals(name))
                    {
                        return hash;
                    }
                }
            }
            return -1;
        }

        public int Delete(string name)
        {
            int hash = Math.Abs(name.GetHashCode()) % size;

            if (indexList[hash] == null)
            {
                return -1;
            }
            foreach (var item in indexList)
            {
                foreach (var str in indexList[hash])
                {
                    if (str.Name.Equals(name))
                    {
                        indexList[hash].Remove(str);
                        break;
                    }
                }
            }
            return -1;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in indexList)
            {
                if (item != null)
                {
                    foreach (var str in item)
                    {
                        sb.Append($"{str.Name} {str.Value} ");
                    }
                }
            }

            return sb.ToString();
        }

        public bool Search(string name)
        {
            var hash = Math.Abs(name.GetHashCode()) % size;
            if (indexList[hash] == null)
            {
                return false;
            }
            foreach (var item in indexList)
            {
                foreach (var str in indexList[hash])
                    if (str.Name.Equals(name))
                        return true;
            }
            return false;
        }

    }

    public class LinkedItem
    {
        public string Name;
        public int Value;
    }
}
