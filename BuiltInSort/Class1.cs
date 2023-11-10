namespace BuiltInSort
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            int[] example = new int[6] { 3, 1, 6, 2, 8, 0 };
            Array.Sort(example);
            foreach (int i in example)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("");
        }
    }
}