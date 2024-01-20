namespace lab7
{
    internal class Node
    {
        public Node parent;
        List<Node> children = new List<Node>();

        public void AddChild(Node child)
        {
            children.Add(child);
            child.parent = this;
        }

        public int CountChildren()
        {
            return children.Count;
        }

        //chodzi o potomkow ale nazwal przodkow
        public int CountAncestors()
        {
            int count = 1;
            foreach (Node child in children)
            {
                count += child.CountAncestors();
            }
            return count;   
        }
    }
}
