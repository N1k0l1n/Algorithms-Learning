
namespace TreeTraversal
{
    public class Class1
    {

        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
        }

        public class Program
        {
            static void InOrder(Node root)
            {
                if (root != null)
                {
                    InOrder(root.Left);
                    Console.WriteLine(root.Data);
                    InOrder(root.Right);
                }
            }

            static void Preorder(Node root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.Data);
                    Preorder(root.Left);
                    Preorder(root.Right);

                }
            }

            static void PostOrder(Node root)
            {
                if (root != null)
                {
                    PostOrder(root.Left);
                    PostOrder(root.Right);
                    Console.WriteLine(root.Data);

                }
            }

            public static void Main(string[] args)
            {
                Node leftNode = new Node()
                {
                    Data = 1,
                    Left = null,
                    Right = null
                };

                Node rightNode = new Node()
                {
                    Data = 3,
                    Left = null,
                    Right = null
                };

                Node rootNode = new Node()
                {
                    Data = 2,
                    Left = leftNode,
                    Right = rightNode
                };

                InOrder(rootNode);
            }


        }

    }
}