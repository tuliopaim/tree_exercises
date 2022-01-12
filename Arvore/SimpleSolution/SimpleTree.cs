namespace Trees.SimpleSolution;

public class SimpleTree
{
    public SimpleTree(List<int> values)
    {
        var maxValue = values.Max();
        var maxValueIndex = values.IndexOf(maxValue);

        Root = maxValue;

        AddLeftValues(values, maxValueIndex);

        AddRightValues(values, maxValueIndex);
    }

    public int Root { get; set; }
    public List<int> LeftNodes { get; private set; } = new();
    public List<int> RightNodes { get; private set; } = new();

    public void PrintTree()
    {
        for(var i = LeftNodes.Count - 1; i >= 0 ; i--)
        {
            PrintValue(LeftNodes[i], i + 1);
        }

        PrintValue(Root, 0);

        for(var i = 0; i < RightNodes.Count ; i++)
        {
            PrintValue(RightNodes[i], i + 1);
        }
    }

    private void PrintValue(int value, int distanceFromStart)
    { 
        var distanceStr = "";

        for (int i = 0; i < distanceFromStart; i++)
            distanceStr += "| ";

        Console.WriteLine($"{distanceStr}{value}");
    }

    private void AddLeftValues(List<int> values, int maxValueIndex)
    {
        for (int i = 0; i < maxValueIndex; i++)
            LeftNodes.Add(values[i]);

        LeftNodes.Sort();
        LeftNodes.Reverse();
    }

    private void AddRightValues(List<int> values, int maxValueIndex)
    {
        for (int i = maxValueIndex + 1; i < values.Count; i++)
            RightNodes.Add(values[i]);

        RightNodes.Sort();
        RightNodes.Reverse();
    }
}