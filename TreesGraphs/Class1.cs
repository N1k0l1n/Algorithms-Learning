namespace TreesGraphs
{
    public class Class1
    {


        #region Linear Search
        class LinearSearch
        {
            static int linearSearch(List<int> elements, int x)
            {
                //store the lenght of the list
                int lenght = elements.Count;
                for (int i = 0; i < lenght; i++)
                {
                    if (elements[i] == x)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        #endregion

        #region Binary Search
        class BinarySearch
        {
            static int binarySearch(List<int> elements, int x)
            {
                //start the index
                int start = 0;
                //ending index
                int stop = elements.Count - 1;
                //middle
                int middle = (int)((stop - start) / 2);
                //we have reached the end of the search , whithout the element we arer looking for
                while (elements[middle] != x && start < stop)
                {
                    if (x < elements[middle])
                    {
                        stop = middle - 1;
                    }
                    else
                    {
                        stop = middle + 1;

                    }

                    //reset the middle inex
                    middle = (int)((start - stop) / 2);
                }

                return (elements[middle] != x) ? middle : -1;
            }
            #endregion

            #region Build in BinarySearch
            class BinaryBiuldIn
            {
                public static void Main(string[] args)
                {
                    int[] example = new int[6] { 1, 3, 5, 6, 8, 11 };
                    //2params , array and element you are looking for
                    Console.WriteLine(Array.BinarySearch(example, 6));
                }
            }
            #endregion


            #region InterpolationSearch
            class InterpolationSearch
            {
                int interpolationSearch(int[] arr, int length, int x)
                {
                    int low = 0;
                    int high = length - 1;

                    while (low <= high && x >= arr[low] && x <= arr[high])
                    {
                        if (low == high)
                        {
                            if (arr[low] == x)
                            {
                                return low;
                            }
                            else
                            {
                                return -1;
                            }
                        }

                        //Probing the position
                        int pos = low + (high - low) / (arr[high] - arr[low]) * (x - arr[low]);

                        if (arr[pos] == x)
                        {
                            return pos;
                        }

                        if (arr[pos] < x)
                        {
                            low = pos + 1;
                        }
                        else
                        {
                            high = pos - 1;
                        }
                    }
                    return -1;
                }

            }
            #endregion


            //#region Depth First Traversal
            ////Searching on Tree or graphs

            //class DeepthFirstSearch
            //{
            //    public class Node
            //    {
            //        public Node left;
            //        public Node right;
            //        public int data;
            //    }

            //    public static void DeepthFirstSearchTraversalOnTree(Node root)
            //    {
            //        Stack<Node> nodes = new Stack<Node>();
            //        nodes.Push(root);

            //        while (nodes.Count > 0)
            //        {
            //            //Left SIde
            //            Node node = nodes.Pop();

            //            if (node.right != null)
            //            {
            //                nodes.Push(node.right);
            //            }

            //            //Right Side
            //            if (node.left != null)
            //            {
            //                nodes.Push(node.left);
            //            }
            //            Console.WriteLine(" " + node.data);
            //        }
            //    }
            //    public HashSet<int> DeepthFirstSearchTraversalOnGraph(Node root)
            //    {
            //        HashSet<int> visited = new HashSet<int>();
            //        if (!graph.AdjancencyList.ContainsKey(root))
            //        {
            //            return visited;
            //        }

            //        Stack<int> stack = new Stack<int>();
            //        stack.Push(root);

            //        while (stack.Count > 0)
            //        {
            //            int vertex = stack.Pop();

            //            if (visited.Contains(vertex))
            //            {
            //                continue;
            //            }
            //            visited.Add(vertex);

            //            foreach (var neighbor in graph.AdjancencyList[vertex])
            //            {
            //                if (!visited.Contains(neighbor))
            //                {
            //                    stack.Push(neighbor);
            //                }
            //            }

            //        }
            //        return visited;
            //    }
            //}



            //#endregion
        }
    }
}
