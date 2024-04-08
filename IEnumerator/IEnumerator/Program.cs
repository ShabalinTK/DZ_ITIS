using System.Collections;

namespace Task;

public class Program
{
    static void Main(string[] args)
    {
        var str = new MyString("Шла Саша по шоссе");
        foreach (var word in str)
            Console.WriteLine(word);
    }
}

public class MyString : IEnumerable<string>
{
    public string str;

    public MyString(string str)
    {
        this.str = str;
    }
    public IEnumerator<string> GetEnumerator()
    {
        return new MyStringEnumerator(str);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MyStringEnumerator : IEnumerator<string>
{
    public string str;
    public int position;
    public string[] words;

    public MyStringEnumerator(string str)
    {
        this.str = str;
        words = str.Split(' ').OrderBy(word => word.Length).ToArray();
        position = -1;
    }

    public bool MoveNext()
    {
        position++;
        return position < words.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public string Current
    {
        get { return words[position]; }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
    public override string ToString()
    {
        return str;
    }
}
