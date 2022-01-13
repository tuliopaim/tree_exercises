namespace Trees.TreeLikeSolution;

public class TreeNode
{
    public TreeNode(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public TreeNode? LeftNode { get; private set; }

    public TreeNode? RightNode { get; private set; }

    public void AddLeftNode(int value)
    {
        if (LeftNode is null)
        {
            LeftNode = new TreeNode(value);
            return;
        }

        LeftNode.AddLeftNode(value);
    }

    public void AddRightNode(int value)
    {
        if (RightNode is null)
        {
            RightNode = new TreeNode(value);
            return;
        }

        RightNode.AddRightNode(value);
    }

    public void PrintNode(int distanceFromStart = 0)
    {
        Console.WriteLine("(right)");

        RecursivelyPrintNode(distanceFromStart);

        Console.WriteLine("(left)");
    }

    private void RecursivelyPrintNode(int distanceFromStart)
    {
        if (RightNode is not null)
        {
            RightNode.RecursivelyPrintNode(distanceFromStart + 1);
        }

        var distanceStr = "";

        for (int i = 0; i < distanceFromStart; i++)
            distanceStr += "| ";

        Console.WriteLine($"{distanceStr}{Value}");

        if (LeftNode is not null)
        {
            LeftNode.RecursivelyPrintNode(distanceFromStart + 1);
        }
    }
}

