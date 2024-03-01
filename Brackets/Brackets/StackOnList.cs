using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    public class StackElement<T>
    {
        public T Value { get; set; }
        public StackElement<T> PreviousElement { get; set; }
    }


    public class StackList<T>
    {
        public StackElement<T> LastElement { get; set; }

        public void Push(T value)
        {
            LastElement = new StackElement<T> { Value = value, PreviousElement = LastElement };
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T res = LastElement.Value;
            LastElement = LastElement.PreviousElement;
            return res;
        }

        public bool IsEmpty()
        {
            return LastElement == null;
        }
    }
}
