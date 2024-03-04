

public class StackArray
{
    private int[] array;
    private int top;
    private int maxSize;

    public StackArray(int size)
    {
        maxSize = size;
        array = new int[maxSize];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        array[++top] = value;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        return array[top--];
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

    public QueueArray(int size)
    {
        maxSize = size;
        array = new int[maxSize];
        front = 0;
        rear = -1;
    }

    public void Enqueue(int value)
    {
        if (rear == maxSize - 1)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }
        array[++rear] = value;
    }

    public int Dequeue()
    {
        if (front == rear + 1)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        int dequeuedItem = array[front++];
        return dequeuedItem;
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
        StackArray stack = new StackArray(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        stack.Push(5);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine();

        QueueArray queue = new QueueArray(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}
