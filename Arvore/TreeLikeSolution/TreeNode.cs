namespace Trees.TreeLikeSolution;

public class TreeNode
{
    public TreeNode(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public TreeNode? LeftChild { get; private set; }

    public TreeNode? RightChild { get; private set; }

    public void AddLeftChild(int value)
    {
        if (LeftChild is null)
        {
            LeftChild = new TreeNode(value);
            return;
        }

        LeftChild.AddLeftChild(value);
    }

    public void AddRightChild(int value)
    {
        if (RightChild is null)
        {
            RightChild = new TreeNode(value);
            return;
        }

        RightChild.AddRightChild(value);
    }

    public void PrintNode(int distanceFromStart = 0)
    {
        if(LeftChild is not null)
        {
            LeftChild.PrintNode(distanceFromStart + 1);
        }

        var distanceStr = "";

        for (int i = 0; i < distanceFromStart; i++)
            distanceStr += "| ";

        Console.WriteLine($"{distanceStr}{Value}");
                
        if(RightChild is not null)
        {
            RightChild.PrintNode(distanceFromStart + 1);
        }
    }
}

