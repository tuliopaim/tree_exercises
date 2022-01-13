using Trees.SimpleSolution;
using Trees.TreeLikeSolution;

Console.WriteLine("SimpleTree:\n");

var input1 = new List<int> { 3, 2, 1, 6, 0, 5 };
var input2 = new List<int> { 7, 5, 13, 9, 1, 6, 4 };

var simpleTree1 = new SimpleTree(input1);

Console.WriteLine($"Array de entrada: [{string.Join(", ", input1)}]\n");
simpleTree1.PrintTree();
Console.WriteLine();

var simpleTree2 = new SimpleTree(input2);

Console.WriteLine($"Array de entrada: [{string.Join(", ", input2)}]\n");
simpleTree2.PrintTree();
Console.WriteLine();

Console.WriteLine("\n\nTree:\n");

var tree1 = new Tree(input1);

Console.WriteLine($"Array de entrada: [{string.Join(", ", input1)}]\n");
tree1.PrintTree();
Console.WriteLine();

var tree2 = new Tree(input2);

Console.WriteLine($"Array de entrada: [{string.Join(", ", input2)}]\n");
tree2.PrintTree();
Console.WriteLine();
