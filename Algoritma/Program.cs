
class Program
{
    static void Main()
    {
        Tree("azoppoza");
        Console.WriteLine();
        Tree("abccddbeea");
    }

    public static void Tree(string input)
    {
        var stack = new Stack<char>();
        int currentLevel = 0;

        foreach (var c in input)
        {
            if (stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop();
                currentLevel--;
            }
            else
            {
                for (int i = 0; i < currentLevel; i++)
                {
                    Console.Write('-');
                }
                Console.WriteLine(c);
                stack.Push(c);
                currentLevel++;
            }
        }
    }


}
