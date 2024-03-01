using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList<T>
    {
        public Elem<T> First { get; set; }


        public void AddFirst(T item)
        {
            Elem<T> newElem = new Elem<T>();
            newElem.Info = item;
            newElem.Next = First;

            First = newElem;
        }

        public void AddLast(T item)
        {
            if (First == null)
            {
                AddFirst(item);
                return;
            }
            var el = First;
            while (el.Next != null)
                el = el.Next;

            el.Next = new Elem<T> { Info = item };
        }

        public void RemoveValue(T x)
        {
            while (First != null && First.Info.Equals(x))
            {
                First = First.Next;
            }
            if (First == null)
            {
                return;
            }

            var elem = First;
            while (elem.Next != null)
            {
                if (elem.Next.Info.Equals(x))
                    elem.Next = elem.Next.Next;
                else
                    elem = elem.Next;
            }
        }

        public void RemoveAtIndex(int k)
        {
            var elem = First;

            if (k == 0)
                elem = elem.Next;
            int count = 0;
            while (elem != null && count < (k - 1))
            {
                elem = elem.Next;
                count++;
            }
            elem.Next = elem.Next.Next;
        }

        public void Clear()
        {
            First = null;
        }

        public int Count()
        {
            int count = 0;
            var elem = First;
            while (elem != null)
            {
                count++;
                elem = elem.Next;
            }
            return count;
        }

        public bool Contains(T item)
        {
            var elem = First;
            while (elem != null)
            {
                if (elem.Info.Equals(item))
                    return true;
                elem = elem.Next;
            }
            return false;
        }
        public int CountOfValue(T item)
        {
            int count = 0;
            var elem = First;

            while (elem != null)
            {
                if (elem.Info.Equals(item))
                {
                    count++;
                }
                elem = elem.Next;
            }

            return count;

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = First;
            while (el != null)
            {
                sb.Append($"{el.Info} -> ");
                el = el.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }



    }

    public class Elem<T>
    {
        public T Info { get; set; }
        public Elem<T> Next { get; set; }
    }
}
