namespace CompetitiveProgramming.Algorithms;

public class FLtoHTNode
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public List<FLtoHTNode> Children { get; set; } = new();
}

public class HierarchyConverter
{
    public List<FLtoHTNode> ToTree(List<FLtoHTNode> flatList)
    {
        var dic = flatList.ToDictionary(n => n.Id);
        var rootNodes = new List<FLtoHTNode>();

        foreach (var node in flatList)
        {
            if (node.ParentId.HasValue && dic.ContainsKey(node.ParentId.Value))
            {
                // add current node to parent's child list
                dic[node.ParentId.Value].Children.Add(node);
            }
            else
            {
                // If no parent, then it's a root
                rootNodes.Add(node);
            }
        }
        return rootNodes;
    }

    public List<FLtoHTNode> ToFlat(List<FLtoHTNode> tree)
    {
        var flatList = new List<FLtoHTNode>();
        Flatten(tree, flatList);
        return flatList;
    }

    private void Flatten(List<FLtoHTNode> nodes, List<FLtoHTNode> result)
    {
        foreach (var node in nodes)
        {
            result.Add(node); // Add the current element
            if (node.Children.Any())
            {
                Flatten(node.Children, result); // Recursively process children
                node.Children = new List<FLtoHTNode>(); // Optional: clear links to truly "flatten" the structure
            }
        }
    }
}