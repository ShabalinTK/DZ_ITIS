using Brackets;

static bool CheckString(string str)
{
    var stack = new StackList<char>();
    foreach (char ch in str)
    {
        if (ch == '(' || ch == '{' || ch == '[')
            stack.Push(ch);
        else
        {
            if (ch == ')')
            {
                if (stack.IsEmpty() || stack.Pop() != '(')
                    return false;

            }
            else if (ch == '}')
            {
                if (stack.IsEmpty() || stack.Pop() != '{')
                    return false;

            }
            else if (ch == ']')
            {
                if (stack.IsEmpty() || stack.Pop() != '[')
                    return false;

            }
        }
    }
    return stack.IsEmpty();
}

static bool CheckString2(string str)
{
    var stack = new StackOnArray<char>();
    foreach (char ch in str)
    {
        if (ch == '(' || ch == '{' || ch == '[')
            stack.Push(ch);
        else
        {
            if (ch == ')')
            {
                if (stack.IsEmpty() || stack.Pop() != '(')
                    return false;

            }
            else if (ch == '}')
            {
                if (stack.IsEmpty() || stack.Pop() != '{')
                    return false;

            }
            else if (ch == ']')
            {
                if (stack.IsEmpty() || stack.Pop() != '[')
                    return false;

            }
        }
    }
    return stack.IsEmpty();
}
Console.WriteLine(CheckString("{[()]}"));
Console.WriteLine(CheckString("{}[]()"));
Console.WriteLine(CheckString("{}[]("));
Console.WriteLine(CheckString("{}][()"));
Console.WriteLine(CheckString("{[}]"));
Console.WriteLine(CheckString2("{[()]}"));
