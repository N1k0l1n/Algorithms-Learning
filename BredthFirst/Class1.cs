namespace BredthFirst
{
    public class Class1
    {
        public class Node
        {
            public Node left;
            public Node right;
            public int data;
        }

        public class Program
        {
            public void BreadthFirstTraversalOnTree(Node root)
            {
                Queue<Node> nodes = new Queue<Node>();

                if (root == null)
                {
                    return;
                }
                nodes.Enqueue(root);
                while (nodes.Count > 0)
                {
                    Node node = nodes.Dequeue();
                    Console.WriteLine(" " + node.data);

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
            }
        }

        //public HashSet<int> BreadthFirstTraversalOnGraph(Node root)
        //{
        //    HashSet<int> visited = new HashSet<int>();

        //    if (!graph.AdjancencyList.ContainsKey(root))
        //    {
        //        return visited;
        //    }

        //    Queue<int> q = new Queue<int>();
        //    q.Enqueue(root.data);

        //    while (q.Count > 0)
        //    {
        //        int vertex = q.Dequeue();
        //        if (visited.Contains(vertex))
        //        {
        //            continue;
        //        }
        //        visited.Add(vertex);

        //        foreach (var neighboir in graph.AdjancencyList[vertex])
        //        {
        //            if (!visited.Contains(neighboir))
        //            {
        //                q.Enqueue(neighboir);
        //            }
        //        }

        //    }

        //    return visited;

        //}
    }
}