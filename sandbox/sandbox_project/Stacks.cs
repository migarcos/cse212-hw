public static class Stacks
{
    public static void Run()
    {
        var stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Pop();
        stack.Push(3);
        stack.Push(4);
        stack.Pop();
        stack.Push(5);
        stack.Push(6);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(7);
        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));
    }
}