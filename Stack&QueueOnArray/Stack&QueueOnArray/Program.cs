
public class StackArray
{
    private int[] array;
    private int top;
    private int maxSize;

    public StackArray(int initialSize)
    {
        maxSize = initialSize;
        array = new int[maxSize];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == maxSize - 1)
            ResizeArray();

        array[++top] = value;
    }

    public int Pop()
    {
        return array[top--];
    }

    private void ResizeArray()
    {
        int newSize = maxSize * 2;
        int[] newArray = new int[newSize];
        Array.Copy(array, newArray, maxSize);
        maxSize = newSize;
        array = newArray;
    }

    public bool IsEmpty()
    {
        return (top == -1);
    }
}

public class QueueArray
{
    private int[] array;
    private int front;
    private int rear;
    private int maxSize;

    public QueueArray(int initialSize)
    {
        maxSize = initialSize;
        array = new int[maxSize];
        front = 0;
        rear = -1;
    }

    public void Enqueue(int value)
    {
        if (rear == maxSize - 1)
            ResizeArray();

        array[++rear] = value;
    }

    public int Dequeue()
    {
        int dequeuedItem = array[front++];
        return dequeuedItem;
    }

    private void ResizeArray()
    {
        int newSize = maxSize * 2;
        int[] newArray = new int[newSize];
        Array.Copy(array, newArray, maxSize);
        maxSize = newSize;
        array = newArray;
    }

    public bool IsEmpty()
    {
        return (front == rear + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Stack");
        StackArray stack = new StackArray(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(stack.Pop());
        }

        Console.WriteLine();


        Console.WriteLine("Queue");
        QueueArray queue = new QueueArray(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
