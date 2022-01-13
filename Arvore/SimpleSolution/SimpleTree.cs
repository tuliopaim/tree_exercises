namespace Trees.SimpleSolution;

public class SimpleTree
{
    public SimpleTree(List<int> values)
    {
        Root = values.Max();
        var rootIndex = values.IndexOf(Root);

        FillLeftNodes(values, rootIndex);
        FillRightNodes(values, rootIndex);
    }

    public int Root { get; set; }

    public List<int> LeftNodes { get; private set; } = new();

    public List<int> RightNodes { get; private set; } = new();

    public void PrintTree()
    {
        Console.WriteLine("(right)");
        for (var i = RightNodes.Count - 1; i >= 0; i--)
        {
            PrintValue(RightNodes[i], i + 1);
        }

        PrintValue(Root, 0);

        for (var i = 0; i < LeftNodes.Count; i++)
        {
            PrintValue(LeftNodes[i], i + 1);
        }
        Console.WriteLine("(left)");       
    }

    private List<int> FillLeftNodes(List<int> values, int rootIndex)
    {
        for (int i = 0; i < rootIndex; i++)
            LeftNodes.Add(values[i]);

        LeftNodes.Sort();
        LeftNodes.Reverse();

        return LeftNodes;
    }

    private List<int> FillRightNodes(List<int> values, int rootIndex)
    {
        for (int i = rootIndex + 1; i < values.Count; i++)
            RightNodes.Add(values[i]);

        RightNodes.Sort();
        RightNodes.Reverse();

        return RightNodes;
    }

    private static void PrintValue(int value, int distanceFromStart)
    {
        var distanceStr = "";

        for (int i = 0; i < distanceFromStart; i++)
            distanceStr += "| ";

        Console.WriteLine($"{distanceStr}{value}");
    }
}