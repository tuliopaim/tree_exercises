namespace Trees.TreeLikeSolution;

public class Tree
{
    public Tree(List<int> values)
    {
        var maxValue = values.Max();
        var maxValueIndex = values.IndexOf(maxValue);

        Root = new(maxValue);

        AddLeftValues(values, maxValueIndex);
        AddRightValues(values, maxValueIndex);
    }

    public TreeNode Root { get; set; }

    private void AddLeftValues(List<int> values, int maxValueIndex)
    {
        var leftOfMaxValue = new List<int>();

        for (int i = 0; i < maxValueIndex; i++)
            leftOfMaxValue.Add(values[i]);

        leftOfMaxValue.Sort();
        leftOfMaxValue.Reverse();

        foreach (var value in leftOfMaxValue)
            Root.AddLeftChild(value);
    }

    private void AddRightValues(List<int> values, int maxValueIndex)
    {
        var rightOfMaxValue = new List<int>();

        for (int i = maxValueIndex + 1; i < values.Count; i++)
            rightOfMaxValue.Add(values[i]);

        rightOfMaxValue.Sort();
        rightOfMaxValue.Reverse();

        foreach (var value in rightOfMaxValue)
            Root.AddRightChild(value);
    }

    public void PrintTree()
    {
        Root.PrintNode();
    }
}

