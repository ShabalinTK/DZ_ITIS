using System;

using System.Collections.Generic;

class QueueList<T>
{
    private List<T> elements = new List<T>();

    public void Enqueue(T item)
    {
        elements.Add(item);
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty");
        }
        T item = elements[0];
        elements.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty");
        }
        return elements[0];
    }

    public int Count
    {
        get { return elements.Count; }
    }

    public bool IsEmpty
    {
        get { return elements.Count == 0; }
    }
}

class QueueArray<T>
{
    private T[] elements;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public QueueArray()
    {
        capacity = 4;
        elements = new T[4];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(T item)
    {
        if (size == capacity)
        {
            capacity *= 2;
            T[] newElements = new T[capacity];
            for (int i = 0; i < size; i++)
            {
                newElements[i] = elements[(front + i) % size];
            }
            elements = newElements;
            front = 0;
            rear = size - 1;
        }
        rear = (rear + 1) % capacity;
        elements[rear] = item;
        size++;
    }

    public T Dequeue()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T item = elements[front];
        front = (front + 1) % capacity;
        size--;
        return item;
    }

    public T Peek()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return elements[front];
    }

    public int Count
    {
        get { return size; }
    }

    public bool IsEmpty
    {
        get { return size == 0; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        QueueList<int> queue = new QueueList<int>();
        QueueArray<int> queue1 = new QueueArray<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue1.Enqueue(10);
        queue1.Enqueue(20);
        queue1.Enqueue(30);
        Console.WriteLine("On Lists \n\n");
        Console.WriteLine("Dequeuing items:");
        while (!queue.IsEmpty)
        {
            Console.WriteLine(queue.Dequeue());
        }
        Console.WriteLine("\n\n");
        Console.WriteLine("On Arrays \n\n");
        Console.WriteLine("Dequeuing items:");
        while (!queue1.IsEmpty)
        {
            Console.WriteLine(queue1.Dequeue());
        }
    }
}
