using System.Collections.Generic;
using System.Text;

namespace ArrayStack_Queue
{
    public class ArrayStack
    {
        private int[] stackArray;
        private int top, capacity;

        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            stackArray = new int[capacity];
            top = -1;
        }

        public void Push(int value)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Стек переполнен");
                return;
            }

            stackArray[++top] = value;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Стек пуст");
                return -1;
            }

            int value = stackArray[top--];
            return value;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }


    }

    public class ArrayQueue
    {
        private int[] queueArray;
        private int front, rear, size, capacity;

        public ArrayQueue(int capacity)
        {
            this.capacity = capacity;
            queueArray = new int[capacity];
            front = size = 0;
            rear = capacity - 1;
        }

        public void Enqueue(int value)
        {
            if (size == capacity)
            {
                Console.WriteLine("Очередь переполнена");
                return;
            }

            rear = (rear + 1) % capacity;
            queueArray[rear] = value;
            size++;
        }

        public int Dequeue()
        {
            if (size == 0)
            {
                return -1;
            }

            int value = queueArray[front];
            front = (front + 1) % capacity;
            size--;
            return value;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }


    }

    public class Program
    {
        public static void Main()
        {
            var lstack = new ArrayStack(3);
            lstack.Push(1);
            lstack.Push(2);
            lstack.Push(3);
            Console.WriteLine(lstack.Pop());
            Console.WriteLine(lstack.Pop());
            Console.WriteLine(lstack.Pop());
            Console.WriteLine(lstack.IsEmpty());

            Console.WriteLine();

            var lqueue = new ArrayQueue(3);
            lqueue.Enqueue(1);
            lqueue.Enqueue(2);
            lqueue.Enqueue(3);
            Console.WriteLine(lqueue.Dequeue());
            Console.WriteLine(lqueue.Dequeue());
            Console.WriteLine(lqueue.Dequeue());
            Console.WriteLine(lqueue.IsEmpty());
        }
    }
}